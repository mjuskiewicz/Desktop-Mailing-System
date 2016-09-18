using DesktopMailingSystem.Contracts;
using DesktopMailingSystem.Infrastructure;
using DesktopMailingSystem.UI.Components.MailingGroups;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System.ServiceModel;

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
            RegisterServices();

            _container.RegisterType<MailingGroupsRibbonTabViewModel>(new ContainerControlledLifetimeManager());
            _container.RegisterType<MailingGroupsListViewModel>(new ContainerControlledLifetimeManager());

            _container.RegisterType<IMailingGroupsRibbonTabController, MailingGroupsRibbonTabController>();
            _container.RegisterType<IMailingGroupsListController, MailingGroupsListController>();

            _container.RegisterType<object, MailingGroupsListView>("MailingGroupsListView");
            _container.RegisterType<object, MailingGroupsNewView>("MailingGroupsNewView");

            BindViewModelToView<MailingGroupsRibbonTabViewModel, MailingGroupsRibbonTabView>();
            BindViewModelToView<MailingGroupsListViewModel, MailingGroupsListView>();
            BindViewModelToView<MailingGroupsNewViewModel, MailingGroupsNewView>();

            _regionViewRegistry.RegisterViewWithRegion(RegionNames.ShellMenuRegion, typeof(MailingGroupsRibbonTabView));
        }

        private void BindViewModelToView<TViewModel, TView>()
        {
            ViewModelLocationProvider.Register(typeof(TView).ToString(), () => _container.Resolve<TViewModel>());
        }

        private void RegisterServices()
        {
            var mailingGroupsServiceFactory = new ChannelFactory<IMailingGroupsService>("MailingGroupsServiceEndPointConfig");

            _container.RegisterInstance<IMailingGroupsService>(mailingGroupsServiceFactory.CreateChannel());
        }
    }
}