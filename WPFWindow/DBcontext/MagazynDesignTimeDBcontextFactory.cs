using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WPFWindow.DBcontext
{
    public class MagazynDesignTimeDBcontextFactory : IDesignTimeDbContextFactory<MagazynDBcontext>
    {
        public MagazynDBcontext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=magazyn.db").Options;

            return new MagazynDBcontext(options);
        }
    }
}
