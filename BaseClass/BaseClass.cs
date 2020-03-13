﻿using BaseFramework.Configuration;
using BaseFramework.Interfaces;
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
    //[TestClass]
    public class BaseClass
    {
        public static IConfig config;
        public static IWebDriver driver;

        [AssemblyInitialize]
        private static void Init() {
            config = new AppConfigReader();
            driver = BrowserFactory.InitWebDriver(config.GetBrowser());
        }

    }
}
