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
        private static IWebDriver webDriver = null;

        public static IWebDriver Driver 
        {
            get { return webDriver ?? (webDriver = CreateDriver()); }  
        }

        private static IWebDriver CreateDriver()
        {
            webDriver = new FirefoxDriver();
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }

        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return Driver.Title; }
        }

        public static void Goto(string url)
        {
            Driver.Url = baseUrl + url;
        }

        public static void Close()
        {
            Driver.Quit();
            webDriver = null;
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
