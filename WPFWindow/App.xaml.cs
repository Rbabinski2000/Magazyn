using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFWindow.Models;

namespace WPFWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Magazyn.ListaProd.AddProdukt("ogórek", 4.8, 200);
            Magazyn.ListaProd.AddProdukt("marchewka", 2, 500);
            Magazyn.ListaProd.AddProdukt("sałata", 0.5, 100);
            Magazyn.ListaProd.AddProdukt("cytryna", 3.1, 155);
            var user = new Uzytkownik("Klient");
            Console.WriteLine(Magazyn.ListaProd);

            base.OnStartup(e);
        }
    }
}
