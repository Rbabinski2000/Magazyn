using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWindow.DBcontext;
using WPFWindow.DTO;
using WPFWindow.Models;

namespace WPFWindow.Services.ProduktCreators
{
    public class DatabaseProduktCreator : IProduktCreator
    {
        private readonly MagazynDBcontextFactory dbContextFactory;

        public DatabaseProduktCreator(MagazynDBcontextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        public async Task CreateProdukt(Produkt pro)
        {
            using(MagazynDBcontext context = dbContextFactory.CreateDbContext())
            {
                ProduktDTO produktDTO = ToProduktDTO(pro);

                context.ProduktDTOs.Add(produktDTO);
                await context.SaveChangesAsync();
            }
        }

        private ProduktDTO ToProduktDTO(Produkt pro)
        {
            return new ProduktDTO()
            {
                Name = pro.Name,
                Price = pro.Price,
                Amount = pro.Amount
            };
        }
    }
}
