using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Satis
    {
        public int Id { get; set; }
        public DateTime SatisTarih { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }
        public int PersonelId { get; set; }
        public Musteri Musteris { get; set; }
        public Urun Uruns { get; set; }
        public Personel Personels { get; set; }

    }
}
