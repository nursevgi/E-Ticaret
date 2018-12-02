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
    public partial class Frmil : Form
    {
        public Frmil()
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
            command.CommandText = "SELECT * FROM iller ORDER BY il";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgiller.DataSource = tablo;
            dgiller.Columns["ilkod"].Visible = false;
            dgiller.Columns["il"].HeaderText = "İL";
            conn.Close();
        }

        private void Frmil_Load(object sender, EventArgs e)
        {
            listele();
        }

        void ekleil()
        {
            baglan();
            command.CommandText = "INSERT INTO iller (il) VALUES (@il)";
            command.Parameters.AddWithValue("@il", txtiladi.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("İl Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(ilkod) FROM iller";
            txtilid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncelleil()
        {
            baglan();
            command.CommandText = "UPDATE iller SET il=@il WHERE ilkod=@ilkod";
            command.Parameters.AddWithValue("@il", txtiladi.Text);
            command.Parameters.AddWithValue("@ilkod", Convert.ToInt32(txtilid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("İl Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void Kaydetil()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM iller WHERE ilkod=@ilkod";
            command.Parameters.AddWithValue("@ilkod", txtilid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("İl Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelleil();
                }
                else
                {
                    MessageBox.Show("İl Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekleil();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtiladi.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtiladi.Text) == false)
                {
                    Kaydetil();
                }

                else
                {
                    MessageBox.Show("İl Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtiladi.Focus();
                    txtiladi.SelectAll();
                }
            }

            else
            {
                MessageBox.Show("İl Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtiladi.Focus();
            }
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtilid.Clear();
            txtiladi.Clear();
            txtiladi.Focus();
        }

        private void txtiladi_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM iller WHERE il LIKE @il ORDER BY ilkod";
            command.Parameters.AddWithValue("@il", "%" + txtiladi.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgiller.DataSource = tablo;
            conn.Close();
        }

        private void dgiller_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM iller WHERE ilkod=@ilkod";
            command.Parameters.AddWithValue("@ilkod", dgiller.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtilid.Text = tablo.Rows[0]["ilkod"].ToString();
            txtiladi.Text = tablo.Rows[0]["il"].ToString();
            conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen İl Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "SELECT COUNT(*) FROM ilceler WHERE ilkod=@ilkod";
                command.Parameters.AddWithValue("@ilkod", dgiller.CurrentRow.Cells[0].Value.ToString());
                int count = Convert.ToInt32(command.ExecuteScalar());
                baglan();
                if (count <= 0)
                {
                    command.CommandText = "DELETE FROM iller WHERE ilkod=@ilkod";
                    command.Parameters.AddWithValue("@ilkod", Convert.ToInt32(dgiller.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("İl Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.İl Silme İşlemi İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("İl Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }

    }
}
