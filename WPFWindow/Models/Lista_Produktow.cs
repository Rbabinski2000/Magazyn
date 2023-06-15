using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Services.ProduktCreators;
using WPFWindow.Services.ProduktProvider;

namespace WPFWindow.Models
{
    public class Lista_Produktow
    {
        //public List<Produkt> Lista;
        private readonly IProduktProvider produktProvider;
        private readonly IProduktCreator produktCreator;


        
        public Lista_Produktow(IProduktProvider listaProvider, IProduktCreator listaCreator)
        {
            produktProvider = listaProvider;
            produktCreator = listaCreator;
        }

        public async Task<IEnumerable<Produkt>> GetAllProdukt()
        {
            return await produktProvider.GetAllProdukt();  
        }
        
        public async Task AddProdukt(Produkt pro)
        {

           await produktCreator.CreateProdukt(pro);
        }
        
    }
}
