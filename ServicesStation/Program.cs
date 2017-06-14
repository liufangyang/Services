using Topshelf;
using ServicesStation.Jobs;


namespace ServicesStation
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(c =>
            {
                Schedule.ScheduleJobsWithCrontab<HelloJob>(c, "0/1 * * * * ?");
            });
        }
    }

}
