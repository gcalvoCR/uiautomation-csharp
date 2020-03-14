using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.CustomException
{
    public class NoSuitableDriverException:Exception
    {
        public NoSuitableDriverException(string mssg) : base(mssg)
        { 
        }
    }
}
