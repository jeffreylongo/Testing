using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class PanTests
    {
        [TestMethod]
        public void PangramTest()
        {
            // var PanMachine = new PanagramMachine();
            var words = "typing words and words and words";
            var checker = PanagramMachine.Main(words);
            Assert.AreEqual("not pangram", checker);
        }
        [TestMethod]
        public void PangramTest1()
        {
            // var PanMachine = new PanagramMachine();
            var words = "typing words and words and words";
            var checker = PanagramMachine.Main(words);
            Assert.AreEqual("not pangram", checker);
        }
        [TestMethod]
        public void PangramTest2()
        {
            // var PanMachine = new PanagramMachine();
            var words = "typing words and words and words";
            var checker = PanagramMachine.Main(words);
            Assert.AreEqual("not pangram", checker);
        }
        [TestMethod]
        public void PangramTest3()
        {
            // var PanMachine = new PanagramMachine();
            var words = "typing words and words and words";
            var checker = PanagramMachine.Main(words);
            Assert.AreEqual("not pangram", checker);
        }
        [TestMethod]
        public void PangramTest4()
        {
            // var PanMachine = new PanagramMachine();
            var words = "typing words and words and words";
            var checker = PanagramMachine.Main(words);
            Assert.AreEqual("not pangram", checker);
        }
    }
}
