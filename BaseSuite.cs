using System;
using System.Configuration;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseFramework
{
    [TestClass]
    public class BaseSuite
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("First test");
            Thread.Sleep(5000);

        }

        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            

            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
        }
    }
}
