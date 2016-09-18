using DesktopMailingSystem.Contracts;
using System.ServiceModel;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListController : IMailingGroupsListController
    {
        public MailingGroupsListController()
        {
            using (var c = new ChannelFactory<IMailingGroupsService>("MailingGroupsServiceEndPointConfig"))
            {
                var s = c.CreateChannel();
                var groups = s.GetAllMailingGroups();

                var count = groups.Count;
            }
        }
    }
}
