using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DFExplorer
{
    public static class EncryptionHelper
    {
        public static (byte[] key, byte[] iv) GenerateAESKeyAndIV()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();
                return (aesAlg.Key, aesAlg.IV);
            }
        }

        //public static byte[] EncryptAES(string plainText, byte[] key, byte[] iv)
        //{
        //    using (Aes aesAlg = Aes.Create())
        //    {
        //        aesAlg.Key = key;
        //        aesAlg.IV = iv;

        //        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        //        using (MemoryStream msEncrypt = new MemoryStream())
        //        {
        //            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
        //            {
        //                swEncrypt.Write(plainText);
        //            }
        //            return msEncrypt.ToArray();
        //        }
        //    }
        //}

        //public static string DecryptAES(byte[] cipherText, byte[] key, byte[] iv)
        //{
        //    using (Aes aesAlg = Aes.Create())
        //    {
        //        aesAlg.Key = key;
        //        aesAlg.IV = iv;

        //        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        //        using (MemoryStream msDecrypt = new MemoryStream(cipherText))
        //        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        //        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
        //        {
        //            return srDecrypt.ReadToEnd();
        //        }
        //    }
        //}

        public static byte[] EncryptAES(byte[] plainBytes, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // Write a custom header (e.g., "AESENCRYPTED")
                        byte[] header = Encoding.UTF8.GetBytes("dfxplore");
                        msEncrypt.Write(header, 0, header.Length); // Write header to the stream

                        csEncrypt.Write(plainBytes, 0, plainBytes.Length); // Write the encrypted content
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        public static byte[] DecryptAES(byte[] cipherBytes, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    // Read and validate the header
                    byte[] header = new byte[8]; // "AESENCRYPTED" is 11 bytes
                    msDecrypt.Read(header, 0, header.Length);
                    string headerString = Encoding.UTF8.GetString(header);

                    if (headerString != "dfxplore")
                    {
                        throw new InvalidOperationException("File is not AES encrypted.");
                    }

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream resultStream = new MemoryStream())
                        {
                            csDecrypt.CopyTo(resultStream);
                            return resultStream.ToArray();
                        }
                    }
                }
            }
        }


        public static void ExportKey(byte[] key, string filePath)
        {
            File.WriteAllBytes(filePath, key);
        }

        public static byte[] ImportKey(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }
    }
}