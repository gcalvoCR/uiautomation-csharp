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
    }
}
