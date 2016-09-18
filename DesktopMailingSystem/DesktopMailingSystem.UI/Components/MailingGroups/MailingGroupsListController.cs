using DesktopMailingSystem.Service;
using System;
using System.ServiceModel;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListController : IMailingGroupsListController
    {
        public MailingGroupsListController()
        {
            Uri mailingGroupsServiceEndPointAddress = new Uri("http://localhost:2222/mailingGroupsService");

            using(var c = new ChannelFactory<IMailingGroupsService>(new BasicHttpBinding(), new EndpointAddress(mailingGroupsServiceEndPointAddress)))
            {
                var s = c.CreateChannel();
                var groups = s.GetAllMailingGroups();

                var count = groups.Count;
            }
        }
    }
}
