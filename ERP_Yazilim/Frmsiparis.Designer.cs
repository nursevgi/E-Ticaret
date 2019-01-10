namespace ERP_Yazilim
{
    partial class Frmsiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsiparis));
            this.dgsiparisler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsipno = new System.Windows.Forms.TextBox();
            this.txttakipno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsipdur = new System.Windows.Forms.ComboBox();
            this.cmbkargo = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgsiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgsiparisler
            // 
            this.dgsiparisler.AllowUserToAddRows = false;
            this.dgsiparisler.AllowUserToDeleteRows = false;
            this.dgsiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsiparisler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgsiparisler.Location = new System.Drawing.Point(0, 249);
            this.dgsiparisler.Name = "dgsiparisler";
            this.dgsiparisler.ReadOnly = true;
            this.dgsiparisler.RowTemplate.Height = 24;
            this.dgsiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsiparisler.Size = new System.Drawing.Size(1030, 523);
            this.dgsiparisler.TabIndex = 33;
            this.dgsiparisler.DoubleClick += new System.EventHandler(this.dgsiparisler_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "SİPARİŞLER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(278, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sipariş No:";
            // 
            // txtsipno
            // 
            this.txtsipno.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtsipno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsipno.Enabled = false;
            this.txtsipno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsipno.Location = new System.Drawing.Point(376, 32);
            this.txtsipno.Name = "txtsipno";
            this.txtsipno.Size = new System.Drawing.Size(325, 27);
            this.txtsipno.TabIndex = 35;
            // 
            // txttakipno
            // 
            this.txttakipno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttakipno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttakipno.Location = new System.Drawing.Point(376, 133);
            this.txttakipno.Name = "txttakipno";
            this.txttakipno.Size = new System.Drawing.Size(325, 27);
            this.txttakipno.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sipariş Durumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(312, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(241, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Kargo Takip No:";
            // 
            // cmbsipdur
            // 
            this.cmbsipdur.FormattingEnabled = true;
            this.cmbsipdur.Location = new System.Drawing.Point(376, 68);
            this.cmbsipdur.Name = "cmbsipdur";
            this.cmbsipdur.Size = new System.Drawing.Size(325, 24);
            this.cmbsipdur.TabIndex = 37;
            // 
            // cmbkargo
            // 
            this.cmbkargo.FormattingEnabled = true;
            this.cmbkargo.Location = new System.Drawing.Point(376, 103);
            this.cmbkargo.Name = "cmbkargo";
            this.cmbkargo.Size = new System.Drawing.Size(325, 24);
            this.cmbkargo.TabIndex = 37;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkaydet.Location = new System.Drawing.Point(717, 98);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 38;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Frmsiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1030, 772);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cmbkargo);
            this.Controls.Add(this.cmbsipdur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttakipno);
            this.Controls.Add(this.txtsipno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgsiparisler);
            this.Name = "Frmsiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Frmsiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgsiparisler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsipno;
        private System.Windows.Forms.TextBox txttakipno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsipdur;
        private System.Windows.Forms.ComboBox cmbkargo;
        private System.Windows.Forms.Button btnkaydet;
    }
}