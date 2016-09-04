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
            //_regionManager.RegisterViewWithRegion(RegionNames.ShellContentRegion, () => new MailingGroupsListView());
            //_regionManager.AddToRegion(RegionNames.ShellContentRegion, new MailingGroupsListView());
        }

        private void NavigationCompleted(NavigationResult result)
        {
            MessageBox.Show("asd");
        }
    }
}
