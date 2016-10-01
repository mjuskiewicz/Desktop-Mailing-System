using DesktopMailingSystem.Infrastructure;
using DesktopMailingSystem.UI.Components.MailingGroups.Services;
using System;
using System.Reactive.Linq;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListController : BaseController<IMailingGroupsListViewModel>, IMailingGroupsListController
    {
        IMailingGroupsServiceClient _mailingGroupsService;

        public MailingGroupsListController(IMailingGroupsServiceClient mailingGroupsService)
        {
            _mailingGroupsService = mailingGroupsService;
        }

        protected override void OnViewModelAssigned()
        {
            base.OnViewModelAssigned();

            _mailingGroupsService.GetAllMailingGroups().Subscribe(listOfMailingGroups =>
            {
                ViewModel.MailingGroups = listOfMailingGroups;
            });
        }
    }
}
