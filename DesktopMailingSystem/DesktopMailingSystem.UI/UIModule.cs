using DesktopMailingSystem.Infrastructure;
using DesktopMailingSystem.UI.Components.MailingGroups;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace DesktopMailingSystem.UI
{
    public class UIModule : IModule
    {
        private readonly IRegionViewRegistry _regionViewRegistry;
        private readonly IUnityContainer _container;

        public UIModule(IUnityContainer container, IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
            _container = container;            
        }

        public void Initialize()
        {
            _container.RegisterType<MailingGroupsRibbonTabViewModel>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IMailingGroupsRibbonTabController, MailingGroupsRibbonTabController>();
            _container.RegisterType<object, MailingGroupsListView>("MailingGroupsListView");            

            BindViewModelToView<MailingGroupsRibbonTabViewModel, MailingListRibbonTabView>();

            _regionViewRegistry.RegisterViewWithRegion(RegionNames.ShellMenuRegion, typeof(MailingListRibbonTabView));

        }

        private void BindViewModelToView<TViewModel, TView>()
        {
            ViewModelLocationProvider.Register(typeof(TView).ToString(), () => _container.Resolve<TViewModel>());
        }
    }
}
