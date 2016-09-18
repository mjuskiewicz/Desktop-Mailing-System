using DesktopMailingSystem.Contracts;
using DesktopMailingSystem.Infrastructure;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListController : BaseController<IMailingGroupsListViewModel>, IMailingGroupsListController
    {
        IMailingGroupsService _mailingGroupsService;

        public MailingGroupsListController(IMailingGroupsService mailingGroupsService)
        {
            _mailingGroupsService = mailingGroupsService;
        }

        protected override void OnViewModelAssigned()
        {
            base.OnViewModelAssigned();

            ViewModel.MailingGroups = _mailingGroupsService.GetAllMailingGroups();
        }
    }
}
