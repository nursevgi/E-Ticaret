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
            this.dgsiparisler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgsiparisler.Location = new System.Drawing.Point(0, 53);
            this.dgsiparisler.Name = "dgsiparisler";
            this.dgsiparisler.ReadOnly = true;
            this.dgsiparisler.RowTemplate.Height = 24;
            this.dgsiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsiparisler.Size = new System.Drawing.Size(1030, 719);
            this.dgsiparisler.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "SİPARİŞLER:";
            // 
            // Frmsiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 772);
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
    }
}