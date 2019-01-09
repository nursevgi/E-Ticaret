namespace ERP_Yazilim
{
    partial class Frmsatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsatis));
            this.txtsatiskod = new System.Windows.Forms.TextBox();
            this.numerikadet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsatistarih = new System.Windows.Forms.TextBox();
            this.txtsatisbirimfiyati = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtmusteritc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpersoneltc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfatura = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnsepeteekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgmusterisepet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnMara = new System.Windows.Forms.Button();
            this.btnBara = new System.Windows.Forms.Button();
            this.txtpersoneladsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmusteriadsoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numerikadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmusterisepet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsatiskod
            // 
            this.txtsatiskod.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtsatiskod.Enabled = false;
            this.txtsatiskod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatiskod.Location = new System.Drawing.Point(12, 199);
            this.txtsatiskod.Name = "txtsatiskod";
            this.txtsatiskod.Size = new System.Drawing.Size(45, 27);
            this.txtsatiskod.TabIndex = 37;
            this.txtsatiskod.TabStop = false;
            this.txtsatiskod.Visible = false;
            // 
            // numerikadet
            // 
            this.numerikadet.BackColor = System.Drawing.Color.LavenderBlush;
            this.numerikadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numerikadet.Location = new System.Drawing.Point(228, 233);
            this.numerikadet.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numerikadet.Name = "numerikadet";
            this.numerikadet.Size = new System.Drawing.Size(120, 27);
            this.numerikadet.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(152, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(109, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ürün Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Barkod:";
            // 
            // txtsatistarih
            // 
            this.txtsatistarih.Enabled = false;
            this.txtsatistarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatistarih.Location = new System.Drawing.Point(228, 301);
            this.txtsatistarih.Name = "txtsatistarih";
            this.txtsatistarih.Size = new System.Drawing.Size(323, 27);
            this.txtsatistarih.TabIndex = 48;
            this.txtsatistarih.TabStop = false;
            // 
            // txtsatisbirimfiyati
            // 
            this.txtsatisbirimfiyati.Enabled = false;
            this.txtsatisbirimfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatisbirimfiyati.Location = new System.Drawing.Point(228, 268);
            this.txtsatisbirimfiyati.Name = "txtsatisbirimfiyati";
            this.txtsatisbirimfiyati.Size = new System.Drawing.Size(323, 27);
            this.txtsatisbirimfiyati.TabIndex = 43;
            // 
            // txtbarkod
            // 
            this.txtbarkod.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkod.Location = new System.Drawing.Point(228, 160);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(323, 27);
            this.txtbarkod.TabIndex = 41;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // txtmusteritc
            // 
            this.txtmusteritc.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtmusteritc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmusteritc.Location = new System.Drawing.Point(228, 91);
            this.txtmusteritc.MaxLength = 11;
            this.txtmusteritc.Name = "txtmusteritc";
            this.txtmusteritc.Size = new System.Drawing.Size(323, 27);
            this.txtmusteritc.TabIndex = 43;
            this.txtmusteritc.TextChanged += new System.EventHandler(this.txtmusteritc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Müşteri TC Kimlik No:";
            // 
            // txtpersoneltc
            // 
            this.txtpersoneltc.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtpersoneltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersoneltc.Location = new System.Drawing.Point(228, 25);
            this.txtpersoneltc.MaxLength = 11;
            this.txtpersoneltc.Name = "txtpersoneltc";
            this.txtpersoneltc.Size = new System.Drawing.Size(323, 27);
            this.txtpersoneltc.TabIndex = 43;
            this.txtpersoneltc.TextChanged += new System.EventHandler(this.txtpersoneltc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Personel TC Kimlik No:";
            // 
            // btnfatura
            // 
            this.btnfatura.BackColor = System.Drawing.Color.White;
            this.btnfatura.Image = ((System.Drawing.Image)(resources.GetObject("btnfatura.Image")));
            this.btnfatura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfatura.Location = new System.Drawing.Point(826, 268);
            this.btnfatura.Name = "btnfatura";
            this.btnfatura.Size = new System.Drawing.Size(79, 57);
            this.btnfatura.TabIndex = 51;
            this.btnfatura.Text = "FATURA";
            this.btnfatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfatura.UseVisualStyleBackColor = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkaydet.Location = new System.Drawing.Point(722, 268);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 57);
            this.btnkaydet.TabIndex = 49;
            this.btnkaydet.Text = "SATIN AL";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkaydet.UseVisualStyleBackColor = false;
            // 
            // btnyeni
            // 
            this.btnyeni.BackColor = System.Drawing.Color.White;
            this.btnyeni.Image = ((System.Drawing.Image)(resources.GetObject("btnyeni.Image")));
            this.btnyeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnyeni.Location = new System.Drawing.Point(618, 268);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 57);
            this.btnyeni.TabIndex = 50;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            // 
            // btnsepeteekle
            // 
            this.btnsepeteekle.BackColor = System.Drawing.Color.White;
            this.btnsepeteekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsepeteekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsepeteekle.Image = ((System.Drawing.Image)(resources.GetObject("btnsepeteekle.Image")));
            this.btnsepeteekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsepeteekle.Location = new System.Drawing.Point(665, 205);
            this.btnsepeteekle.Name = "btnsepeteekle";
            this.btnsepeteekle.Size = new System.Drawing.Size(203, 35);
            this.btnsepeteekle.TabIndex = 51;
            this.btnsepeteekle.Text = "SEPETE EKLE";
            this.btnsepeteekle.UseVisualStyleBackColor = false;
            this.btnsepeteekle.Click += new System.EventHandler(this.btnsepeteekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "MÜŞTERİ SEPETİ:";
            // 
            // dgmusterisepet
            // 
            this.dgmusterisepet.AllowUserToAddRows = false;
            this.dgmusterisepet.AllowUserToDeleteRows = false;
            this.dgmusterisepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgmusterisepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmusterisepet.Location = new System.Drawing.Point(16, 408);
            this.dgmusterisepet.Name = "dgmusterisepet";
            this.dgmusterisepet.ReadOnly = true;
            this.dgmusterisepet.RowTemplate.Height = 24;
            this.dgmusterisepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmusterisepet.Size = new System.Drawing.Size(949, 533);
            this.dgmusterisepet.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(614, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "ÖDENECEK TOPLAM TUTAR (TL) :";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtutar.ForeColor = System.Drawing.Color.Red;
            this.lbltoplamtutar.Location = new System.Drawing.Point(735, 91);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(23, 25);
            this.lbltoplamtutar.TabIndex = 44;
            this.lbltoplamtutar.Text = "0";
            // 
            // btnPara
            // 
            this.btnPara.BackColor = System.Drawing.Color.White;
            this.btnPara.Image = ((System.Drawing.Image)(resources.GetObject("btnPara.Image")));
            this.btnPara.Location = new System.Drawing.Point(558, 25);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(40, 26);
            this.btnPara.TabIndex = 54;
            this.btnPara.UseVisualStyleBackColor = false;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnMara
            // 
            this.btnMara.BackColor = System.Drawing.Color.White;
            this.btnMara.Image = ((System.Drawing.Image)(resources.GetObject("btnMara.Image")));
            this.btnMara.Location = new System.Drawing.Point(557, 89);
            this.btnMara.Name = "btnMara";
            this.btnMara.Size = new System.Drawing.Size(40, 26);
            this.btnMara.TabIndex = 54;
            this.btnMara.UseVisualStyleBackColor = false;
            this.btnMara.Click += new System.EventHandler(this.btnMara_Click);
            // 
            // btnBara
            // 
            this.btnBara.BackColor = System.Drawing.Color.White;
            this.btnBara.Image = ((System.Drawing.Image)(resources.GetObject("btnBara.Image")));
            this.btnBara.Location = new System.Drawing.Point(558, 163);
            this.btnBara.Name = "btnBara";
            this.btnBara.Size = new System.Drawing.Size(40, 26);
            this.btnBara.TabIndex = 54;
            this.btnBara.UseVisualStyleBackColor = false;
            this.btnBara.Click += new System.EventHandler(this.btnBara_Click);
            // 
            // txtpersoneladsoyad
            // 
            this.txtpersoneladsoyad.Enabled = false;
            this.txtpersoneladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersoneladsoyad.Location = new System.Drawing.Point(228, 58);
            this.txtpersoneladsoyad.Name = "txtpersoneladsoyad";
            this.txtpersoneladsoyad.Size = new System.Drawing.Size(323, 27);
            this.txtpersoneladsoyad.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(48, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Personel Ad Soyad:";
            // 
            // txtmusteriadsoyad
            // 
            this.txtmusteriadsoyad.Enabled = false;
            this.txtmusteriadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmusteriadsoyad.Location = new System.Drawing.Point(229, 125);
            this.txtmusteriadsoyad.Name = "txtmusteriadsoyad";
            this.txtmusteriadsoyad.Size = new System.Drawing.Size(323, 27);
            this.txtmusteriadsoyad.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(58, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Müşteri Ad Soyad:";
            // 
            // txturunadi
            // 
            this.txturunadi.Enabled = false;
            this.txturunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Location = new System.Drawing.Point(228, 196);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(323, 27);
            this.txturunadi.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(125, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Ürün Adı:";
            // 
            // Frmsatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(977, 953);
            this.Controls.Add(this.btnBara);
            this.Controls.Add(this.btnMara);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.dgmusterisepet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsepeteekle);
            this.Controls.Add(this.btnfatura);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.numerikadet);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsatistarih);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txtmusteriadsoyad);
            this.Controls.Add(this.txtpersoneladsoyad);
            this.Controls.Add(this.txtpersoneltc);
            this.Controls.Add(this.txtmusteritc);
            this.Controls.Add(this.txtsatisbirimfiyati);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.txtsatiskod);
            this.Name = "Frmsatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satış İşlemleri";
            this.Load += new System.EventHandler(this.Frmsatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerikadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmusterisepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsatiskod;
        private System.Windows.Forms.NumericUpDown numerikadet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsatistarih;
        private System.Windows.Forms.TextBox txtsatisbirimfiyati;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtmusteritc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpersoneltc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfatura;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Button btnsepeteekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgmusterisepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnMara;
        private System.Windows.Forms.Button btnBara;
        private System.Windows.Forms.TextBox txtpersoneladsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmusteriadsoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.Label label11;
    }
}