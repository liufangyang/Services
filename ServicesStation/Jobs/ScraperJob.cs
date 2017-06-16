using System;
using Quartz;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System.Collections;


namespace ServicesStation.Jobs
{
    class ScraperJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var url = "https://trends.google.com/trends/";
            ScrapeTrendingKeywordsAndUrl(url);
        }

        public static void ScrapeTrendingKeywordsAndUrl(string url) 
        {
            Hashtable TrendingKeywordsAndUrl = new Hashtable();

            var options = new PhantomJSOptions();
            options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36");

            var driverService = PhantomJSDriverService.CreateDefaultService();

            driverService.LocalToRemoteUrlAccess = true;
            driverService.WebSecurity = false;
            driverService.LoadImages = false;

            var driver = new PhantomJSDriver(driverService, options);
            try
            {
                driver.Navigate().GoToUrl(url);
                var pagesource = driver.PageSource;
                Console.Write(pagesource);
            }
            catch (Exception e)

            {
                e.ToString();
                driver.Quit();

            }
            driver.Quit();

        }

    }
}
