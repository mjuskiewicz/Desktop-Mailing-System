using DesktopMailingSystem.Contracts.DTO;
using DesktopMailingSystem.Infrastructure;
using Prism.Regions;
using System.Collections.Generic;
using System.Windows;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListViewModel : BaseViewModel<IMailingGroupsListController>, IMailingGroupsListViewModel, INavigationAware
    {
        private IList<MailingGroup> _mailingGroups;

        public IList<MailingGroup> MailingGroups
        {
            get { return _mailingGroups; }
            set { SetProperty(ref _mailingGroups, value); }
        }
        
        public MailingGroupsListViewModel(IMailingGroupsListController controller)
            : base (controller)
        {
            controller.ViewModel = this;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            int id = (int) navigationContext.Parameters["counter"];
            MessageBox.Show(id.ToString());
        }
    }
}
