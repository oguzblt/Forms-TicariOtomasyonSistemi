using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunCode { get; set; }
        public string UrunAd { get; set; }
        public int UrunAdet { get; set; }
        public float UrunFiyat { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public ICollection<Satis> Satis { get; set; }
    }
}
