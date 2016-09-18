using System;
using System.ServiceModel;

namespace DesktopMailingSystem.Service
{
    class ServiceController
    {
        static void Main(string[] args)
        {
            Uri mailingGroupsServiceEndPointAddress = new Uri("http://localhost:2222/mailingGroupsService");

            ServiceHost serviceHost = new ServiceHost(typeof(MailingGroupsService), mailingGroupsServiceEndPointAddress);

            try
            {
                serviceHost.Open();

                Console.WriteLine("The service is ready");
                Console.WriteLine("Press <ENTER> to terminate service");
                Console.ReadLine();

                serviceHost.Close();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
