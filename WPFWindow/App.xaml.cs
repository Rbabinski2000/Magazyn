using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFWindow.Models;
using WPFWindow.Services;
using WPFWindow.Stores;
using WPFWindow.VieModels;

namespace WPFWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore store;

        public App()
        {
            store=new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            store.CurrentViewModel=CreateLista_ProdViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(store)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
        private MakeProduktViewModel CreateMakeProduktViewModel()
        {
            return new MakeProduktViewModel(new NavigationService(store, CreateLista_ProdViewModel));
        }
        private Lista_ProdViewModel CreateLista_ProdViewModel()
        {
            return new Lista_ProdViewModel(new NavigationService(store, CreateMakeProduktViewModel));
        }
    }
}
