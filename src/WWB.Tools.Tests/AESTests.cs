using System;
using System.Text;
using Xunit;

namespace WWB.Tools.Tests
{
    public class AESTests
    {
        [Fact]
        public void Test1()
        {
            var bt =new byte[] {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F}; // base64 AAECAwQFBgcICQoLDA0ODw

            string key = "MTIzNDU2Nzg5MDEyMzQ1Ng=="; //1234567890123456
            string iv = "MTIzNDU2Nzg5MDEyMzQ1Ng=="; //1234567890123456
            
            var encryptStr = AESHelper.Encrypt("111", key, iv);

            var decryptStr = AESHelper.Decrypt(encryptStr, key, iv);
        }
    }
}