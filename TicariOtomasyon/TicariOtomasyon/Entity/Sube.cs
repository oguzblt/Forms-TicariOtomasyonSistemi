using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.Entity
{
    public class Sube
    {
        public int Id { get; set; }
        public string SubeAd { get; set; }
        public Nullable<int> SehirId { get; set; }
        public Sehir Sehir { get; set; }
        public ICollection<Personel> Personels { get; set; }
        public ICollection<Satis> Satis { get; set; }
    }
}
