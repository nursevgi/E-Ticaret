namespace ERP_Yazilim
{
    partial class Frmilce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmilce));
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtilceid = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.dgilce = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgilce)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbil
            // 
            this.cmbil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(116, 53);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(309, 28);
            this.cmbil.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(543, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 307);
            this.textBox1.TabIndex = 27;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // txtilceid
            // 
            this.txtilceid.Enabled = false;
            this.txtilceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilceid.Location = new System.Drawing.Point(63, 1);
            this.txtilceid.Name = "txtilceid";
            this.txtilceid.Size = new System.Drawing.Size(34, 27);
            this.txtilceid.TabIndex = 26;
            this.txtilceid.TabStop = false;
            this.txtilceid.Visible = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsil.Location = new System.Drawing.Point(334, 151);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(79, 62);
            this.btnsil.TabIndex = 4;
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
            this.btnkaydet.Location = new System.Drawing.Point(232, 151);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 2;
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
            this.btnyeni.Location = new System.Drawing.Point(128, 151);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 3;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // dgilce
            // 
            this.dgilce.AllowUserToAddRows = false;
            this.dgilce.AllowUserToDeleteRows = false;
            this.dgilce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgilce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgilce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgilce.Location = new System.Drawing.Point(0, 327);
            this.dgilce.Name = "dgilce";
            this.dgilce.ReadOnly = true;
            this.dgilce.RowTemplate.Height = 24;
            this.dgilce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgilce.Size = new System.Drawing.Size(841, 510);
            this.dgilce.TabIndex = 5;
            this.dgilce.DoubleClick += new System.EventHandler(this.dgilce_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "KAYITLI İLÇELER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "İLÇE ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "İL ADI:";
            // 
            // txtilce
            // 
            this.txtilce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilce.Location = new System.Drawing.Point(116, 95);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(309, 27);
            this.txtilce.TabIndex = 1;
            this.txtilce.TextChanged += new System.EventHandler(this.txtilce_TextChanged);
            // 
            // Frmilce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 837);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtilceid);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.dgilce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtilce);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 884);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(859, 884);
            this.Name = "Frmilce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlçeler";
            this.Load += new System.EventHandler(this.Frmilce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgilce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilceid;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.DataGridView dgilce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtilce;
    }
}