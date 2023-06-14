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
    public class AddProduktCommand : CommandBase
    {
        private readonly MakeProduktViewModel Produkt;
        private readonly NavigationService ProduktViewNavigationService;
        public AddProduktCommand(MakeProduktViewModel produkt,NavigationService produktViewNavigationService) { 
            Produkt = produkt;
            ProduktViewNavigationService = produktViewNavigationService;
            Produkt.PropertyChanged += OnViewModelPropertyChanged;
        }

        

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(Produkt.Name) && base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            
                foreach(var x in Magazyn.ListaProd.Lista)
                {
                    if(x.Name == Produkt.Name)
                    {
                    MessageBox.Show("Już jest taki produkt", "Succes",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            Magazyn.ListaProd.AddProdukt(Produkt.Name, Produkt.Price,Produkt.Amount);
            ProduktViewNavigationService.Navigate();
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
