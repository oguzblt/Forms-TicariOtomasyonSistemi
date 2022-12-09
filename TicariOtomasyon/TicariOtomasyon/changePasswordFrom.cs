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
    public partial class changePasswordFrom : Form
    {
        public changePasswordFrom()
        {
            InitializeComponent();
        }
        Context db = new Context();
        loginForm loginForm = new loginForm();
        private void txtyenisifre_TextChanged(object sender, EventArgs e)
        {
            txtyenisifre.PasswordChar ='*';
        }
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            txtsifre.PasswordChar ='*';
        }
        private void cbsifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsifregoster.Checked)
            {
                txtsifre.PasswordChar = '\0';
                txtyenisifre.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*';
                txtyenisifre.PasswordChar = '*';
            }
        }
        bool control = false;
        private void btnsifreyenile_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Personels)
            {
                if (item.Username == txtusername.Text && item.Password == Convert.ToInt32(txtsifre.Text))
                {
                    control = true;
                    item.Password = int.Parse(txtyenisifre.Text);
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Şifre Başaralı Bir Şekilde Değiştirildi.", "Şifre Değiştirme Ekranı", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
                        loginForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            db.SaveChanges();
            if (control == false)
            {
                MessageBox.Show("Hatalı Password yada Username. Tekrar Deneyin.", "Hatalı Şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            control = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
