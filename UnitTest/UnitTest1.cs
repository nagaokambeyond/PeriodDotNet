using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeriodDotNet;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContentValueTest()
        {
            var cls = new Period<int>(10, 20);
            Assert.AreEqual<bool>(cls.Content(9), false);
            Assert.AreEqual<bool>(cls.Content(10), true);
            Assert.AreEqual<bool>(cls.Content(11), true);
            Assert.AreEqual<bool>(cls.Content(19), true);
            Assert.AreEqual<bool>(cls.Content(20), true);
            Assert.AreEqual<bool>(cls.Content(21), false);
        }

        [TestMethod]
        public void ContentStringTest()
        {
            var cls = new Period<string>("bbb", "ccc");
            Assert.AreEqual<bool>(cls.Content("aaz"), false);
            Assert.AreEqual<bool>(cls.Content("bbb"), true);
            Assert.AreEqual<bool>(cls.Content("bbc"), true);
            Assert.AreEqual<bool>(cls.Content("ccc"), true);
            Assert.AreEqual<bool>(cls.Content("daa"), false);
        }

        [TestMethod]
        public void ContentClassTest()
        {
            var cls = new Period<Class1>(new Class1(2), new Class1(9));
            Assert.AreEqual<bool>(cls.Content(new Class1(1)), false);
            Assert.AreEqual<bool>(cls.Content(new Class1(2)), true);
            Assert.AreEqual<bool>(cls.Content(new Class1(3)), true);
            Assert.AreEqual<bool>(cls.Content(new Class1(9)), true);
            Assert.AreEqual<bool>(cls.Content(new Class1(10)), false);
        }
    }
}
