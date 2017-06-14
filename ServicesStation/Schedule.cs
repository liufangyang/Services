using Quartz;
using Topshelf.Quartz;


namespace ServicesStation
{
    class Schedule
    {
        public static void ScheduleJobsWithCrontab<T>(Topshelf.HostConfigurators.HostConfigurator qc, string crontabString) where T : IJob
        {
            qc.ScheduleQuartzJobAsService(q =>
                    q.WithJob(() =>
                        JobBuilder.Create<T>().Build())
                    .AddTrigger(() =>
                        TriggerBuilder.Create()
                        .WithCronSchedule(crontabString)
                            .Build())
                           );

        }

        public static void ScheduleJobsWithInterval<T>(Topshelf.HostConfigurators.HostConfigurator qc, int interval) where T : IJob
        {
            qc.ScheduleQuartzJobAsService(q =>
                     q.WithJob(() =>
                         JobBuilder.Create<T>().Build())
                     .AddTrigger(() =>
                         TriggerBuilder.Create()
                             .WithSimpleSchedule(builder => builder
                                 .WithIntervalInSeconds(interval)
                                 .RepeatForever())
                             .Build())
             );
        }
    }
}
