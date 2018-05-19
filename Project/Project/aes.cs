using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Project
{
    class aes
    {
        public static string Encrypt(string iPlainStr, string iCompleteEncodedKey, string dateTime)
        {
            string time = dateTime.Substring(0, 16);

            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.None;
            aesEncryption.IV = Encoding.ASCII.GetBytes(time);
            aesEncryption.Key = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(iCompleteEncodedKey)));
            byte[] plainText = UTF8Encoding.UTF8.GetBytes(iPlainStr);
            ICryptoTransform crypto = aesEncryption.CreateEncryptor();
            byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherText);
        }


        public static string Decrypt(string iEncryptedText, string iCompleteEncodedKey, string dateTime)
        {
            string time = dateTime.Substring(0, 16);
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.None;
            aesEncryption.IV = Encoding.ASCII.GetBytes(time);
            aesEncryption.Key = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(iCompleteEncodedKey)));
            ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
            byte[] encryptedBytes = Convert.FromBase64CharArray(iEncryptedText.ToCharArray(), 0, iEncryptedText.Length);
            return ASCIIEncoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
        }
        //public static string EncryptMessage(string  text, string key)
        //{
        //    RijndaelManaged aes = new RijndaelManaged();
        //    aes.KeySize = 256;
        //    aes.BlockSize = 128;
        //    aes.Padding = PaddingMode.Zeros;
        //    aes.Mode = CipherMode.CBC;

        //    aes.Key = Encoding.Default.GetBytes(key);
        //    aes.GenerateIV();

        //    string IV = ("-[--IV-[-" + Encoding.Default.GetString(aes.IV));

        //    ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
        //    byte[] plainText = UTF8Encoding.UTF8.GetBytes(text);

        //    return
        //Convert.ToBase64String(Encoding.Default.GetBytes(Encoding.Default.GetString(AESEncrypt.TransformFinalBlock(plainText, 0, plainText.Length)) + IV));

        //}
        //public static string DecryptMessage(string text, string key)
        //{
        //    RijndaelManaged aes = new RijndaelManaged();
        //    aes.KeySize = 256;
        //    aes.BlockSize = 128
        //        ;
        //    aes.Padding = PaddingMode.Zeros;
        //    aes.Mode = CipherMode.CBC;

        //    aes.Key = Encoding.Default.GetBytes(key);

        //    text = Encoding.Default.GetString(Convert.FromBase64String(text));

        //    string IV = text;
        //    IV = IV.Substring(IV.IndexOf("-[--IV-[-") + 9);
        //    text = text.Replace("-[--IV-[-" + IV, "");

        //    text = Convert.ToBase64String(Encoding.Default.GetBytes(text));
        //    aes.IV = Encoding.Default.GetBytes(IV);

        //    ICryptoTransform AESDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
        //    byte[] buffer = Convert.FromBase64String(text);

        //    return Encoding.Default.GetString(AESDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        //}
    }
}
