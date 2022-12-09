using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.Entity;

namespace TicariOtomasyon
{
    public partial class subeCrud : Form
    {
        public subeCrud()
        {
            InitializeComponent();
        }
        Context db = new Context();
        Sube sube = new Sube();
        int sId;        
        private void subeCrud_Load(object sender, EventArgs e)
        {
            sehirlist();
        }
        void sehirlist()
        {
            foreach (var item in db.Sehirs)
            {
                cbsehir.Items.Add(item.SehirAd);
            }
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            string sAd = cbsehir.Text;
            foreach (var item in db.Sehirs)
            {
                if (item.SehirAd == sAd)
                {
                    sId = item.Id;
                }
            }
            sube.SubeAd = txtsubead.Text;
            sube.SehirId = sId;
            db.Subes.Add(sube);
            db.SaveChanges();
            MessageBox.Show("Şube başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtsubeid.Text);
            var subes = db.Subes.Find(id);
            DialogResult msj;
            msj = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                db.Subes.Remove(subes);
                db.SaveChanges();
            }
        }
        bool control = false;
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (control==false)
            {
                control = true;
                int subeid = int.Parse(txtsubeid.Text);
                var sube = db.Subes.Find(subeid);
                txtsubead.Text = sube.SubeAd;
                cbsehir.Text = sube.Sehir.SehirAd;
                btndüzenle.Text= "Kaydet";
            }
            else if (control==true)
            {
                control = false;
                string sAd = cbsehir.Text;
                foreach (var item in db.Sehirs)
                {
                    if (item.SehirAd == sAd)
                    {
                        sId = item.Id;
                    }
                }
                int id = int.Parse(txtsubeid.Text);
                var subes = db.Subes.Find(id);
                subes.SubeAd = txtsubead.Text;
                subes.SehirId = sId;
                db.SaveChanges();
                MessageBox.Show("Şube başarılı bir şekilde güncellendi.", "", MessageBoxButtons.OK);
            }
        }
    }
}
