using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Context : DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Bolge> Bolges { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<Sube> Subes { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public Context() : base("OtomasyonCon") { }
    }
}
