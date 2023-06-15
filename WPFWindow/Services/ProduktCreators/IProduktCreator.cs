using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.Models;

namespace WPFWindow.Services.ProduktCreators
{
    public interface IProduktCreator
    {
        Task CreateProdukt(Produkt pro);
    }
}
