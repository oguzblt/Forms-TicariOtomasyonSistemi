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
    public partial class musteriCrud : Form
    {
        public musteriCrud()
        {
            InitializeComponent();
        }
        Context db = new Context();
        Musteri musteri = new Musteri();
        personelForm personelForm = new personelForm();
        int mId;
        bool control = false;
        private void btnekle_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Sehirs)
            {
                string sAd = cbsehirler.Text;
                if (item.SehirAd == sAd)
                {
                    mId = item.Id;
                }
            }
            musteri.Ad = txtad.Text;
            musteri.Soyad = txtsoyad.Text;
            musteri.DogumTarihi = mtxttarih.Text;
            musteri.Eposta = txtposta.Text;
            musteri.Telefon = mtxttel.Text;
            musteri.SehirId = mId;
            db.Musteris.Add(musteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }
        private void musteriCrud_Load(object sender, EventArgs e)
        {

            foreach (var item in db.Sehirs)
            {
                cbsehirler.Items.Add(item.SehirAd);
            }
        }
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
                int id = int.Parse(txtid.Text);
                var musteris = db.Musteris.Find(id);
                txtad.Text = musteris.Ad;
                txtsoyad.Text = musteris.Soyad;
                txtposta.Text = musteris.Eposta;
                mtxttarih.Text = musteris.DogumTarihi;
                mtxttel.Text = musteris.Telefon;
                cbsehirler.Text = musteris.Sehir.SehirAd;
            }
            else if (control == true)
            {
                control = false;
                int id = int.Parse(txtid.Text);
                var musteris = db.Musteris.Find(id);
                foreach (var item in db.Sehirs)
                {
                    string sAd = cbsehirler.Text;
                    if (item.SehirAd == sAd)
                    {
                        mId = item.Id;
                    }
                }
                musteris.Ad = txtad.Text;
                musteris.Soyad = txtsoyad.Text;
                musteris.DogumTarihi = mtxttarih.Text;
                musteris.Eposta = txtposta.Text;
                musteris.Telefon = mtxttel.Text;
                musteris.SehirId = mId;
                db.SaveChanges();
                MessageBox.Show("Müşteri bilgileri başarılı bir şekilde güncellendi.", "", MessageBoxButtons.OK);

            }

        }
    }
}
