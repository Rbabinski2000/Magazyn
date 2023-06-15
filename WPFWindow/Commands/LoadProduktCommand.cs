using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFWindow.Models;
using WPFWindow.Stores;
using WPFWindow.VieModels;

namespace WPFWindow.Commands
{
    public class LoadProduktCommand : AsyncCommandBase
    {
        private MagazynStore magazynStore;
        private Lista_ProdViewModel viewModel;

        public LoadProduktCommand(MagazynStore magazynstore, Lista_ProdViewModel viewModel)
        {
            this.magazynStore = magazynstore;
            this.viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {

                await magazynStore.Load();
                viewModel.UpdateList(magazynStore.ListaProd);
            }
            catch (Exception)
            {
                MessageBox.Show("Załadowanie produktów nie powiodła się.","Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
