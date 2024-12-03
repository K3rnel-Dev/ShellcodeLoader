using System;
using System.Diagnostics;
using System.IO;

namespace DodzeBuilder.DodzeAlgorithms
{
    internal class ShellcodeConverter
    {
        public static string Run(string targetFile)
        {
            string converterPath = Path.Combine("Modules", "donut.exe");

            if (!File.Exists(converterPath))
            {
                return "Converter module (donut.exe) does not exist!";
            }

            if (!File.Exists(targetFile))
            {
                return "Target file does not exist!";
            }

            try
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.bin");

                string arguments = $"\"-i:{targetFile}\" -o \"{tempFilePath}\"";

                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = converterPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processInfo))
                {
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        string error = process.StandardError.ReadToEnd();
                        return $"Error during conversion: {error}";
                    }
                }

                return tempFilePath;
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
