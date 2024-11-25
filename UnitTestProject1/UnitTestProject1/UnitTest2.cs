using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    //test
    [TestClass]
    public class UnitTest2
    {
        test test = new test();
        
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, test.Method1("D:\\Программы\\Project\\УП Рмп\\zd4\\testVar4\\testVar4\\bin\\Debug\\input.txt"));
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, test.Method1("input.txt"));
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, test.Method2("http://input.com?param1=value1&param2=value2"));
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, test.Method2("input.com"));
        }
        
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, test.Method3("D:\\Программы\\Project\\УП Рмп\\zd4\\testVar4\\testVar4\\bin\\Debug\\input"));
        }
        
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, test.Method3("input1"));
        }
        
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, test.Method4("111111111111111111111111111111111111111"));
        }
        [TestMethod]
        public void TestMethod8()
        {
            //создаем строку длиннее 10000 символов
            string result="";
            for (int i = 0; i < 10001; i++)
            { 
                result += i.ToString();
            }
            Assert.AreEqual(false, test.Method4(result));
        }
        
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(false, test.Method4(""));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(true, test.Method6("http:\\gooseGooseDuack?param=value"));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(false, test.Method6("http:\\gooseGooseDuack.com?param=value&param1=value1&param2=value2&param3=value3"));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(false, test.Method6("http:\\gooseGooseDuack.com"));
        }

        [TestMethod]
        public void TestMetho13()
        {
            Assert.AreEqual(true, test.Method7("https://example.com"));
        }
        
        [TestMethod]
        public void TestMetho14()
        {
            Assert.AreEqual(false, test.Method7("https:\\example.com"));
        } 
        
        [TestMethod]
        public void TestMetho15()
        {
            Assert.AreEqual(true, test.Method8("https:\\examplez?param=value.com"));
        }
        
        [TestMethod]
        public void TestMetho16()
        {
            Assert.AreEqual(false, test.Method8("https:\\example.com"));
        }

        [TestMethod]
        public void TestMetho17()
        {
            Assert.AreEqual(true, test.Method5("param1 : value1"));
        }
        
        [TestMethod]
        public void TestMetho18()
        {
            Assert.AreEqual(false, test.Method5("param1:value1"));
        }
    }
}
