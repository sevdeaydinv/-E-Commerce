using Microsoft.EntityFrameworkCore;
using KodlamaDunyasi.Models;
using System.Collections.Generic;

namespace KodlamaDunyasi.Data
{
    public class KodlamaDunyasiContext : DbContext
    {
        public KodlamaDunyasiContext(DbContextOptions<KodlamaDunyasiContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Urunler { get; set; }
    }
}