﻿using BaseFramework.Configuration;
using BaseFramework.Interfaces;
using BaseFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.BaseClass
{
    [TestClass]
    public class BaseClass
    {

        [AssemblyInitialize]
        public static void Init(TestContext context) 
        {
            ObjectRepository.Config = new AppConfigReader();
            ObjectRepository.Driver = BrowserFactory.InitWebDriver(ObjectRepository.Config.GetBrowser());
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
