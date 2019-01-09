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
    public partial class Frmsiparisdurum : Form
    {
        public Frmsiparisdurum()
        {
            InitializeComponent();
        }

        SqlCommand command = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public void baglan()
        {
            conn.Close();
            conn.ConnectionString = "server=.; Initial Catalog=erp;Integrated Security=SSPI";
            command.Connection = conn;
            command.Parameters.Clear();
            conn.Open();
        }

        void listele()
        {
            baglan();
            command.CommandText = "SELECT * FROM siparisdurum ORDER BY durum";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgsipdur.DataSource = tablo;
            dgsipdur.Columns["sipdurno"].Visible = false;
            dgsipdur.Columns["durum"].HeaderText = "SİPARİŞ DURUMU";
            conn.Close();
        }

        private void Frmsiparisdurum_Load(object sender, EventArgs e)
        {
            listele();
        }

        void eklesipdur()
        {
            baglan();
            command.CommandText = "INSERT INTO siparisdurum (durum) VALUES (@durum)";
            command.Parameters.AddWithValue("@durum", txtsipdur.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Sipariş Durumu Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(durum) FROM siparisdurum";
            txtsipdurid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncellesipdur()
        {
            baglan();
            command.CommandText = "UPDATE siparisdurum SET durum=@durum WHERE sipdurno=@sipdurno";
            command.Parameters.AddWithValue("@durum", txtsipdur.Text);
            command.Parameters.AddWithValue("@sipdurno",txtsipdurid.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sipariş Durumu Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void Kaydetsipdur()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM siparisdurum WHERE sipdurno=@sipdurno";
            command.Parameters.AddWithValue("@sipdurno", txtsipdurid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi <= 0)
            {
                eklesipdur();
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Sipariş Durumu Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncellesipdur();
                }
                else
                {
                    MessageBox.Show("Sipariş Durumu Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
           
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtsipdur.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtsipdur.Text) == false)
                {
                    Kaydetsipdur();
                }

                else
                {
                    MessageBox.Show("Sipariş Durumu Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsipdur.Focus();
                    txtsipdur.SelectAll();
                }
            }

            else
            {
                MessageBox.Show("Sipariş Durumu Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsipdur.Focus();
            }
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtsipdur.Clear();
            txtsipdurid.Clear();
            txtsipdur.Focus();
        }

        private void txtsipdur_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM siparisdurum WHERE durum LIKE @durum ORDER BY sipdurno";
            command.Parameters.AddWithValue("@durum", "%" + txtsipdur.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgsipdur.DataSource = tablo;
            conn.Close();
        }

        private void dgsipdur_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM siparisdurum WHERE sipdurno=@sipdurno";
            command.Parameters.AddWithValue("@sipdurno", dgsipdur.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtsipdurid.Text = tablo.Rows[0]["sipdurno"].ToString();
            txtsipdur.Text = tablo.Rows[0]["durum"].ToString();
            conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            Frmilce ilce = new Frmilce();
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Sipariş Durumu Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if (ilce.iliskikontrolü("siparisler", "sipdurno", dgsipdur.CurrentRow.Cells[0].Value.ToString()) != true)
                {
                    command.CommandText = "DELETE FROM siparisdurum WHERE sipdurno=@sipdurno";
                    command.Parameters.AddWithValue("@sipdurno", Convert.ToInt32(dgsipdur.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sipariş Durumu Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Sipariş Durumu Silme İşlemi İptal Edildi.İlişikili Kayıtların Bulunduğu Yer:Siparişler", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Sipariş Durumu Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }
    }
}
