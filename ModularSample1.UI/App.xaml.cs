using System.Windows;
using ModularSample1.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace ModularSample1.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override IModuleCatalog CreateModuleCatalog() =>
            new DirectoryModuleCatalog() { ModulePath = "Modules" };
    }
}
