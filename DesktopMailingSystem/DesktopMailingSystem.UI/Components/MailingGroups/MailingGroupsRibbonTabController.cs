using DesktopMailingSystem.Infrastructure;
using Prism.Regions;
using System.Windows;
using System;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public class MailingGroupsRibbonTabController : IMailingGroupsRibbonTabController
    {
        private readonly IRegionManager _regionManager;
        public MailingGroupsRibbonTabController(IRegionManager regionManager)
        {
            if (regionManager == null)
            {
                throw new ArgumentNullException("regionManager");
            }

            _regionManager = regionManager;
        }

        public void ShowListOfGroups()
        {
            _regionManager.RequestNavigate(RegionNames.ShellContentRegion, "MailingGroupsListView", NavigationCompleted);
        }

        private void NavigationCompleted(NavigationResult result)
        {
            MessageBox.Show("The request was completed.");
        }
    }
}
