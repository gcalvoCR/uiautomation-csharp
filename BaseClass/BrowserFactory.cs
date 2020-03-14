using BaseFramework.Configuration;
using BaseFramework.CustomException;
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
    public class BrowserFactory
    {
        public static IWebDriver InitWebDriver(BrowserType type) 
        {
            switch (type) 
            {
                case BrowserType.Chrome:
                    return new ChromeDriver();
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                case BrowserType.IExplorer:
                    return new InternetExplorerDriver();
                default:
                    throw new NoSuitableDriverException("Driver not found: "+ type.ToString());
            }
        }
    }
}
