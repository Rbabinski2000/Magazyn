using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Models;

namespace WPFWindow.VieModels
{
    public class ProduktViewModel:ViewModelBase
    {
        private readonly Produkt Produkt;
        public string Name => Produkt.Name;
        public double Price => Produkt.Price;
        public int Amount => Produkt.Amount;

        public ProduktViewModel(Produkt produkt)
        {
            Produkt = produkt;
            
        }
    }
}
