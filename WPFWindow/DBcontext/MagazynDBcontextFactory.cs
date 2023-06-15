using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindow.DBcontext
{
    public class MagazynDBcontextFactory
    {
        private string connection_String;

        public MagazynDBcontextFactory(string connection_String)
        {
            this.connection_String = connection_String;
        }

        public MagazynDBcontext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(connection_String).Options;

            return new MagazynDBcontext(options);
        }
    }
}
