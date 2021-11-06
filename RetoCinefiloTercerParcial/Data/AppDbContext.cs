using Microsoft.EntityFrameworkCore;
using RetoCinefiloTercerParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoCinefiloTercerParcial.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cinefilo> Cinefilo { get; set; }
        public object Cinefilia { get; internal set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
