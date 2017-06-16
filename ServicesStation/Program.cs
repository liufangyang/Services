using Topshelf;
using ServicesStation.Jobs;
using Quartz;

namespace ServicesStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://trends.google.com/trends/";
            ScraperJob.ScrapeTrendingKeywordsAndUrl(url);
            //HostFactory.Run(c =>
            //{            
            //    c.SetServiceName("ServicesStation");
            //    c.SetDisplayName("ServicesStation");
            //    ScraperJob.ScrapeTrendingKeywordsAndUrl(url);
            //    //Schedule.ScheduleJobsWithCrontab<HelloJob>(c, "0/1 * * * * ?");
            //    //Schedule.ScheduleJobsWithCrontab<ScraperJob>(c, "
            //});
        }
    }

}
