using DesktopMailingSystem.Infrastructure;
using Prism.Regions;
using System.Windows;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsListViewModel : BaseViewModel<IMailingGroupsListController> , INavigationAware
    {
        public MailingGroupsListViewModel(IMailingGroupsListController controller)
            : base (controller)
        {

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
