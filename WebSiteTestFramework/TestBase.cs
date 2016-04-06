using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTestFramework
{
    public class TestBase
    {
        public static void Initialize()
        {
            Browser.Initialize();
        }

        public static void CleanUp()
        {
            Browser.Close();
        }
        
    }
}
