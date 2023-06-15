using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Models;

namespace WPFWindow.Services.ProduktProvider
{
    public interface IProduktProvider
    {
        Task<IEnumerable<Produkt>> GetAllProdukt();
        
    }
}
