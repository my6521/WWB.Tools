using System;
using System.Security.Cryptography;
using System.Text;

namespace WWB.Tools
{
    /// <summary>
    /// AES帮助类
    /// </summary>
    public static class AESHelper
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="encryptStr">待加密字符串</param>
        /// <param name="key">密钥，base64字符串（由16字节字符串转换的base64=字符串）</param>
        /// <param name="iv">base64字符串（由16字节字符串转换的base64=字符串）</param>
        /// <returns></returns>
        public static string Encrypt(string encryptStr, string key, string iv)
        {
            if (string.IsNullOrWhiteSpace(encryptStr))
                return null;

            RijndaelManaged rm = new RijndaelManaged
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                Key = Convert.FromBase64String(key),
                IV = Convert.FromBase64String(iv)
            };

            ICryptoTransform cTransform = rm.CreateEncryptor();
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(encryptStr);
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="decryptStr">待解密字符串</param>
        /// <param name="key">密钥，base64字符串（由16字节128位字符串转换的base64字符串）</param>
        /// <param name="iv">base64字符串（由16字节128位字符串转换的base64字符串）</param>
        /// <returns></returns>
        public static string Decrypt(string decryptStr, string key, string iv)
        {
            if (string.IsNullOrWhiteSpace(decryptStr))
                return null;

            RijndaelManaged rm = new RijndaelManaged
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                Key = Convert.FromBase64String(key),
                IV = Convert.FromBase64String(iv)
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            byte[] toDecryptArray = Convert.FromBase64String(decryptStr);
            byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }
    }
}