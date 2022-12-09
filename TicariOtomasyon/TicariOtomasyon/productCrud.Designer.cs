namespace TicariOtomasyon
{
    partial class productCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndüzenle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cburunkatsecme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.Label();
            this.txturunid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btndüzenle
            // 
            this.btndüzenle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndüzenle.Location = new System.Drawing.Point(197, 187);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(75, 23);
            this.btndüzenle.TabIndex = 19;
            this.btndüzenle.Text = "Güncelle";
            this.btndüzenle.UseVisualStyleBackColor = true;
            this.btndüzenle.Click += new System.EventHandler(this.btndüzenle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(12, 187);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "* Eklemek için tüm alanı doldurunuz.\r\n   Silmek için Kod bilgisi giriniz.\r\n   Düz" +
    "enleme için Kod bilgisi giriniz. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ürün CRUD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(42, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kategori Ad :";
            // 
            // cburunkatsecme
            // 
            this.cburunkatsecme.FormattingEnabled = true;
            this.cburunkatsecme.Location = new System.Drawing.Point(135, 162);
            this.cburunkatsecme.Name = "cburunkatsecme";
            this.cburunkatsecme.Size = new System.Drawing.Size(100, 21);
            this.cburunkatsecme.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ürün Fiyat :";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(135, 136);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ürün Adet :";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(135, 80);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(100, 20);
            this.txtadet.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(64, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ürün Ad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ürün Kod :";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(135, 109);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 20);
            this.txturunad.TabIndex = 21;
            // 
            // txturunkod
            // 
            this.txturunkod.Location = new System.Drawing.Point(135, 54);
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(100, 20);
            this.txturunkod.TabIndex = 20;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(103, 187);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 30;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(57, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 18);
            this.txtid.TabIndex = 32;
            this.txtid.Text = "Ürün Id :";
            // 
            // txturunid
            // 
            this.txturunid.Location = new System.Drawing.Point(135, 31);
            this.txturunid.Name = "txturunid";
            this.txturunid.Size = new System.Drawing.Size(100, 20);
            this.txturunid.TabIndex = 31;
            // 
            // productCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txturunid);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cburunkatsecme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.txturunkod);
            this.Controls.Add(this.btndüzenle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "productCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productCrud";
            this.Load += new System.EventHandler(this.productCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cburunkatsecme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.TextBox txturunid;
    }
}