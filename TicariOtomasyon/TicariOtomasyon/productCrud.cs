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
    public partial class productCrud : Form
    {
        public productCrud()
        {
            InitializeComponent();
        }
        Context db =new Context();
        Urun urun = new Urun();
        int yId;        
        private void productCrud_Load(object sender, EventArgs e)
        {
            kategorilist();
        }
        void kategorilist()
        {
            foreach (var item in db.Kategoris)
            {
                cburunkatsecme.Items.Add(item.KategoriAd);
            }
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            string kAd = cburunkatsecme.Text;
            foreach (var item in db.Kategoris)
            {
                if (item.KategoriAd == kAd)
                {
                    yId = item.Id;
                }
            }
            urun.UrunCode = txturunkod.Text;
            urun.UrunAd = txturunad.Text;
            urun.UrunAdet = int.Parse(txtadet.Text);
            urun.UrunFiyat = float.Parse(txtfiyat.Text);
            urun.KategoriId = yId;
            db.Uruns.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }
        bool control = false;
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
                int id = int.Parse(txturunid.Text);
                var uruns = db.Uruns.Find(id);
                txturunkod.Text = uruns.UrunCode;
                txturunad.Text = uruns.UrunAd;
                txtadet.Text = uruns.UrunAdet.ToString();
                txtfiyat.Text = uruns.UrunFiyat.ToString();
                cburunkatsecme.Text = uruns.Kategori.KategoriAd;
                btndüzenle.Text = "Kaydet";
            }
            else if (control == true)
            {
                string kAd = cburunkatsecme.Text;
                foreach (var item in db.Kategoris)
                {
                    if (item.KategoriAd == kAd)
                    {
                        yId = item.Id;
                    }
                }
                int id = int.Parse(txturunid.Text);
                var uruns = db.Uruns.Find(id);
                control = false;
                uruns.UrunCode = txturunkod.Text;
                uruns.UrunAd = txturunad.Text;
                uruns.UrunAdet = int.Parse(txtadet.Text);
                uruns.UrunFiyat = float.Parse(txtfiyat.Text);
                uruns.KategoriId = yId;
                db.SaveChanges();
                MessageBox.Show("Ürün başarılı bir şekilde güncellendi.", "", MessageBoxButtons.OK);
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txturunid.Text);
            var uruns = db.Uruns.Find(id);
            DialogResult msj;
            msj = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                db.Uruns.Remove(uruns);
                db.SaveChanges();
            }
        }
    }
}
