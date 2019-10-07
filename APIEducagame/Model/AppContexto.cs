using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEducagame.Model
{
    public class AppContexto : DbContext
    {

        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        {

        }

        public DbSet<Ponto> Ponto { get; set; }

    }
}
