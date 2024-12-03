using System;
using System.IO;
using System.Linq;

namespace DodzeBuilder.DodzeAlgorithms
{
    internal class XorEncryptor
    {
        private static readonly Random random = new Random();

        public static string GenerateHexArray(byte[] data)
        {
            return "new byte[] { " + string.Join(", ", data.Select(b => "0x" + b.ToString("X2"))) + " };";
        }
        public static byte[] EncryptFile(string filePath, byte[] xorKey)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] encryptedBytes = new byte[fileBytes.Length];

            for (int i = 0; i < fileBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(fileBytes[i] ^ xorKey[i % xorKey.Length]);
            }
            return encryptedBytes;
        }

        public static byte[] GenerateRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            random.NextBytes(bytes);
            return bytes;
        }

        public static string GenerateStrBytes(int length)
        {
            byte[] bytes = new byte[length];
            random.NextBytes(bytes);

            return BitConverter.ToString(bytes).Replace("-", " ");
        }
    }
}
