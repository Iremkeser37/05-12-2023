namespace isim_yazma
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
            this.lbIsim = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncel = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.btnHarf = new System.Windows.Forms.Button();
            this.btnMharf = new System.Windows.Forms.Button();
            this.btnAharf = new System.Windows.Forms.Button();
            this.btnTemizleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIsim
            // 
            this.lbIsim.FormattingEnabled = true;
            this.lbIsim.Location = new System.Drawing.Point(12, 7);
            this.lbIsim.Name = "lbIsim";
            this.lbIsim.Size = new System.Drawing.Size(212, 420);
            this.lbIsim.TabIndex = 0;
            this.lbIsim.SelectedIndexChanged += new System.EventHandler(this.lbIsim_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(242, 7);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 32);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(367, 14);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(120, 20);
            this.txtIsim.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(242, 45);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(110, 32);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.Location = new System.Drawing.Point(242, 83);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(110, 37);
            this.btnSira.TabIndex = 5;
            this.btnSira.Text = "kacıncı sırada";
            this.btnSira.UseVisualStyleBackColor = true;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(242, 126);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(110, 34);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "removeat silme";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncel
            // 
            this.btngüncel.Location = new System.Drawing.Point(242, 166);
            this.btngüncel.Name = "btngüncel";
            this.btngüncel.Size = new System.Drawing.Size(110, 39);
            this.btngüncel.TabIndex = 7;
            this.btngüncel.Text = "remove ile silme";
            this.btngüncel.UseVisualStyleBackColor = true;
            this.btngüncel.Click += new System.EventHandler(this.btngüncel_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(242, 211);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 33);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(242, 250);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(110, 36);
            this.btnGuncel.TabIndex = 9;
            this.btnGuncel.Text = "güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.Location = new System.Drawing.Point(242, 292);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(110, 34);
            this.btnArtan.TabIndex = 10;
            this.btnArtan.Text = "artan ";
            this.btnArtan.UseVisualStyleBackColor = true;
            this.btnArtan.Click += new System.EventHandler(this.btnArtan_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.Location = new System.Drawing.Point(242, 332);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(110, 33);
            this.btnAzalan.TabIndex = 11;
            this.btnAzalan.Text = "azalan";
            this.btnAzalan.UseVisualStyleBackColor = true;
            this.btnAzalan.Click += new System.EventHandler(this.btnAzalan_Click);
            // 
            // btnHarf
            // 
            this.btnHarf.Location = new System.Drawing.Point(242, 371);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(110, 30);
            this.btnHarf.TabIndex = 12;
            this.btnHarf.Text = "5 harfli ögrenci sayısı";
            this.btnHarf.UseVisualStyleBackColor = true;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btnMharf
            // 
            this.btnMharf.Location = new System.Drawing.Point(242, 407);
            this.btnMharf.Name = "btnMharf";
            this.btnMharf.Size = new System.Drawing.Size(110, 32);
            this.btnMharf.TabIndex = 13;
            this.btnMharf.Text = "m harfli isim ";
            this.btnMharf.UseVisualStyleBackColor = true;
            this.btnMharf.Click += new System.EventHandler(this.btnMharf_Click);
            // 
            // btnAharf
            // 
            this.btnAharf.Location = new System.Drawing.Point(242, 445);
            this.btnAharf.Name = "btnAharf";
            this.btnAharf.Size = new System.Drawing.Size(110, 32);
            this.btnAharf.TabIndex = 14;
            this.btnAharf.Text = "a harfli isim";
            this.btnAharf.UseVisualStyleBackColor = true;
            // 
            // btnTemizleme
            // 
            this.btnTemizleme.Location = new System.Drawing.Point(242, 485);
            this.btnTemizleme.Name = "btnTemizleme";
            this.btnTemizleme.Size = new System.Drawing.Size(110, 32);
            this.btnTemizleme.TabIndex = 15;
            this.btnTemizleme.Text = "temizleme";
            this.btnTemizleme.UseVisualStyleBackColor = true;
            this.btnTemizleme.Click += new System.EventHandler(this.btnTemizleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(499, 520);
            this.Controls.Add(this.btnTemizleme);
            this.Controls.Add(this.btnAharf);
            this.Controls.Add(this.btnMharf);
            this.Controls.Add(this.btnHarf);
            this.Controls.Add(this.btnAzalan);
            this.Controls.Add(this.btnArtan);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btngüncel);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncel;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.Button btnMharf;
        private System.Windows.Forms.Button btnAharf;
        private System.Windows.Forms.Button btnTemizleme;
    }
}

