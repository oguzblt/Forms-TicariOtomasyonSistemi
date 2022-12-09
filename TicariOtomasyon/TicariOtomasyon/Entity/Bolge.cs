using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Bolge
    {
        public int Id { get; set; }
        public string BolgeAd { get; set; }
        public ICollection<Sehir> Sehirs { get; set; }
    }
}
