using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.Entity;

namespace TicariOtomasyon
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        Context db = new Context();
        public string adminbilgi;
        public int btn;
        private void adminForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Personels)
            {
                if (item.Username == adminbilgi)
                {
                    lbladminbilgi.Text = item.PersonelAd+" "+item.PersonelSoyad;
                }
            }
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            btn = 1;
            var kategorilist = from k in db.Kategoris
                               select new
                               {
                                   k.Id,
                                   k.KategoriAd
                               };
            dataGrid.DataSource=kategorilist.ToList();
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            btn = 2;
            var urunlist = from u in db.Uruns
                           select new
                           {
                               u.Id,
                               u.UrunCode,
                               u.UrunAd,
                               u.Kategori.KategoriAd,
                               u.UrunAdet,
                               u.UrunFiyat,
                           };
            dataGrid.DataSource=urunlist.ToList();
        }
        private void btnpersonel_Click(object sender, EventArgs e)
        {
            btn=3;
            var personellist = from p in db.Personels
                               select new
                               {
                                   p.Id,
                                   p.PersonelAd,
                                   p.PersonelSoyad,
                                   p.Unvan,
                                   p.PersonelDogumTarihi,
                                   p.PersonelTelefon,
                                   p.PersonelEposta,
                                   p.Sube.SubeAd,
                                   p.Sube.Sehir.SehirAd
                               };
            dataGrid.DataSource = personellist.ToList();
        }
        private void btnsube_Click(object sender, EventArgs e)
        {
            btn=4;
            var subelist = from s in db.Subes
                           select new
                           {
                               s.Id,
                               s.SubeAd,
                               s.Sehir.SehirAd,
                               s.Sehir.Bolge.BolgeAd
                           };
            dataGrid.DataSource = subelist.ToList();
        }
        private void btncrud_Click(object sender, EventArgs e)
        {
            switch (btn)
            {
                case 1:
                    categoryCrud category = new categoryCrud();
                    category.ShowDialog();
                    break;
                case 2:
                    productCrud product = new productCrud();
                    product.ShowDialog();
                    break;
                case 3:
                    personelCrud personel = new personelCrud();
                    personel.ShowDialog();
                    break;
                case 4:
                    subeCrud sube = new subeCrud();
                    sube.ShowDialog();
                    break;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            var satislist = from s in db.Satis
                            select new
                            {
                                s.Id,
                                s.SatisTarih,
                                s.Uruns.Kategori.KategoriAd,
                                s.Uruns.UrunAd,
                                s.Uruns.UrunFiyat,
                                s.Musteris.Ad,
                                s.Musteris.Soyad,
                                s.Musteris.Sehir.SehirAd,
                                s.Personels.PersonelAd,
                                s.Personels.PersonelSoyad,
                                s.Personels.Sube.SubeAd,

                            };
            dataGrid.DataSource = satislist.ToList();
        }
    }
}
