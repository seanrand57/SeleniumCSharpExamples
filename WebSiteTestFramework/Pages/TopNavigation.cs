using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTestFramework.Pages
{
    public class TopNavigation
    {
        [FindsBy(How = How.LinkText, Using = "Projects")]
        private IWebElement projectLink;

        [FindsBy(How = How.LinkText, Using = "Download")]
        private IWebElement downloadLink;

        [FindsBy(How = How.LinkText, Using = "Documentation")]
        private IWebElement documentationLink;

        [FindsBy(How = How.LinkText, Using = "Support")]
        private IWebElement supportLink;

        [FindsBy(How = How.CssSelector, Using = "About")]     
        private IWebElement aboutLink;

        public void Projects()
        {
            projectLink.Click();
        }

        public void Download()
        {
            downloadLink.Click();
        }

        public void Support()
        {
            supportLink.Click();
        }

        public void About()
        {
            aboutLink.Click();
        }  

        public string CurrentURL()
        {
            return Browser.GetURL();
        }
    }
}
