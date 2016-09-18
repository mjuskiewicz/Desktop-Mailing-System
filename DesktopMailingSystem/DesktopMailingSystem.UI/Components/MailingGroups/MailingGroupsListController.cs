using DesktopMailingSystem.Contracts;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListController : IMailingGroupsListController
    {
        public MailingGroupsListController(IMailingGroupsService mailingGroupsService)
        {
            var groups = mailingGroupsService.GetAllMailingGroups();
            var count = groups.Count;
        }
    }
}
