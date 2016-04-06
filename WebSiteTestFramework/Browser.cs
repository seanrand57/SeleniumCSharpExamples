using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteTestFramework.Extensions;

namespace WebSiteTestFramework
{
    public static class Browser
    {
        private static string baseUrl = ApplicationSettings.GetBaseURL();
        private static IWebDriver webDriver = new FirefoxDriver();

        public static ISearchContext Driver 
        {
            get { return webDriver; }  
        }

        public static void Initialize()
        {
            Goto("");
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void GoHome()
        {
            Goto("");
        }

        public static string GetURL()
        {
            return webDriver.Url;
        }
    }
}
