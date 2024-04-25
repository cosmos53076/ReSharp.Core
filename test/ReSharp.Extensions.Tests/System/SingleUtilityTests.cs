using System.Globalization;
using System.Threading;
using NUnit.Framework;

namespace ReSharp.Extensions.Tests
{
    [TestFixture]
    public class SingleUtilityTests
    {
        [Test]
        public void GenericTryParseTest1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            SingleUtility.GenericTryParse("0.123", out var value);
            Assert.AreEqual(0.123f, value);
        }
    }
}