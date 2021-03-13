using ModularSample1.Modules.ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModularSample1.Modules.ModuleA
{
    public class ModuleA : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ModuleAView>();
        }
    }
}
