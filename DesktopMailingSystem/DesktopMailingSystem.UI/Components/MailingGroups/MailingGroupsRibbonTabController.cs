using DesktopMailingSystem.Infrastructure;
using Prism.Regions;
using System.Windows;
using System;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsRibbonTabController : IMailingGroupsRibbonTabController
    {
        private readonly IRegionManager _regionManager;
        private int _showListOfGroupsCounter = 0;

        public MailingGroupsRibbonTabController(IRegionManager regionManager)
        {
            if (regionManager == null)
            {
                throw new ArgumentNullException("regionManager");
            }

            _regionManager = regionManager;
        }

        public void ShowFormToAddNewGroup()
        {
            _regionManager.RequestNavigate(RegionNames.ShellContentRegion, "MailingGroupsNewView", NavigationCompleted);
        }

        public void ShowListOfGroups()
        {
            _showListOfGroupsCounter++;
            var parameters = new NavigationParameters();
            parameters.Add("counter", _showListOfGroupsCounter);

            _regionManager.RequestNavigate(RegionNames.ShellContentRegion, "MailingGroupsListView", NavigationCompleted, parameters);
            //_regionManager.RegisterViewWithRegion(RegionNames.ShellContentRegion, () => new MailingGroupsListView());
            //_regionManager.AddToRegion(RegionNames.ShellContentRegion, new MailingGroupsListView());
        }

        private void NavigationCompleted(NavigationResult result)
        {
            MessageBox.Show("The request was completed.");
        }
    }
}
