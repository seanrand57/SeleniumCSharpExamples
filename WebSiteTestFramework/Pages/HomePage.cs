using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTestFramework.Pages
{
    public class HomePage
    {
        [FindsBy(How = How.LinkText, Using = "Return to Selenium home page")]
        private IWebElement homeLink;

        public void Goto()
        {
            Browser.GoHome();
            //homeLink.Click();
        }
    }
}
