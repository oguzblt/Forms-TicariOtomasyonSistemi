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
    public partial class categoryCrud : Form
    {
        public categoryCrud()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void btnekle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAd = txtkategoriad.Text;
            db.Kategoris.Add(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde eklendi.", "", MessageBoxButtons.OK);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var kategori = db.Kategoris.Find(id);
            DialogResult msj;
            msj = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                db.Kategoris.Remove(kategori);
                db.SaveChanges();
            }
        }
        bool control = false;
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
                int id = int.Parse(txtkategoriid.Text);
                var kategori = db.Kategoris.Find(id);
                txtkategoriad.Text = kategori.KategoriAd;
                btndüzenle.Text = "Kaydet";
            }
            else if (control ==true)
            {
                control = false;
                int id = int.Parse(txtkategoriid.Text);
                var kategori = db.Kategoris.Find(id);
                kategori.KategoriAd = txtkategoriad.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori başarılı bir şekilde güncellendi.", "", MessageBoxButtons.OK);
            }
        }
    }
}
