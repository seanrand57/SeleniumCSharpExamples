using System;
using System.Configuration;

namespace WebSiteTestFramework.Extensions
{
    public static class ApplicationSettings
    {
        private static string GetSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetBaseURL()
        {
            return GetSettingValue("BaseURL");
        }        
    }
}
