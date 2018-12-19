namespace ERP_Yazilim
{
    partial class Frmalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmalis));
            this.dgalinanurunler = new System.Windows.Forms.DataGridView();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtalisbirimfiyati = new System.Windows.Forms.TextBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtresimkodu = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtalisid = new System.Windows.Forms.TextBox();
            this.numerikadet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtalistarihi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgalinanurunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerikadet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgalinanurunler
            // 
            this.dgalinanurunler.AllowUserToAddRows = false;
            this.dgalinanurunler.AllowUserToDeleteRows = false;
            this.dgalinanurunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgalinanurunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgalinanurunler.Location = new System.Drawing.Point(0, 393);
            this.dgalinanurunler.Name = "dgalinanurunler";
            this.dgalinanurunler.ReadOnly = true;
            this.dgalinanurunler.RowTemplate.Height = 24;
            this.dgalinanurunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalinanurunler.Size = new System.Drawing.Size(858, 652);
            this.dgalinanurunler.TabIndex = 5;
            this.dgalinanurunler.DoubleClick += new System.EventHandler(this.dgalinanurunler_DoubleClick);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkaydet.Location = new System.Drawing.Point(465, 234);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 3;
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
            this.btnyeni.Location = new System.Drawing.Point(361, 234);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 4;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(206, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(218, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Barkod:";
            // 
            // txtalisbirimfiyati
            // 
            this.txtalisbirimfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalisbirimfiyati.Location = new System.Drawing.Point(298, 148);
            this.txtalisbirimfiyati.Name = "txtalisbirimfiyati";
            this.txtalisbirimfiyati.Size = new System.Drawing.Size(323, 27);
            this.txtalisbirimfiyati.TabIndex = 2;
            // 
            // txturunadi
            // 
            this.txturunadi.BackColor = System.Drawing.Color.LavenderBlush;
            this.txturunadi.Enabled = false;
            this.txturunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Location = new System.Drawing.Point(298, 79);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(323, 27);
            this.txturunadi.TabIndex = 37;
            this.txturunadi.TabStop = false;
            // 
            // txtresimkodu
            // 
            this.txtresimkodu.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtresimkodu.Enabled = false;
            this.txtresimkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresimkodu.Location = new System.Drawing.Point(-88, 15);
            this.txtresimkodu.Name = "txtresimkodu";
            this.txtresimkodu.Size = new System.Drawing.Size(45, 27);
            this.txtresimkodu.TabIndex = 41;
            this.txtresimkodu.TabStop = false;
            this.txtresimkodu.Visible = false;
            // 
            // txtbarkod
            // 
            this.txtbarkod.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkod.Location = new System.Drawing.Point(298, 46);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(323, 27);
            this.txtbarkod.TabIndex = 0;
            // 
            // txtalisid
            // 
            this.txtalisid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalisid.Location = new System.Drawing.Point(12, 12);
            this.txtalisid.Name = "txtalisid";
            this.txtalisid.Size = new System.Drawing.Size(73, 27);
            this.txtalisid.TabIndex = 40;
            this.txtalisid.TabStop = false;
            this.txtalisid.Visible = false;
            // 
            // numerikadet
            // 
            this.numerikadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numerikadet.Location = new System.Drawing.Point(298, 113);
            this.numerikadet.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numerikadet.Name = "numerikadet";
            this.numerikadet.Size = new System.Drawing.Size(120, 27);
            this.numerikadet.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(237, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(292, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(292, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(112, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ürün Alış Birim Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(233, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "DEPOYA ALINAN ÜRÜNLER:";
            // 
            // txtalistarihi
            // 
            this.txtalistarihi.Enabled = false;
            this.txtalistarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalistarihi.Location = new System.Drawing.Point(298, 182);
            this.txtalistarihi.Name = "txtalistarihi";
            this.txtalistarihi.Size = new System.Drawing.Size(323, 27);
            this.txtalistarihi.TabIndex = 40;
            this.txtalistarihi.TabStop = false;
            // 
            // Frmalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(858, 1045);
            this.Controls.Add(this.numerikadet);
            this.Controls.Add(this.dgalinanurunler);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtalisid);
            this.Controls.Add(this.txtalistarihi);
            this.Controls.Add(this.txtalisbirimfiyati);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txtresimkodu);
            this.Controls.Add(this.txtbarkod);
            this.Name = "Frmalis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depoya Alınan Ürün İşlemleri";
            this.Load += new System.EventHandler(this.Frmalis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgalinanurunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerikadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgalinanurunler;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtalisbirimfiyati;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtresimkodu;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtalisid;
        private System.Windows.Forms.NumericUpDown numerikadet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtalistarihi;

    }
}