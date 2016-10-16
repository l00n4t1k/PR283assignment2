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
            string testString = "--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|";
            theConverter.Compress(testString);
            string res = theConverter.Compressed;
            Assert.AreEqual("2-5#|3#3-#|#2-*#-2#|#-#2-*-#|#-*2-#-#|2#-#+2-#|-#3-$2#|-3#2-#|3-4#|", res);
        }

        [TestMethod]
        public void TestCompressor02()
        {
            iConverter theConverter = new Converter();
            string testString = "aaabcccc";
            theConverter.Compress(testString);
            string res = theConverter.Compressed;
            Assert.AreEqual("3ab4c", res);
        }

        [TestMethod]
        public void TestExpander01()
        {
            iConverter theConverter = new Converter();
            string testString = "2-5#|3#3-#|#2-*#-2#|#-#2-*-#|#-*2-#-#|2#-#+2-#|-#3-$2#|-3#2-#|3-4#|";
            theConverter.Expand(testString);
            string res = theConverter.Expanded;
            Assert.AreEqual("--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|", res);
        }

        [TestMethod]
        public void TestExpander02()
        {
            iConverter theConverter = new Converter();
            string testString = "3ab4cd2e2fg2h";
            theConverter.Expand(testString);
            string res = theConverter.Expanded;
            Assert.AreEqual("aaabccccdeeffghh", res);
        }
    }
}
