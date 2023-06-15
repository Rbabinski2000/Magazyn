using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPFWindow.DTO;
using WPFWindow.Models;

namespace WPFWindow.DBcontext
{
    public class MagazynDBcontext:DbContext
    {
        public MagazynDBcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProduktDTO> ProduktDTOs { get; set; }
    }
}
