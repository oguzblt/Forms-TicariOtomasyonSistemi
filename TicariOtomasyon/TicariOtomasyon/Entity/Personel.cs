using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string Unvan { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelDogumTarihi { get; set; }
        public string PersonelTelefon { get; set; }
        public string PersonelEposta { get; set; }
        public Nullable<int> SubeId { get; set; }
        public Sube Sube { get; set; }
        public ICollection<Satis> Satis { get; set; }
    }
}
