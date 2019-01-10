using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ERP_Yazilim
{
    public partial class Frmsiparis : Form
    {
        public Frmsiparis()
        {
            InitializeComponent();
        }

        SqlCommand command = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        DataGridViewComboBoxColumn sipdurcolumn = new DataGridViewComboBoxColumn();

        public void baglan()
        {
            conn.Close();
            conn.ConnectionString = "server=.; Initial Catalog=erp;Integrated Security=SSPI";
            command.Connection = conn;
            command.Parameters.Clear();
            conn.Open();
        }

        void SiparisDurumuDoldur()
        {
            baglan();
            command.CommandText = "SELECT * FROM siparisdurum";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbsipdur.DataSource = tablo;
            cmbsipdur.DisplayMember = "durum";
            cmbsipdur.ValueMember = "sipdurno";
            conn.Close();
        }

        void KargoDoldur()
        {
            baglan();
            command.CommandText = "SELECT kargono,kargoadi FROM kargo";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbkargo.DataSource = tablo;
            cmbkargo.DisplayMember = "kargoadi";
            cmbkargo.ValueMember = "kargono";
            conn.Close();
        }

        void listele()
        {

            baglan();
            command.CommandText = "SELECT sipno,durum,siparistarihi,kargoadi,takipno FROM siparisler,siparisdurum,kargo WHERE siparisdurum.sipdurno=siparisler.sipdurno AND kargo.kargono=siparisler.kargono ORDER BY siparistarihi DESC";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgsiparisler.DataSource = tablo;
            dgsiparisler.Columns["sipno"].HeaderText = "Sipariş Numarası";
            dgsiparisler.Columns["sipno"].ReadOnly=true;
            dgsiparisler.Columns["durum"].HeaderText = "Sipariş Durumu";
            dgsiparisler.Columns["siparistarihi"].HeaderText = "Sipariş Tarihi";
            dgsiparisler.Columns["siparistarihi"].ReadOnly = true;
            dgsiparisler.Columns["kargoadi"].HeaderText = "Kargo Firması";
            dgsiparisler.Columns["takipno"].HeaderText = "Kargo Takip No";
            conn.Close();
        }

        private void Frmsiparis_Load(object sender, EventArgs e)
        {
            KargoDoldur();
            SiparisDurumuDoldur();
            listele();

            for (int i = 0; i < dgsiparisler.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (dgsiparisler.Rows[i].Cells["durum"].Value.ToString()=="KARGOYA VERİLDİ")
                {
                    renk.BackColor = Color.Yellow;
                }
                else if (dgsiparisler.Rows[i].Cells["durum"].Value.ToString()=="HAZIRLANIYOR")
                {
                    renk.BackColor = Color.GreenYellow;
                }
                else if (dgsiparisler.Rows[i].Cells["durum"].Value.ToString() == "BEKLEMEDE")
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else { }
                dgsiparisler.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgsiparisler_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT sipno,durum,kargoadi,takipno FROM siparisler,siparisdurum,kargo WHERE siparisdurum.sipdurno=siparisler.sipdurno AND kargo.kargono=siparisler.kargono AND sipno=@sipno ORDER BY siparistarihi DESC";
            command.Parameters.AddWithValue("@sipno", dgsiparisler.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtsipno.Text = dgsiparisler.CurrentRow.Cells[0].Value.ToString();
            txttakipno.Text = dgsiparisler.CurrentRow.Cells[4].Value.ToString();
            cmbkargo.Text = dgsiparisler.CurrentRow.Cells[3].Value.ToString();
            cmbsipdur.Text = dgsiparisler.CurrentRow.Cells[1].Value.ToString();
            conn.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "UPDATE siparisler SET sipdurno=@sipdurno,kargono=@kargono,takipno=@takipno WHERE sipno=@sipno";
            command.Parameters.AddWithValue("@sipdurno", Convert.ToInt32(cmbsipdur.SelectedValue));
            command.Parameters.AddWithValue("@kargono", Convert.ToInt32(cmbkargo.SelectedValue));
            command.Parameters.AddWithValue("@takipno", txttakipno.Text);
            command.Parameters.AddWithValue("@sipno", txtsipno.Text);
            command.ExecuteNonQuery();
            conn.Close();     
            MessageBox.Show("Sipariş Bilgisi Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
    }
}
