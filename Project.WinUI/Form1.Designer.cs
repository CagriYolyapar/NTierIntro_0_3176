namespace Project.WinUI
{
    partial class Form1
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
            this.LstResult = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnYokEt = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.BtnAktif = new System.Windows.Forms.Button();
            this.BtnGuncel = new System.Windows.Forms.Button();
            this.BtnPasif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstResult
            // 
            this.LstResult.FormattingEnabled = true;
            this.LstResult.ItemHeight = 22;
            this.LstResult.Location = new System.Drawing.Point(233, 86);
            this.LstResult.Margin = new System.Windows.Forms.Padding(4);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(1094, 400);
            this.LstResult.TabIndex = 0;
            this.LstResult.Click += new System.EventHandler(this.LstResult_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(31, 86);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(140, 39);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(31, 153);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(140, 39);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(31, 231);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(140, 39);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnYokEt
            // 
            this.BtnYokEt.Location = new System.Drawing.Point(31, 314);
            this.BtnYokEt.Name = "BtnYokEt";
            this.BtnYokEt.Size = new System.Drawing.Size(140, 40);
            this.BtnYokEt.TabIndex = 2;
            this.BtnYokEt.Text = "Yok Et";
            this.BtnYokEt.UseVisualStyleBackColor = true;
            this.BtnYokEt.Click += new System.EventHandler(this.BtnYokEt_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(13, 414);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(136, 28);
            this.TxtIsim.TabIndex = 3;
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(12, 469);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(136, 28);
            this.TxtAciklama.TabIndex = 3;
            // 
            // BtnAktif
            // 
            this.BtnAktif.Location = new System.Drawing.Point(416, 525);
            this.BtnAktif.Name = "BtnAktif";
            this.BtnAktif.Size = new System.Drawing.Size(176, 53);
            this.BtnAktif.TabIndex = 4;
            this.BtnAktif.Text = "Aktfileri Getir";
            this.BtnAktif.UseVisualStyleBackColor = true;
            this.BtnAktif.Click += new System.EventHandler(this.BtnPasif_Click);
            // 
            // BtnGuncel
            // 
            this.BtnGuncel.Location = new System.Drawing.Point(632, 525);
            this.BtnGuncel.Name = "BtnGuncel";
            this.BtnGuncel.Size = new System.Drawing.Size(193, 53);
            this.BtnGuncel.TabIndex = 4;
            this.BtnGuncel.Text = "Guncelleneleri Getir";
            this.BtnGuncel.UseVisualStyleBackColor = true;
            this.BtnGuncel.Click += new System.EventHandler(this.BtnGuncel_Click);
            // 
            // BtnPasif
            // 
            this.BtnPasif.Location = new System.Drawing.Point(851, 525);
            this.BtnPasif.Name = "BtnPasif";
            this.BtnPasif.Size = new System.Drawing.Size(176, 53);
            this.BtnPasif.TabIndex = 4;
            this.BtnPasif.Text = "Pasifleri Getir";
            this.BtnPasif.UseVisualStyleBackColor = true;
            this.BtnPasif.Click += new System.EventHandler(this.BtnPasif_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 638);
            this.Controls.Add(this.BtnPasif);
            this.Controls.Add(this.BtnGuncel);
            this.Controls.Add(this.BtnAktif);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.BtnYokEt);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LstResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstResult;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnYokEt;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Button BtnAktif;
        private System.Windows.Forms.Button BtnGuncel;
        private System.Windows.Forms.Button BtnPasif;
    }
}

