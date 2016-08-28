using System.Windows;

namespace DesktopMailingSystem.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bootstrapper = new ApplicationBootstrapper();
            bootstrapper.Run();
        }
    }
}
