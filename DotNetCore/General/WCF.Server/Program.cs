using System;
using System.ServiceModel;
using WCF.Services;

namespace WCF.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CoreService)))
            {
                host.Open();
                Console.WriteLine("Press a key to finish...");
                Console.ReadKey();
            }
        }
    }
}
