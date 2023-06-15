using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindow.Models
{
    public class Produkt:IEquatable<Produkt>
    {
        public string Name { get; }
        public double Price { get; private set; }
        public int Amount { get; private set; }
        public Produkt(string name,double price,int amount) { 
            
            Name = name;
            Price = price;
            Amount = amount;

        }
        
        public void SetPrice(double price)
        {
            Price= price;
        }
        public void SetAmount(int amonut)
        {
            Amount = amonut;
        }
        public override string ToString()
        {
            return $"{Name}-Cena:{Price}-Ilość:{Amount}";
        }

        public bool Equals(Produkt? other)
        {
            return this.Name == other.Name;
        }
        
    }
}
