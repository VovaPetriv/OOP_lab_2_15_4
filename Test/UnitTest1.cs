using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 0 };
            long result = OOP_lab_2_15_4.Program.IndexOfMin(a);
            Assert.AreEqual(9, result);
        }
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 0 };
            long result = OOP_lab_2_15_4.Program.Multiplication(a);
            Assert.AreEqual(362880, result);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            long result = OOP_lab_2_15_4.Program.IndexOfMin(a);
            Assert.AreEqual(5, result);
        }
        public void TestMethod2()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            long result = OOP_lab_2_15_4.Program.Multiplication(a);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            long result = OOP_lab_2_15_4.Program.IndexOfMin(a);
            Assert.AreEqual(9, result);
        }
        public void TestMethod2()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            long result = OOP_lab_2_15_4.Program.Multiplication(a);
            Assert.AreEqual(0, result);
        }
    }
}
