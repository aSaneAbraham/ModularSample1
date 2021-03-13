using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace ModularSample1.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager regionManager, IModuleManager moduleManager)
        {
            this.regionManager = regionManager;

            moduleManager.Run();
            Modules = moduleManager.Modules.ToList();
        }

        private List<IModuleInfo> modules;
        private IModuleInfo selectedModule;

        public List<IModuleInfo> Modules
        {
            get => modules;
            set => SetProperty(ref modules, value);
        }

        public IModuleInfo SelectedModule
        {
            get => selectedModule;
            set
            {
                if (SetProperty(ref selectedModule, value))
                {
                    var Id = new Random().Next(1, 12);
                    var navigationParameters = new NavigationParameters
                    {
                        { "Id", Id }
                    };

                    regionManager.RequestNavigate(
                        "SelectedModuleRegion",
                        $"{selectedModule.ModuleName}View",
                        navigationParameters);
                }
            }
        }
    }
}
