using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFWindow.DBcontext;
using WPFWindow.Models;
using WPFWindow.Services;
using WPFWindow.Services.ProduktCreators;
using WPFWindow.Services.ProduktProvider;
using WPFWindow.Stores;
using WPFWindow.VieModels;

namespace WPFWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Magazyn magazyn;
        private readonly NavigationStore store;
        private const string CONNECTION_STRING = "Data Source=magazyn.db";
        MagazynDBcontextFactory magazynDBcontextFactory;
        public App()
        {
            magazynDBcontextFactory = new MagazynDBcontextFactory(CONNECTION_STRING);
            IProduktProvider produktProvider = new DatabaseProduktProvider(magazynDBcontextFactory);
            IProduktCreator produktCreator = new DatabaseProduktCreator(magazynDBcontextFactory);

            magazyn= new Magazyn("Stokrotka",new Lista_Produktow(produktProvider, produktCreator));
            store=new NavigationStore();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            
            using (MagazynDBcontext dbContext =magazynDBcontextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            

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
            return new MakeProduktViewModel(magazyn,new NavigationService(store, CreateLista_ProdViewModel));
        }
        private Lista_ProdViewModel CreateLista_ProdViewModel()
        {
            return Lista_ProdViewModel.LoadViewModel(magazyn,new NavigationService(store, CreateMakeProduktViewModel));
        }
    }
}
