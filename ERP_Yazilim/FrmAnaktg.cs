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
    public partial class FrmAnaktg : Form
    {

        public FrmAnaktg()
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

        public static bool SayisalMi(string deger)
        {
            foreach (char chr in deger)
            {
                if (!Char.IsNumber(chr))
                    return false;
            }
            return true;
        }

        void listele()
        {
            baglan();
            command.CommandText = "SELECT * FROM anakategori ORDER BY anagrup";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dganaktg.DataSource = tablo;
            dganaktg.Columns["anakod"].Visible = false;
            dganaktg.Columns["anagrup"].HeaderText = "ANA KATEGORİ";
            conn.Close();
        }
        private void FrmAnaktg_Load(object sender, EventArgs e)
        {
            listele();
        }

        void ekleAnaktg()
        {
            baglan();
            command.CommandText = "INSERT INTO anakategori (anagrup) VALUES (@anagrup)";
            command.Parameters.AddWithValue("@anagrup", txtanaktg.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ana Kategori Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(anakod) FROM anakategori";
            txtanaid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncelleAnaktg()
        {
            baglan();
            command.CommandText = "UPDATE anakategori SET anagrup=@anagrup WHERE anakod=@anakod";
            command.Parameters.AddWithValue("@anagrup", txtanaktg.Text);
            command.Parameters.AddWithValue("@anakod", Convert.ToInt32(txtanaid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ana Kategori Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void KaydetAnaKtg()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM anakategori WHERE anakod=@anakod";
            command.Parameters.AddWithValue("@anakod", txtanaid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Ana Kategori Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelleAnaktg();
                }
                else
                {
                    MessageBox.Show("Ana Kategori Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekleAnaktg();
            }
        }


       
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtanaktg.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtanaktg.Text) == false)
                {
                    KaydetAnaKtg();
                }

                else
                {
                    MessageBox.Show("Ana Kategori Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtanaktg.Focus();
                    txtanaktg.SelectAll();
                }
            }

            else
            {
                MessageBox.Show("Ana Kategori Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanaktg.Focus();
            }
         }
       

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtanaid.Clear();
            txtanaktg.Clear();
            txtanaktg.Focus();
        }

        private void txtanaktg_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM anakategori WHERE anagrup LIKE @anagrup ORDER BY anakod";
            command.Parameters.AddWithValue("@anagrup", "%" + txtanaktg.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dganaktg.DataSource = tablo;
            conn.Close();
        }

        private void dganaktg_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM anakategori WHERE anakod=@anakod";
            command.Parameters.AddWithValue("@anakod", dganaktg.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtanaid.Text=tablo.Rows[0]["anakod"].ToString();
            txtanaktg.Text=tablo.Rows[0]["anagrup"].ToString();
            conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Ana Kategori Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "SELECT COUNT(*) FROM altkategori WHERE anakod=@anakod";
                command.Parameters.AddWithValue("@anakod", dganaktg.CurrentRow.Cells[0].Value.ToString());
                int count=Convert.ToInt32(command.ExecuteScalar());
                baglan();
                if(count<=0)
                {
                    command.CommandText = "DELETE FROM anakategori WHERE anakod=@anakod";
                    command.Parameters.AddWithValue("@anakod", Convert.ToInt32(dganaktg.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Ana Kategori Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ana Kategori Silme İşlemi İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Ana Kategori Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }
    }
}
