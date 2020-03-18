using BaseFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Uri) 
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Uri);
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void Refresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void MaximizeWindow()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
    }
}
