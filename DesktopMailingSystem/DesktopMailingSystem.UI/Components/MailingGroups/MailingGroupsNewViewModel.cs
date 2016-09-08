using DesktopMailingSystem.Infrastructure;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using System;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    class MailingGroupsNewViewModel : BaseViewModel<IMailingGroupsRibbonTabController>, IConfirmNavigationRequest
    {
        private readonly InteractionRequest<Confirmation> confirmExitInteractionRequest;

        public MailingGroupsNewViewModel(IMailingGroupsRibbonTabController controller)
            : base(controller)
        {
            confirmExitInteractionRequest = new InteractionRequest<Confirmation>();
        }
        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            confirmExitInteractionRequest.Raise(
              new Confirmation { Content = "Do you want to leave this view?", Title = "Information" },
              c => { continuationCallback(c.Confirmed); });
        }

        public IInteractionRequest ConfirmExitInteractionRequest
        {
            get { return this.confirmExitInteractionRequest; }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
