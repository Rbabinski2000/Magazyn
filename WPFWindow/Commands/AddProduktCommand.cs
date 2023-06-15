using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFWindow.Models;
using WPFWindow.Services;
using WPFWindow.VieModels;

namespace WPFWindow.Commands
{
    public class AddProduktCommand : AsyncCommandBase
    {
        private readonly MakeProduktViewModel Produkt;
        private readonly NavigationService ProduktViewNavigationService;
        private Magazyn magazyn;
        public AddProduktCommand(Magazyn mag,MakeProduktViewModel produkt,NavigationService produktViewNavigationService) { 
            Produkt = produkt;
            ProduktViewNavigationService = produktViewNavigationService;
            Produkt.PropertyChanged += OnViewModelPropertyChanged;
            magazyn = mag;
        }

        

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(Produkt.Name) && base.CanExecute(parameter);
        }
        public override async Task ExecuteAsync(object? parameter)
        {

            
            Produkt pro = new Produkt(Produkt.Name, Produkt.Price, Produkt.Amount);
            try
            {

            await magazyn.AddProdukt(pro);
                MessageBox.Show("Poprawnie dodano produkt.", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally { 
            ProduktViewNavigationService.Navigate();
            }
        }
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName== nameof(MakeProduktViewModel.Name))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
