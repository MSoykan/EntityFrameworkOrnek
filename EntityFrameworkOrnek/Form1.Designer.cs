namespace EntityFrameworkOrnek {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFotograf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSinavNotuGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnProcedure = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(13, 204);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(105, 41);
            this.BtnOgrenciListele.TabIndex = 1;
            this.BtnOgrenciListele.Text = "ÖğrenciListele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(13, 251);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 41);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(13, 298);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 41);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(12, 345);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(105, 41);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(12, 392);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(105, 41);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFotograf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrenciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(141, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtFotograf
            // 
            this.txtFotograf.Location = new System.Drawing.Point(94, 177);
            this.txtFotograf.Name = "txtFotograf";
            this.txtFotograf.Size = new System.Drawing.Size(172, 22);
            this.txtFotograf.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "FOTOĞRAF";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 120);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 22);
            this.txtSoyad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYAD";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 73);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 22);
            this.txtAd.TabIndex = 17;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "AD:";
            // 
            // TxtOgrenciID
            // 
            this.TxtOgrenciID.Location = new System.Drawing.Point(94, 26);
            this.TxtOgrenciID.Name = "TxtOgrenciID";
            this.TxtOgrenciID.Size = new System.Drawing.Size(172, 22);
            this.TxtOgrenciID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDersAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(141, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(94, 73);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(172, 22);
            this.txtDersAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "AD:";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(94, 26);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(172, 22);
            this.txtDersID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSinavNotuGuncelle);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.txtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtOrtalama);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSınav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSınav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSınav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(450, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 359);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btnSinavNotuGuncelle
            // 
            this.btnSinavNotuGuncelle.Location = new System.Drawing.Point(27, 299);
            this.btnSinavNotuGuncelle.Name = "btnSinavNotuGuncelle";
            this.btnSinavNotuGuncelle.Size = new System.Drawing.Size(239, 24);
            this.btnSinavNotuGuncelle.TabIndex = 27;
            this.btnSinavNotuGuncelle.Text = "Sınav Notu Güncelle";
            this.btnSinavNotuGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(27, 269);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(239, 24);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(94, 227);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(172, 22);
            this.txtDurum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "DURUM :";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(94, 177);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(172, 22);
            this.txtOrtalama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "ORTALAMA:";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(94, 120);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(172, 22);
            this.txtSınav3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "SINAV 3:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(94, 73);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(172, 22);
            this.txtSınav2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "SINAV 2:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(94, 26);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(172, 22);
            this.txtSınav1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "SINAV 1:";
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Location = new System.Drawing.Point(12, 439);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(105, 41);
            this.BtnDersListesi.TabIndex = 24;
            this.BtnDersListesi.Text = "DersListesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(12, 486);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(105, 41);
            this.BtnNotListesi.TabIndex = 25;
            this.BtnNotListesi.Text = "NotListesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnProcedure
            // 
            this.BtnProcedure.Location = new System.Drawing.Point(13, 533);
            this.BtnProcedure.Name = "BtnProcedure";
            this.BtnProcedure.Size = new System.Drawing.Size(105, 41);
            this.BtnProcedure.TabIndex = 26;
            this.BtnProcedure.Text = "Prosedür";
            this.BtnProcedure.UseVisualStyleBackColor = true;
            this.BtnProcedure.Click += new System.EventHandler(this.BtnProcedure_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(819, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 20);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala(A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(782, 486);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(158, 41);
            this.btnLinqEntity.TabIndex = 28;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(819, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 20);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala(Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(819, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 20);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(819, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(148, 20);
            this.radioButton4.TabIndex = 31;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Id\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 674);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProcedure);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.BtnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFotograf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSinavNotuGuncelle;
        private System.Windows.Forms.Button BtnProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

