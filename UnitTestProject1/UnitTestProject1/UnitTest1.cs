using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        Class1 class1 = new Class1();
        
        //4.2
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, class1.Method1("D:\\Программы\\Project\\УП Рмп\\zd4\\zad4.2\\Zad4_var1\\ConsoleApp1\\bin\\Debug\\input.txt"));
        }
        [TestMethod]
        public void TestMethod13()
        {
            Assert.AreEqual(false, class1.Method1("D:\\Программы\\Project\\УП Рмп\\zd4\\zad4.2\\Zad4_var1\\ConsoleApp1\\bin\\Debug\\input"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, class1.Method1("input.txt"));
        } 



        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, class1.Method2("5 5 5 5"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, class1.Method2("5 5 55  "));
        }
        


        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, class1.Method3("5 5 5 5"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, class1.Method3("a 5 5 5"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(false, class1.Method3("5   5 5"));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, class1.Method3("5 a 5 5"));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(false, class1.Method3("a 5 b 5"));
        }
        [TestMethod]
        public void TestMethod14()
        {
            Assert.AreEqual(false, class1.Method3("a 5 b 5 5"));
        }
        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(false, class1.Method3("a 5 b 5 "));
        }
        [TestMethod]
        public void TestMethod16()
        {
            Assert.AreEqual(false, class1.Method3(""));
        }
        [TestMethod]
        public void TestMethod17()
        {
            Assert.AreEqual(false, class1.Method3("aaaaaaa"));
        }
        [TestMethod]
        public void TestMethod18()
        {
            Assert.AreEqual(false, class1.Method3("a a a a"));
        }


        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(true, class1.Method4("5"));
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(false, class1.Method4("5 a 5 5"));
        }
        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(false, class1.Method4(""));
        }
        [TestMethod]
        public void TestMethod19()
        {
            Assert.AreEqual(false, class1.Method4("a"));
        }
    }
}
