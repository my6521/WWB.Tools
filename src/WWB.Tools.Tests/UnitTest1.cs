using System.IO;
using Xunit;

namespace WWB.Tools.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var stream = File.OpenRead("D:\\老毕.jpg"))
            {
                var result = ImageCompressHelper.CompressImage(stream, 90, 400);
            }

            using (var stream = File.OpenRead("D:\\老王.jpg"))
            {
                var result = ImageCompressHelper.CompressImage(stream, 90, 500);

                System.Drawing.Image ResourceImage = System.Drawing.Image.FromStream(result);
                ResourceImage.Save("D:\\老王5.jpg");
            }
        }
    }
}