namespace ERP_Yazilim
{
    partial class Frmsorgurapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsorgurapor));
            this.lblbaslik = new System.Windows.Forms.Label();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.dgsonuc = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSorgu = new System.Windows.Forms.ComboBox();
            this.txtbastarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbittarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgsonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Location = new System.Drawing.Point(683, 9);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(67, 20);
            this.lblbaslik.TabIndex = 41;
            this.lblbaslik.Text = "Barkod:";
            // 
            // txtdeger
            // 
            this.txtdeger.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdeger.Location = new System.Drawing.Point(687, 32);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(383, 27);
            this.txtdeger.TabIndex = 40;
            // 
            // dgsonuc
            // 
            this.dgsonuc.AllowUserToAddRows = false;
            this.dgsonuc.AllowUserToDeleteRows = false;
            this.dgsonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsonuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgsonuc.Location = new System.Drawing.Point(0, 157);
            this.dgsonuc.Name = "dgsonuc";
            this.dgsonuc.ReadOnly = true;
            this.dgsonuc.RowTemplate.Height = 24;
            this.dgsonuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsonuc.Size = new System.Drawing.Size(1226, 607);
            this.dgsonuc.TabIndex = 42;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.Location = new System.Drawing.Point(1092, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 62);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Sorgu Seçiniz:";
            // 
            // cmbSorgu
            // 
            this.cmbSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSorgu.FormattingEnabled = true;
            this.cmbSorgu.Items.AddRange(new object[] {
            "Tüm Ürünler",
            "Markaya Göre Ürünler",
            "Ana Kategoriye Göre Ürünler",
            "Alt KAtegoriye Göre Ürünler",
            "Tüm Personeller",
            "Departmana Göre Personeller",
            "Girile Ay İçerisinde İşe Başlayan Personeller",
            "İllere Göre Personeller",
            "2 Tarih Arasındaki Satışlar"});
            this.cmbSorgu.Location = new System.Drawing.Point(26, 35);
            this.cmbSorgu.Name = "cmbSorgu";
            this.cmbSorgu.Size = new System.Drawing.Size(548, 28);
            this.cmbSorgu.TabIndex = 44;
            this.cmbSorgu.SelectedIndexChanged += new System.EventHandler(this.cmbSorgu_SelectedIndexChanged);
            // 
            // txtbastarih
            // 
            this.txtbastarih.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtbastarih.Enabled = false;
            this.txtbastarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbastarih.Location = new System.Drawing.Point(26, 108);
            this.txtbastarih.Name = "txtbastarih";
            this.txtbastarih.Size = new System.Drawing.Size(383, 27);
            this.txtbastarih.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Başlangıç Tarihi: (Gün.Ay.Yıl) - Örnek: 09.1.2019";
            // 
            // txtbittarih
            // 
            this.txtbittarih.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtbittarih.Enabled = false;
            this.txtbittarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbittarih.Location = new System.Drawing.Point(529, 108);
            this.txtbittarih.Name = "txtbittarih";
            this.txtbittarih.Size = new System.Drawing.Size(383, 27);
            this.txtbittarih.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(525, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Bitiş Tarihi: (Gün.Ay.Yıl)";
            // 
            // Frmsorgurapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 764);
            this.Controls.Add(this.cmbSorgu);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.txtbittarih);
            this.Controls.Add(this.txtbastarih);
            this.Controls.Add(this.txtdeger);
            this.Name = "Frmsorgurapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORGU / RAPOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgsonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.DataGridView dgsonuc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSorgu;
        private System.Windows.Forms.TextBox txtbastarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbittarih;
        private System.Windows.Forms.Label label3;
    }
}