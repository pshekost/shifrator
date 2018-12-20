using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Шифр;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // исходные данные

            int i = Convert.ToChar("r");
            string expected = "p";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // исходные данные

            int i = Convert.ToChar("c");
            string expected = "a";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            // исходные данные

            int i = Convert.ToChar("6");
            string expected = "4";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod4()
        {
            // исходные данные

            int i = Convert.ToChar("K");
            string expected = "I";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod5()
        {
            // исходные данные

            int i = Convert.ToChar("-");
            string expected = "+";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // исходные данные
            int i = Convert.ToChar("(");
            string expected = "&";
            Program g = new Program();
            string rezult = g.bit(i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
    }
}
