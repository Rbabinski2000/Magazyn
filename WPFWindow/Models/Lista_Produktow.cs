using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPFWindow.Models
{
    public class Lista_Produktow
    {
        private List<Produkt> Lista;
        public Lista_Produktow()
        {
            Lista = new List<Produkt>();
        }
        public IEnumerable<Produkt> GetList()
        {
            return Lista;   
        }
        public void AutoAdd(Produkt produkt)
        {
            Lista.Add(produkt);
        }
        public void AddProdukt(string name,double price,int amount)
        {
            new Produkt(name,price,amount);
        }
        public void RemoveProdukt(Produkt produkt)
        {
            Lista.Remove(produkt);
        }
    }
}
