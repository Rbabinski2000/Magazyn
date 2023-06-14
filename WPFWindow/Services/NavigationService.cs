using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Stores;
using WPFWindow.VieModels;

namespace WPFWindow.Services
{
    public class NavigationService
    {
        private readonly NavigationStore Store;
        private readonly Func<ViewModelBase> createViewModel;

        public NavigationService(NavigationStore store, Func<ViewModelBase> createViewModel)
        {
            Store = store;
            this.createViewModel = createViewModel;
        }
        public void Navigate()
        {
            Store.CurrentViewModel = createViewModel();
        }
    }
}
