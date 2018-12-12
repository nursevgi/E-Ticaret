namespace ERP_Yazilim
{
    partial class Frmürün
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmürün));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstokadedi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAnaKtg = new System.Windows.Forms.ComboBox();
            this.cmbAltktg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgurunler = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnResimekle = new System.Windows.Forms.Button();
            this.txtresimkodu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgurunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Barkod:";
            // 
            // txturunadi
            // 
            this.txturunadi.BackColor = System.Drawing.Color.LavenderBlush;
            this.txturunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Location = new System.Drawing.Point(174, 290);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(323, 27);
            this.txturunadi.TabIndex = 27;
            this.txturunadi.TextChanged += new System.EventHandler(this.txturunadi_TextChanged);
            // 
            // txtbarkod
            // 
            this.txtbarkod.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkod.Location = new System.Drawing.Point(174, 257);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(323, 27);
            this.txtbarkod.TabIndex = 30;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // txtmarka
            // 
            this.txtmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Location = new System.Drawing.Point(174, 324);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(323, 27);
            this.txtmarka.TabIndex = 30;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaciklama.Location = new System.Drawing.Point(174, 357);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(323, 82);
            this.txtaciklama.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Açıklama:";
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatisfiyati.Location = new System.Drawing.Point(174, 530);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(323, 27);
            this.txtsatisfiyati.TabIndex = 30;
            // 
            // txtkdv
            // 
            this.txtkdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkdv.Location = new System.Drawing.Point(174, 563);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(323, 27);
            this.txtkdv.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Satış Fiyatı (TL):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(109, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "KDV:";
            // 
            // txtstokadedi
            // 
            this.txtstokadedi.Enabled = false;
            this.txtstokadedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstokadedi.Location = new System.Drawing.Point(174, 596);
            this.txtstokadedi.Name = "txtstokadedi";
            this.txtstokadedi.Size = new System.Drawing.Size(323, 27);
            this.txtstokadedi.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Stok Adedi:";
            // 
            // cmbAnaKtg
            // 
            this.cmbAnaKtg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnaKtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAnaKtg.FormattingEnabled = true;
            this.cmbAnaKtg.Location = new System.Drawing.Point(174, 449);
            this.cmbAnaKtg.Name = "cmbAnaKtg";
            this.cmbAnaKtg.Size = new System.Drawing.Size(323, 28);
            this.cmbAnaKtg.TabIndex = 31;
            this.cmbAnaKtg.SelectedIndexChanged += new System.EventHandler(this.cmbAnaKtg_SelectedIndexChanged);
            // 
            // cmbAltktg
            // 
            this.cmbAltktg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAltktg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAltktg.FormattingEnabled = true;
            this.cmbAltktg.Location = new System.Drawing.Point(174, 487);
            this.cmbAltktg.Name = "cmbAltktg";
            this.cmbAltktg.Size = new System.Drawing.Size(323, 28);
            this.cmbAltktg.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ana Kategori:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(57, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Alt Kategori:";
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(174, 26);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(242, 210);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 32;
            this.pbResim.TabStop = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsil.Location = new System.Drawing.Point(397, 654);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(79, 62);
            this.btnsil.TabIndex = 35;
            this.btnsil.Text = "SİL";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkaydet.Location = new System.Drawing.Point(295, 654);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 33;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnyeni
            // 
            this.btnyeni.BackColor = System.Drawing.Color.White;
            this.btnyeni.Image = ((System.Drawing.Image)(resources.GetObject("btnyeni.Image")));
            this.btnyeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnyeni.Location = new System.Drawing.Point(191, 654);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 34;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(55, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ürün Resmi:";
            this.label10.Visible = false;
            // 
            // dgurunler
            // 
            this.dgurunler.AllowUserToAddRows = false;
            this.dgurunler.AllowUserToDeleteRows = false;
            this.dgurunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgurunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgurunler.Location = new System.Drawing.Point(557, 78);
            this.dgurunler.Name = "dgurunler";
            this.dgurunler.ReadOnly = true;
            this.dgurunler.RowTemplate.Height = 24;
            this.dgurunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgurunler.Size = new System.Drawing.Size(760, 638);
            this.dgurunler.TabIndex = 36;
            this.dgurunler.Click += new System.EventHandler(this.dgurunler_Click);
            this.dgurunler.DoubleClick += new System.EventHandler(this.dgurunler_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(553, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Kayıtlı Ürünler:";
            // 
            // btnResimekle
            // 
            this.btnResimekle.BackColor = System.Drawing.Color.White;
            this.btnResimekle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimekle.Image")));
            this.btnResimekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResimekle.Location = new System.Drawing.Point(422, 205);
            this.btnResimekle.Name = "btnResimekle";
            this.btnResimekle.Size = new System.Drawing.Size(45, 33);
            this.btnResimekle.TabIndex = 34;
            this.btnResimekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResimekle.UseVisualStyleBackColor = false;
            this.btnResimekle.Click += new System.EventHandler(this.btnResimekle_Click);
            // 
            // txtresimkodu
            // 
            this.txtresimkodu.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtresimkodu.Enabled = false;
            this.txtresimkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresimkodu.Location = new System.Drawing.Point(4, 19);
            this.txtresimkodu.Name = "txtresimkodu";
            this.txtresimkodu.Size = new System.Drawing.Size(45, 27);
            this.txtresimkodu.TabIndex = 30;
            this.txtresimkodu.TabStop = false;
            this.txtresimkodu.Visible = false;
            // 
            // Frmürün
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1338, 753);
            this.Controls.Add(this.dgurunler);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnResimekle);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cmbAltktg);
            this.Controls.Add(this.cmbAnaKtg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstokadedi);
            this.Controls.Add(this.txtkdv);
            this.Controls.Add(this.txtsatisfiyati);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txtresimkodu);
            this.Controls.Add(this.txtbarkod);
            this.Name = "Frmürün";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Frmürün_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgurunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsatisfiyati;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstokadedi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAnaKtg;
        private System.Windows.Forms.ComboBox cmbAltktg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgurunler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnResimekle;
        private System.Windows.Forms.TextBox txtresimkodu;
    }
}