using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Sehir
    {
        public int Id { get; set; }
        public string SehirAd { get; set; }
        public Nullable<int> BolgeId { get; set; }
        public Bolge Bolge { get; set; }
        public ICollection<Sube> Subes { get; set; }
        public ICollection<Musteri> Musteris { get; set; }
    }
}
