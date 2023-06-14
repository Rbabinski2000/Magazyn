using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindow.Models
{
    public class Uzytkownik
    {
        public string Name { get; set; }
        private List<Produkt> Koszyk { get; set; }
        private int LicznikZam = 0;
        private Dictionary<int,List<Produkt>> Zamowienia { get; set; }

        public Uzytkownik(string name)
        {
            Name = name;
            Koszyk = new List<Produkt>();
            Zamowienia = new Dictionary<int,List<Produkt>>();
        }


        //Obsługa koszyka
        public void SetAmount(Produkt pro,int amount)
        {
            foreach(Produkt x in Koszyk)
            {
                if(x.Name==pro.Name)
                {
                    x.SetAmount(amount); break;
                }
            }
        }
        public void RemoveFromKoszyk(Produkt produkt)
        {
            Koszyk.Remove(produkt);
        }
        public void AddToKoszyk(Produkt pro)
        {
            //Obsługa powtórzeń  TODO
            Produkt temp = pro;
            temp.SetAmount(1);
            Koszyk.Add(temp);
        }

        //obsługa zamówienia
        public void SubmitZamowienia(List<Produkt> koszyk)
        {
            Zamowienia.Add(LicznikZam, koszyk);
            LicznikZam++;
            //Odjęcie z listy produktów i obsługa przepełnienia ilosci

        }

    }
}
