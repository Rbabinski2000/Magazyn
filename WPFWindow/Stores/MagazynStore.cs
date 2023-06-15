using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Models;

namespace WPFWindow.Stores
{
    public class MagazynStore
    {
        private readonly List<Produkt> listaProd;
        public IEnumerable<Produkt> ListaProd=> listaProd;
        private Magazyn magazyn;

        public MagazynStore(Magazyn mag) { 
         listaProd = new List<Produkt>();
            magazyn = mag;
        }
        public async Task Load()
        {
            IEnumerable<Produkt> Produkty = await magazyn.GetAllProdukt();

            listaProd.Clear();
            listaProd.AddRange(Produkty);
        
        }

    }
}
