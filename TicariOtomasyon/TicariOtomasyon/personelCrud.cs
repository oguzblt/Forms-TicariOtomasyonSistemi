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
    public partial class personelCrud : Form
    {
        public personelCrud()
        {
            InitializeComponent();
        }
        Context db = new Context();
        Personel personel = new Personel();
        int pId;
        bool control = false;
        void subelist()
        {
            foreach (var item in db.Subes)
            {
                cbsube.Items.Add(item.SubeAd);
            }
        }
        private void personelCrud_Load(object sender, EventArgs e)
        {
            subelist();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Subes)
            {
                string sAd = cbsube.Text;
                if (item.SubeAd==sAd)
                {
                    pId = item.Id;
                }
            }
            personel.Username = txtusername.Text;
            personel.Password = int.Parse(txtpassword.Text);
            personel.Unvan = cbunvan.Text;
            personel.PersonelAd = txtad.Text;
            personel.PersonelSoyad = txtsoyad.Text;
            personel.PersonelDogumTarihi = mtxttarih.Text;
            personel.PersonelTelefon = mtxttel.Text;
            personel.PersonelEposta = txtposta.Text;
            personel.SubeId = pId;
            db.Personels.Add(personel);
            db.SaveChanges();
            MessageBox.Show("Personel başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var personels = db.Personels.Find(id);
            DialogResult msj;
            msj = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                db.Personels.Remove(personels);
                db.SaveChanges();
            }
        }
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
                int id = int.Parse(txtid.Text);
                var personels = db.Personels.Find(id);
                txtid.Text = id.ToString();
                txtusername.Text = personels.Username;
                txtpassword.Text = personels.Password.ToString();
                txtad.Text = personels.PersonelAd;
                txtsoyad.Text = personels.PersonelSoyad;
                mtxttarih.Text = personels.PersonelDogumTarihi;
                mtxttel.Text = personels.PersonelTelefon;
                txtposta.Text = personels.PersonelEposta;
                cbunvan.Text = personels.Unvan;
                cbsube.Text = personels.Sube.SubeAd;
                btndüzenle.Text = "Kaydet";
            }
            else if (control == true)
            {
                control = false;
                int id = int.Parse(txtid.Text);
                var personel = db.Personels.Find(id);
                foreach (var item in db.Subes)
                {
                    string sAd = cbsube.Text;
                    if (item.SubeAd==sAd)
                    {
                        pId = item.Id;
                    }
                }
                personel.Username = txtusername.Text;
                personel.Password = int.Parse(txtpassword.Text);
                personel.Unvan = cbunvan.Text;
                personel.PersonelAd = txtad.Text;
                personel.PersonelSoyad = txtsoyad.Text;
                personel.PersonelDogumTarihi = mtxttarih.Text;
                personel.PersonelTelefon = mtxttel.Text;
                personel.PersonelEposta = txtposta.Text;
                personel.SubeId = pId;
                db.SaveChanges();
                MessageBox.Show("Personel başarılı bir şekilde güncellendi.", "", MessageBoxButtons.OK);
            }
        }
    }
}
