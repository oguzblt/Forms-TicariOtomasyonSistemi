using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}
