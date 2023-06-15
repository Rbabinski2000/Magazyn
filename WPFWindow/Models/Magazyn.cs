using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindow.Models
{
    public class Magazyn
    {
        public  Lista_Produktow ListaProd;

        public  string Name;
        
        public Magazyn(string name, Lista_Produktow Lista)
        {
            Name = name;
            ListaProd = Lista;
        }

        public async Task<IEnumerable<Produkt>> GetAllProdukt()
        {
            return await ListaProd.GetAllProdukt();
        }
        public async Task AddProdukt(Produkt pro)
        {
           await ListaProd.AddProdukt(pro);
        }
        
    }
}
