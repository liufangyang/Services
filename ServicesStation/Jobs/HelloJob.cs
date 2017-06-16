using System;
using Quartz;


namespace ServicesStation.Jobs
{
    class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Greetings from HelloJob!");
        }
    }
}
