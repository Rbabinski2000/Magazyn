using System;
using System.Collections.Generic;
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
    public class MakeProduktViewModel:ViewModelBase
    {
        private string name;
        public string Name { 
            get { 
                return name; 
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
               amount = value;
                OnPropertyChanged(nameof(amount));
            }
        }

        public ICommand AddProduktCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeProduktViewModel(Magazyn mag, NavigationService produktViewNavigationService)
        {
            AddProduktCommand = new AddProduktCommand(mag,this,produktViewNavigationService);
            CancelCommand = new NavigateCommand(produktViewNavigationService);
        }

    }
}
