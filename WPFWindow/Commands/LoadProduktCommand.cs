using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFWindow.Models;
using WPFWindow.VieModels;

namespace WPFWindow.Commands
{
    public class LoadProduktCommand : AsyncCommandBase
    {
        private Magazyn magazyn;
        private Lista_ProdViewModel viewModel;

        public LoadProduktCommand(Magazyn magazyn, Lista_ProdViewModel viewModel)
        {
            this.magazyn = magazyn;
            this.viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {

                IEnumerable<Produkt> Produkty = await magazyn.GetAllProdukt();
                viewModel.UpdateList(Produkty);
            }
            catch (Exception)
            {
                MessageBox.Show("Załadowanie produktów nie powiodła się.","Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
