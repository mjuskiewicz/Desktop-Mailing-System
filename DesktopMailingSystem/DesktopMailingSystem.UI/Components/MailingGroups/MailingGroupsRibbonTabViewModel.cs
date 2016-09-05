using DesktopMailingSystem.Infrastructure;
using Prism.Commands;
using System.Windows.Input;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsRibbonTabViewModel : BaseViewModel<IMailingGroupsRibbonTabController>
    {
        private readonly ICommand showListOfGroupsCommand;
        private readonly ICommand showFormToAddNewGroupCommand;

        public MailingGroupsRibbonTabViewModel(IMailingGroupsRibbonTabController controller)
            : base(controller)
        {
            showListOfGroupsCommand = new DelegateCommand(OnShowListOfGroupsCommand);
            showFormToAddNewGroupCommand = new DelegateCommand(OnShowFormToAddNewGroupCommand);
        }

        public ICommand ShowListOfGroupsCommand { get { return showListOfGroupsCommand; } }

        public ICommand ShowFormToAddNewGroupCommand { get { return showFormToAddNewGroupCommand; } }

        private void OnShowListOfGroupsCommand()
        {
            Controller.ShowListOfGroups();
        }

        private void OnShowFormToAddNewGroupCommand()
        {
            Controller.ShowFormToAddNewGroup();
        }
    }
}
