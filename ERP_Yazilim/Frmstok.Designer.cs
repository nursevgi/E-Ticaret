namespace ERP_Yazilim
{
    partial class Frmstok
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.rbbarkod = new System.Windows.Forms.RadioButton();
            this.rbadet = new System.Windows.Forms.RadioButton();
            this.rbmarka = new System.Windows.Forms.RadioButton();
            this.rburunadi = new System.Windows.Forms.RadioButton();
            this.dgstoklar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgstoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(381, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARANACAK DEĞER:";
            // 
            // txtaranan
            // 
            this.txtaranan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtaranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaranan.Location = new System.Drawing.Point(385, 71);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(323, 27);
            this.txtaranan.TabIndex = 2;
            this.txtaranan.TextChanged += new System.EventHandler(this.txtaranan_TextChanged);
            // 
            // rbbarkod
            // 
            this.rbbarkod.AutoSize = true;
            this.rbbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbbarkod.Location = new System.Drawing.Point(595, 151);
            this.rbbarkod.Name = "rbbarkod";
            this.rbbarkod.Size = new System.Drawing.Size(83, 24);
            this.rbbarkod.TabIndex = 4;
            this.rbbarkod.Text = "Barkod";
            this.rbbarkod.UseVisualStyleBackColor = true;
            // 
            // rbadet
            // 
            this.rbadet.AutoSize = true;
            this.rbadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbadet.Location = new System.Drawing.Point(453, 151);
            this.rbadet.Name = "rbadet";
            this.rbadet.Size = new System.Drawing.Size(64, 24);
            this.rbadet.TabIndex = 4;
            this.rbadet.Text = "Adet";
            this.rbadet.UseVisualStyleBackColor = true;
            // 
            // rbmarka
            // 
            this.rbmarka.AutoSize = true;
            this.rbmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbmarka.Location = new System.Drawing.Point(759, 151);
            this.rbmarka.Name = "rbmarka";
            this.rbmarka.Size = new System.Drawing.Size(76, 24);
            this.rbmarka.TabIndex = 4;
            this.rbmarka.Text = "Marka";
            this.rbmarka.UseVisualStyleBackColor = true;
            // 
            // rburunadi
            // 
            this.rburunadi.AutoSize = true;
            this.rburunadi.Checked = true;
            this.rburunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rburunadi.Location = new System.Drawing.Point(272, 151);
            this.rburunadi.Name = "rburunadi";
            this.rburunadi.Size = new System.Drawing.Size(95, 24);
            this.rburunadi.TabIndex = 4;
            this.rburunadi.TabStop = true;
            this.rburunadi.Text = "Ürün Adı";
            this.rburunadi.UseVisualStyleBackColor = true;
            // 
            // dgstoklar
            // 
            this.dgstoklar.AllowUserToAddRows = false;
            this.dgstoklar.AllowUserToDeleteRows = false;
            this.dgstoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgstoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstoklar.Location = new System.Drawing.Point(7, 301);
            this.dgstoklar.Name = "dgstoklar";
            this.dgstoklar.ReadOnly = true;
            this.dgstoklar.RowTemplate.Height = 24;
            this.dgstoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgstoklar.Size = new System.Drawing.Size(1079, 569);
            this.dgstoklar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "STOKLAR:";
            // 
            // Frmstok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1098, 882);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgstoklar);
            this.Controls.Add(this.rburunadi);
            this.Controls.Add(this.rbadet);
            this.Controls.Add(this.rbmarka);
            this.Controls.Add(this.rbbarkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaranan);
            this.Name = "Frmstok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK DURUMU";
            this.Load += new System.EventHandler(this.Frmstok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgstoklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaranan;
        private System.Windows.Forms.RadioButton rbbarkod;
        private System.Windows.Forms.RadioButton rbadet;
        private System.Windows.Forms.RadioButton rbmarka;
        private System.Windows.Forms.RadioButton rburunadi;
        private System.Windows.Forms.DataGridView dgstoklar;
        private System.Windows.Forms.Label label1;
    }
}