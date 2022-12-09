namespace TicariOtomasyon
{
    partial class subeCrud
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
            this.btnsil = new System.Windows.Forms.Button();
            this.btndüzenle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubead = new System.Windows.Forms.TextBox();
            this.txtsubeid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbsehir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(103, 175);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 42;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btndüzenle
            // 
            this.btndüzenle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndüzenle.Location = new System.Drawing.Point(197, 175);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(75, 23);
            this.btndüzenle.TabIndex = 41;
            this.btndüzenle.Text = "Güncelle";
            this.btndüzenle.UseVisualStyleBackColor = true;
            this.btndüzenle.Click += new System.EventHandler(this.btndüzenle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(12, 175);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 40;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 39);
            this.label4.TabIndex = 39;
            this.label4.Text = "* Eklemek için Şube Ad ve Şehir alanını doldurunuz.\r\n   Silmek için Id bilgisi gi" +
    "riniz.\r\n   Düzenleme için Id bilgisi giriniz. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Şube CRUD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Şube Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Id :";
            // 
            // txtsubead
            // 
            this.txtsubead.Location = new System.Drawing.Point(120, 84);
            this.txtsubead.Name = "txtsubead";
            this.txtsubead.Size = new System.Drawing.Size(100, 20);
            this.txtsubead.TabIndex = 35;
            // 
            // txtsubeid
            // 
            this.txtsubeid.Location = new System.Drawing.Point(120, 45);
            this.txtsubeid.Name = "txtsubeid";
            this.txtsubeid.Size = new System.Drawing.Size(100, 20);
            this.txtsubeid.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Şehir :";
            // 
            // cbsehir
            // 
            this.cbsehir.FormattingEnabled = true;
            this.cbsehir.Location = new System.Drawing.Point(120, 120);
            this.cbsehir.Name = "cbsehir";
            this.cbsehir.Size = new System.Drawing.Size(100, 21);
            this.cbsehir.TabIndex = 44;
            // 
            // subeCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbsehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btndüzenle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubead);
            this.Controls.Add(this.txtsubeid);
            this.Name = "subeCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subeCrud";
            this.Load += new System.EventHandler(this.subeCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubead;
        private System.Windows.Forms.TextBox txtsubeid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbsehir;
    }
}