using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SokobanFiler;

namespace FilerTests
{
    [TestClass]
    public class LoaderTests
    {
        static Filer F;
        static Saver S;
        static Loader L;
        //protected Filer f;
        //protected Saver s;

        [ClassCleanup]
        public static void TestClean()
        {
            F = null;
            S = null;
            L = null;
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

            F = new Filer();
            S = F.GetMySaver();
            L = F.GetMyLoader();
            F.MyLevels = new string[] { "--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|", "--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|" };
            S.Save("F:\\TestFiles\\LoaderTestInitFile.txt");
            F.MyLevels = null;
        }

        [TestMethod]
        public void TestLoadFromFile01()
        {
            string[] expected = new string[] { "--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|", "--#####|###---#|#--*#-##|#-#--*-#|#-*--#-#|##-#+--#|-#---$##|-###--#|---####|" };
            L.Load("F:\\TestFiles\\LoaderTestInitFile.txt");
            string[] res = F.MyLevels;
            CollectionAssert.AreEqual(expected, res);
        }

    }
}