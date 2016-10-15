using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filer;

namespace FilerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCompressor01()
        {
            iConverter theConverter = new Converter();
            string testString = "aaabcccc";
            theConverter.Compress(testString);
            string res = theConverter.Compressed;
            Assert.AreEqual("a3bc4", res);
        }

        [TestMethod]
        public void TestExpander01()
        {
            iConverter theConverter = new Converter();
            string testString = "a3bc4";
            theConverter.Expand(testString);
            string res = theConverter.Expanded;
            Assert.AreEqual("aaabcccc", res);
        }
    }
}
