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
    public partial class personelForm : Form
    {
        public personelForm()
        {
            InitializeComponent();
        }
        public string personelbilgi;
        Context db = new Context();
        void urunListe()
        {
            foreach (var item in db.Uruns)
            {
                cbUrun.Items.Add(item.UrunAd);
            }
        }
        void musteriListe()
        {
            cbMusteri.Items.Clear();
            foreach (var item in db.Musteris)
            {
                cbMusteri.Items.Add(item.Ad+" "+item.Soyad);
            }
        }
        void personelListe()
        {
            foreach (var item in db.Personels)
            {
                cbPersonel.Items.Add(item.PersonelAd+" "+item.PersonelSoyad);
            }
        }
        private void personelForm_Load(object sender, EventArgs e)
        {
            urunListe();
            musteriListe();
            personelListe();
            dataGrid.Visible = false;
            btnguncelle.Visible = false;
            gbsatisform.Visible = true;
            foreach (var item in db.Personels)
            {
                if (item.Username == personelbilgi)
                {
                    lbladminbilgi.Text = item.PersonelAd+" "+item.PersonelSoyad;
                }
            }
        }
        private void btnsatisliste_Click(object sender, EventArgs e)
        {
            gbsatisform.Visible = false;
            dataGrid.Visible = true;
            btnguncelle.Visible = false;
            var satislist = from s in db.Satis
                            select new
                            {
                                s.Id,
                                s.SatisTarih,
                                s.Uruns.Kategori.KategoriAd,
                                s.Uruns.UrunCode,
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
        private void btnmusteriliste_Click(object sender, EventArgs e)
        {
            gbsatisform.Visible = false;
            dataGrid.Visible=true;
            btnguncelle.Visible = true;
            var musterilist = from m in db.Musteris
                              select new
                              {
                                  m.Id,
                                  m.Ad,
                                  m.Soyad,
                                  m.DogumTarihi,
                                  m.Telefon,
                                  m.Eposta,
                                  m.Sehir.SehirAd,
                                  m.Sehir.Bolge.BolgeAd,
                              };
            dataGrid.DataSource = musterilist.ToList();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void btnsatisekle_Click(object sender, EventArgs e)
        {
            dataGrid.Visible=false;
            gbsatisform.Visible=true;
            btnguncelle.Visible = false;
        }
        int uId;
        int mId;
        int pId;
        private void btnsatisgir_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Uruns)
            {
                string uAd = cbUrun.Text;
                if (item.UrunAd == uAd)
                {
                    uId = item.Id;
                }
            }
            foreach (var item in db.Musteris)
            {
                string mAd = cbMusteri.Text;
                string madsoyad = item.Ad+" "+item.Soyad;
                if (mAd == madsoyad)
                {
                    mId = item.Id;
                }
            }
            foreach (var item in db.Personels)
            {
                string pAd = cbPersonel.Text;
                string padsoyad = item.PersonelAd+" "+item.PersonelSoyad;
                if (pAd == padsoyad)
                {
                    pId = item.Id;
                }
            }
            Satis satis = new Satis();
            satis.SatisTarih = DateTime.Now;
            satis.UrunId = uId;
            satis.MusteriId = mId;
            satis.PersonelId = pId;
            db.Satis.Add(satis);
            db.SaveChanges();
            MessageBox.Show("SAtış işlemi başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            musteriCrud musteri = new musteriCrud();
            musteri.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            musteriListe();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            gbsatisform.Visible = false;
            dataGrid.Visible=true;
            btnguncelle.Visible=false;
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

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            musteriCrud musteri = new musteriCrud();
            musteri.ShowDialog();
        }
    }
}
