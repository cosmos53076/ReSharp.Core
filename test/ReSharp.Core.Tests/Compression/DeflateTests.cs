using System.Text;
using NUnit.Framework;
using ReSharp.Compression;

namespace ReSharp.Tests.Compression
{
    [TestFixture]
    public class DeflateTests
    {
        [Test]
        public void CompressTest()
        {
            const string source = "Hello World! 你好！";
            var output = Deflate.CompressToBase64String(source, Encoding.UTF8);
            var original = Deflate.DecompressFromBase64String(output, Encoding.UTF8);
            Assert.AreEqual(source, original);
        }

        [Test]
        public void DecompressTest()
        {
            const string source = "1234567890";
            var output = Deflate.CompressToBase64String(source, Encoding.UTF8);
            var original = Deflate.DecompressFromBase64String(output, Encoding.UTF8);
            Assert.AreEqual(source, original);
        }
    }
}