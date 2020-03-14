using BaseFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaseFramework.TestScripts.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetUri());
            Thread.Sleep(5000);
        }
    }
}
