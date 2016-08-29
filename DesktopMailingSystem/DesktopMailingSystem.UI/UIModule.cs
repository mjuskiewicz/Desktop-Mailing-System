using DesktopMailingSystem.Infrastructure;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace DesktopMailingSystem.UI
{
    public class UIModule : IModule
    {
        IRegionViewRegistry _regionViewRegistry;

        public UIModule(IUnityContainer container, IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion(RegionNames.ShellMenuRegion, typeof(Components.MailingGroups.MailingListRibbonTab));
        }
    }
}
