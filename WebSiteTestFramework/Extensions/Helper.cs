using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTestFramework.Extensions
{
    public class Helper
    {
        public static bool IsTheWebSiteAliveAndUp()
        {
            try
            {
                string URL = ApplicationSettings.GetBaseURL();
                WebRequest request = WebRequest.Create(URL);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    return true;
                }

                return false;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}
