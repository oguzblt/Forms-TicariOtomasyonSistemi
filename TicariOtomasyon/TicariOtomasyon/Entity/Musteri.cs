using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public Nullable<int> SehirId { get; set; }
        public Sehir Sehir { get; set; }
        public ICollection<Satis> Satis { get; set; }
    }
}
