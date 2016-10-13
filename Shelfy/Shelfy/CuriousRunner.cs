using System;
using Topshelf;

namespace Shelfy
{
    public class CuriousRunner : ServiceControl
    {
        public string ServiceName { get; set; }

        public bool IsRunning { get; set; }
        public CuriousRunner(string serviceName)
        {
            ServiceName = serviceName;
        }


        public void Run()
        {
            Console.WriteLine($"{ServiceName} running like hell.");
            IsRunning = true;
        }


        public void StandStill()
        {
            Console.WriteLine($"{ServiceName} standing still.");
            IsRunning = false;
        }

        public bool Start(HostControl hostControl)
        {
            Console.WriteLine($"{ServiceName} started.");

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            Console.WriteLine($"{ServiceName} stopped.");

            return true;
        }
    }
}
