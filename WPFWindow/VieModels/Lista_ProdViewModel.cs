using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFWindow.Commands;
using WPFWindow.Models;
using WPFWindow.Services;
using WPFWindow.Stores;

namespace WPFWindow.VieModels
{
    public class Lista_ProdViewModel:ViewModelBase
    {
        private readonly ObservableCollection<ProduktViewModel> produkty;
        public IEnumerable<ProduktViewModel> Produkty => produkty;
        public ICommand AddProduktCommand { get; }
        public ICommand LoadProduktCommand { get; }
        private Magazyn magazyn;

        public Lista_ProdViewModel(Magazyn mag, NavigationService makeLista_ProdNavigationService)
        {
            produkty = new ObservableCollection<ProduktViewModel>();
            magazyn = mag;
            AddProduktCommand = new NavigateCommand(makeLista_ProdNavigationService);
            LoadProduktCommand = new LoadProduktCommand(magazyn,this);


        }
        public static Lista_ProdViewModel LoadViewModel(Magazyn mag, NavigationService makeLista_ProdNavigationService)
        {
            Lista_ProdViewModel viewModel = new Lista_ProdViewModel(mag,makeLista_ProdNavigationService);
            
            viewModel.LoadProduktCommand.Execute(null);
            return viewModel;
        
        }
        public void UpdateList(IEnumerable<Produkt> pro)
        {
            produkty.Clear();
            foreach(Produkt x in pro)
            {
                ProduktViewModel temp = new ProduktViewModel(x);
                produkty.Add(temp);
            }
        }
    }
}
