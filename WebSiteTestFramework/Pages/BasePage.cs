using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSiteTestFramework.Pages
{
    public abstract class BasePage
    {
        protected abstract string PageName { get; }
        protected abstract string RelativeUrl { get; }
        protected abstract string Title { get; }    
    }
}
