namespace ERP_Yazilim
{
    partial class FrmAnaktg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaktg));
            this.txtanaid = new System.Windows.Forms.TextBox();
            this.txtanaktg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dganaktg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dganaktg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtanaid
            // 
            this.txtanaid.Enabled = false;
            this.txtanaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtanaid.Location = new System.Drawing.Point(42, 5);
            this.txtanaid.Name = "txtanaid";
            this.txtanaid.Size = new System.Drawing.Size(34, 27);
            this.txtanaid.TabIndex = 1;
            this.txtanaid.TabStop = false;
            this.txtanaid.Visible = false;
            // 
            // txtanaktg
            // 
            this.txtanaktg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtanaktg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtanaktg.Location = new System.Drawing.Point(211, 60);
            this.txtanaktg.Name = "txtanaktg";
            this.txtanaktg.Size = new System.Drawing.Size(323, 27);
            this.txtanaktg.TabIndex = 0;
            this.txtanaktg.TextChanged += new System.EventHandler(this.txtanaktg_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ANA KATEGORİ ADI:";
            // 
            // dganaktg
            // 
            this.dganaktg.AllowUserToAddRows = false;
            this.dganaktg.AllowUserToDeleteRows = false;
            this.dganaktg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dganaktg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dganaktg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dganaktg.Location = new System.Drawing.Point(0, 269);
            this.dganaktg.Name = "dganaktg";
            this.dganaktg.ReadOnly = true;
            this.dganaktg.RowTemplate.Height = 24;
            this.dganaktg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dganaktg.Size = new System.Drawing.Size(815, 510);
            this.dganaktg.TabIndex = 5;
            this.dganaktg.DoubleClick += new System.EventHandler(this.dganaktg_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "KAYITLI ANA KATEGORİLER:";
            // 
            // btnyeni
            // 
            this.btnyeni.BackColor = System.Drawing.Color.White;
            this.btnyeni.Image = ((System.Drawing.Image)(resources.GetObject("btnyeni.Image")));
            this.btnyeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnyeni.Location = new System.Drawing.Point(223, 110);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(79, 62);
            this.btnyeni.TabIndex = 4;
            this.btnyeni.Text = "YENİ";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkaydet.Location = new System.Drawing.Point(330, 110);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 62);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsil.Location = new System.Drawing.Point(438, 110);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(79, 62);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(564, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 251);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // FrmAnaktg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(815, 779);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.dganaktg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtanaktg);
            this.Controls.Add(this.txtanaid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(833, 826);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(833, 826);
            this.Name = "FrmAnaktg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kategoriler";
            this.Load += new System.EventHandler(this.FrmAnaktg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dganaktg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtanaid;
        private System.Windows.Forms.TextBox txtanaktg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dganaktg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}