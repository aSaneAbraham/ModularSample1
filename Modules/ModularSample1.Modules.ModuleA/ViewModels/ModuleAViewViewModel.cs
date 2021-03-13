using Prism.Mvvm;
using Prism.Regions;

namespace ModularSample1.Modules.ModuleA.ViewModels
{
    public class ModuleAViewViewModel : BindableBase, INavigationAware
    {
        private int passedId;

        public int PassedId
        {
            get => passedId;
            set => SetProperty(ref passedId, value);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            PassedId = (int)navigationContext.Parameters["Id"];
        }
    }
}
