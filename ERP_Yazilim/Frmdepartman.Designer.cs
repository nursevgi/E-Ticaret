namespace ERP_Yazilim
{
    partial class Frmdepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdepartman));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.dgdep = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdepadi = new System.Windows.Forms.TextBox();
            this.txtdepid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdep)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(564, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 251);
            this.textBox1.TabIndex = 27;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsil.Location = new System.Drawing.Point(401, 103);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(79, 62);
            this.btnsil.TabIndex = 21;
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
            this.btnkaydet.Location = new System.Drawing.Point(293, 103);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 19;
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
            this.btnyeni.Location = new System.Drawing.Point(186, 103);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 20;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // dgdep
            // 
            this.dgdep.AllowUserToAddRows = false;
            this.dgdep.AllowUserToDeleteRows = false;
            this.dgdep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgdep.Location = new System.Drawing.Point(0, 269);
            this.dgdep.Name = "dgdep";
            this.dgdep.ReadOnly = true;
            this.dgdep.RowTemplate.Height = 24;
            this.dgdep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdep.Size = new System.Drawing.Size(815, 510);
            this.dgdep.TabIndex = 22;
            this.dgdep.DoubleClick += new System.EventHandler(this.dgdep_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "KAYITLI DEPARTMANLAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "DEPARTMAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // txtdepadi
            // 
            this.txtdepadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdepadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdepadi.Location = new System.Drawing.Point(174, 53);
            this.txtdepadi.Name = "txtdepadi";
            this.txtdepadi.Size = new System.Drawing.Size(323, 27);
            this.txtdepadi.TabIndex = 18;
            this.txtdepadi.TextChanged += new System.EventHandler(this.txtdepadi_TextChanged);
            // 
            // txtdepid
            // 
            this.txtdepid.Enabled = false;
            this.txtdepid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdepid.Location = new System.Drawing.Point(42, 1);
            this.txtdepid.Name = "txtdepid";
            this.txtdepid.Size = new System.Drawing.Size(34, 27);
            this.txtdepid.TabIndex = 26;
            this.txtdepid.TabStop = false;
            this.txtdepid.Visible = false;
            // 
            // Frmdepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 779);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.dgdep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdepadi);
            this.Controls.Add(this.txtdepid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(833, 826);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(833, 826);
            this.Name = "Frmdepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman";
            this.Load += new System.EventHandler(this.Frmdepartman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.DataGridView dgdep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdepadi;
        private System.Windows.Forms.TextBox txtdepid;
    }
}