using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Proc_Tests
{
    [TestClass]
    public class Proc_Tests
    {
        [TestMethod]
        public void Pow_3and3_27returned()
        {
            int A = 3;
            int B = 3;
            int expected = 27;

            Proc c = new Proc();
            int actual = c.Pow(A, B);

            Assert.AreEqual(expected, actual);
        }
        public void Pow_2and4_27returned()
        {
            int A = 2;
            int B = 4;
            int expected = 16;

            Proc c = new Proc();
            int actual = c.Pow(A, B);

            Assert.AreEqual(expected, actual);
        }
    }
}
