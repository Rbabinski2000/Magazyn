using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.DBcontext;
using WPFWindow.DTO;
using WPFWindow.Models;

namespace WPFWindow.Services.ProduktProvider
{
    public class DatabaseProduktProvider : IProduktProvider
    {
        private readonly MagazynDBcontextFactory DbContextFactory;

        public DatabaseProduktProvider(MagazynDBcontextFactory dbContextFactory)
        {
            DbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Produkt>> GetAllProdukt()
        {
            using(MagazynDBcontext context = DbContextFactory.CreateDbContext())
            {
               IEnumerable<ProduktDTO> produktDTO= await context.ProduktDTOs.ToListAsync();
                return produktDTO.Select(p => new Produkt(p.Name, p.Price, p.Amount));
            }
        }
    }
}
