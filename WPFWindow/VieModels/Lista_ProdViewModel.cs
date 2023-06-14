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

        public Lista_ProdViewModel(NavigationService makeLista_ProdNavigationService)
        {
            produkty = new ObservableCollection<ProduktViewModel>();

            AddProduktCommand = new NavigateCommand(makeLista_ProdNavigationService);

            
            UpdateList();
        }
        public void UpdateList()
        {
            produkty.Clear();
            foreach(Produkt x in Magazyn.ListaProd.Lista)
            {
                ProduktViewModel temp = new ProduktViewModel(x);
                produkty.Add(temp);
            }
        }
    }
}
