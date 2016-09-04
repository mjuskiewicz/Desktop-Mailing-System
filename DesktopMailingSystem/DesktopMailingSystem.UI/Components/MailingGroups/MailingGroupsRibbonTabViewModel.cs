using DesktopMailingSystem.Infrastructure;
using Prism.Commands;
using System.Windows.Input;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsRibbonTabViewModel : BaseViewModel<IMailingGroupsRibbonTabController>
    {
        private readonly ICommand showListOfGroupsCommand;

        public MailingGroupsRibbonTabViewModel(IMailingGroupsRibbonTabController controller)
            : base(controller)
        {
            showListOfGroupsCommand = new DelegateCommand(OnShowListOfGroupsCommand);
        }

        public ICommand ShowListOfGroupsCommand { get { return showListOfGroupsCommand; } }

        private void OnShowListOfGroupsCommand()
        {
            Controller.ShowListOfGroups();
        }
    }
}
