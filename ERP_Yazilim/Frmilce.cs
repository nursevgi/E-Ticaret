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
    public partial class Frmilce : Form
    {
        public Frmilce()
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
            command.CommandText = "SELECT ilcekod,ilce,il FROM ilceler,iller WHERE iller.ilkod=ilceler.ilkod ORDER BY ilce";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgilce.DataSource = tablo;
            dgilce.Columns["ilcekod"].Visible = false;
            dgilce.Columns["ilce"].HeaderText = "İLÇE";
            dgilce.Columns["il"].HeaderText = "İL";
            cmbil.SelectedIndex = -1;
            conn.Close();
        }


        void ilDoldur()
        {
            baglan();
            command.CommandText = "SELECT * FROM iller";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbil.DataSource = tablo;
            cmbil.DisplayMember = "il";
            cmbil.ValueMember = "ilkod";
            conn.Close();
        }

        void ekleilce()
        {
            baglan();
            command.CommandText = "INSERT INTO ilceler (ilce,ilkod) VALUES (@ilce,@ilkod)";
            command.Parameters.AddWithValue("@ilce", txtilce.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("İlçe Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(ilcekod) FROM ilceler";
            txtilceid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncelleilce()
        {
            baglan();
            command.CommandText = "UPDATE ilceler SET ilce=@ilce,ilkod=@ilkod WHERE ilcekod=@ilcekod";
            command.Parameters.AddWithValue("@ilce", txtilce.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.Parameters.AddWithValue("@ilcekod", Convert.ToInt32(txtilceid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("İlçe Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }


        void Kaydetilce()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM ilceler WHERE ilcekod=@ilcekod";
            command.Parameters.AddWithValue("@ilcekod", txtilceid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("İlçe Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelleilce();
                }
                else
                {
                    MessageBox.Show("İlçe Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekleilce();
            }
        }

        private void Frmilce_Load(object sender, EventArgs e)
        {
            ilDoldur();
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (cmbil.SelectedIndex != -1)
            {
                if (txtilce.Text != "")
                {
                    if (FrmAnaktg.SayisalMi(txtilce.Text) == false)
                    {
                        Kaydetilce();
                    }

                    else
                    {
                        MessageBox.Show("İlçe Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtilce.Focus();
                        txtilce.SelectAll();
                    }
                }

                else
                {
                    MessageBox.Show("İlçe Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtilce.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen İl Seçimi Yapınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbil.Focus();
            }
        }

        private void txtilce_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM ilceler WHERE ilce LIKE @ilce ORDER BY ilcekod";
            command.Parameters.AddWithValue("@ilce", "%" + txtilce.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgilce.DataSource = tablo;
            conn.Close();
        }

        private void dgilce_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM ilceler WHERE ilcekod=@ilcekod";
            command.Parameters.AddWithValue("@ilcekod", dgilce.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtilceid.Text = tablo.Rows[0]["ilcekod"].ToString();
            txtilce.Text = tablo.Rows[0]["ilce"].ToString();
            cmbil.Text = tablo.Rows[0]["ilkod"].ToString();
            conn.Close();
            listele();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtilceid.Clear();
            txtilce.Clear();
            cmbil.SelectedIndex = -1;
            cmbil.Focus();
            listele();
        }

       public bool iliskikontrolü(string tabloadi,string kod,string kodAlani)
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM "+tabloadi+" WHERE "+kod+"=@"+kod;
            command.Parameters.AddWithValue("@"+kod,kodAlani);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count <= 0)
                return false;
            else
                return true;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen İlçe Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if(iliskikontrolü("musteri","ilcekod",dgilce.CurrentRow.Cells[0].Value.ToString())!=true)
                {
                    command.CommandText = "DELETE FROM ilceler WHERE ilcekod=@ilcekod";
                    command.Parameters.AddWithValue("@ilce", Convert.ToInt32(dgilce.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("İlçe Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.İlçe Silme İşlemi İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("İlçe Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }
    }
}
