using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TicariOtomasyon.Entity;

namespace TicariOtomasyon
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordFrom ch = new changePasswordFrom();
            this.Hide();
            ch.ShowDialog();
            this.Close();
        }
        private void cbsifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsifregoster.Checked) { txtpassword.PasswordChar = '\0'; }
            else { txtpassword.PasswordChar = '*'; }
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
        bool logincontrol = false;
        private void btngiris_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Personels)
            {
                if (item.Username == txtusername.Text && item.Unvan == "admin")
                {
                    logincontrol = true;
                    adminForm admin = new adminForm();
                    admin.adminbilgi = item.Username;
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();
                }
                else if (txtusername.Text == item.Username && item.Unvan == "personel")
                {
                    logincontrol = true;
                    personelForm personel = new personelForm();
                    personel.personelbilgi = item.Username;
                    this.Hide();
                    personel.ShowDialog();
                    this.Close();
                }
            }
            if (logincontrol == false)
            {
                MessageBox.Show("Hatalı Username yada Password Girdiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Program Kapatlsın Mı ?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
