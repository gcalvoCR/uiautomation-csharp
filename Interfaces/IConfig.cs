using BaseFramework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();

        string GetUri();
        string GetUsername();
        string GetPassword();
        int GetPageTimeOut();
        int GetElementTimeOut();

    }
}
