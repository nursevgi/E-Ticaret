namespace ERP_Yazilim
{
    partial class FrmAltktg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltktg));
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.dgAltktg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaltid = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAltktg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnaktg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAltktg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsil.Location = new System.Drawing.Point(433, 163);
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
            this.btnkaydet.Location = new System.Drawing.Point(331, 163);
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
            this.btnyeni.Location = new System.Drawing.Point(227, 163);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 3;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // dgAltktg
            // 
            this.dgAltktg.AllowUserToAddRows = false;
            this.dgAltktg.AllowUserToDeleteRows = false;
            this.dgAltktg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAltktg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAltktg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAltktg.Location = new System.Drawing.Point(0, 327);
            this.dgAltktg.Name = "dgAltktg";
            this.dgAltktg.ReadOnly = true;
            this.dgAltktg.RowTemplate.Height = 24;
            this.dgAltktg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAltktg.Size = new System.Drawing.Size(841, 510);
            this.dgAltktg.TabIndex = 5;
            this.dgAltktg.DoubleClick += new System.EventHandler(this.dgAltktg_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "KAYITLI ALT KATEGORİLER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ANA KATEGORİ ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // txtaltid
            // 
            this.txtaltid.Enabled = false;
            this.txtaltid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaltid.Location = new System.Drawing.Point(63, 3);
            this.txtaltid.Name = "txtaltid";
            this.txtaltid.Size = new System.Drawing.Size(34, 27);
            this.txtaltid.TabIndex = 14;
            this.txtaltid.TabStop = false;
            this.txtaltid.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(543, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 307);
            this.textBox1.TabIndex = 15;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // txtAltktg
            // 
            this.txtAltktg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltktg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltktg.Location = new System.Drawing.Point(214, 97);
            this.txtAltktg.Name = "txtAltktg";
            this.txtAltktg.Size = new System.Drawing.Size(309, 27);
            this.txtAltktg.TabIndex = 1;
            this.txtAltktg.TextChanged += new System.EventHandler(this.txtAltktg_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ALT KATEGORİ ADI:";
            // 
            // cmbAnaktg
            // 
            this.cmbAnaktg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnaktg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAnaktg.FormattingEnabled = true;
            this.cmbAnaktg.Location = new System.Drawing.Point(214, 55);
            this.cmbAnaktg.Name = "cmbAnaktg";
            this.cmbAnaktg.Size = new System.Drawing.Size(309, 28);
            this.cmbAnaktg.TabIndex = 0;
            // 
            // FrmAltktg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(841, 837);
            this.Controls.Add(this.cmbAnaktg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaltid);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.dgAltktg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltktg);
            this.Name = "FrmAltktg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alt Kategoriler";
            this.Load += new System.EventHandler(this.FrmAltktg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAltktg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.DataGridView dgAltktg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaltid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAltktg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAnaktg;
    }
}