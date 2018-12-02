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
    public partial class FrmAltktg : Form
    {
        public FrmAltktg()
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
            command.CommandText = "SELECT altkod,altgrup,anagrup FROM altkategori,anakategori WHERE anakategori.anakod=altkategori.anakod ORDER BY altgrup";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgAltktg.DataSource = tablo;
            dgAltktg.Columns["altkod"].Visible = false;
            dgAltktg.Columns["altgrup"].HeaderText = "ALT KATEGORİ";
            dgAltktg.Columns["anagrup"].HeaderText = "ANA KATEGORİ";
            conn.Close();
        }


        void AnaKtgDoldur()
        {
            baglan();
            command.CommandText = "SELECT * FROM anakategori";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbAnaktg.DataSource = tablo;
            cmbAnaktg.DisplayMember = "anagrup";
            cmbAnaktg.ValueMember = "anakod";
            conn.Close();
        }

        void ekleAltktg()
        {
            baglan();
            command.CommandText = "INSERT INTO altkategori (altgrup,anakod) VALUES (@altgrup,@anakod)";
            command.Parameters.AddWithValue("@altgrup", txtAltktg.Text);
            command.Parameters.AddWithValue("@anakod", cmbAnaktg.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Alt Kategori Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(altkod) FROM altkategori";
            txtaltid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncelleAltktg()
        {
            baglan();
            command.CommandText = "UPDATE altkategori SET altgrup=@altgrup,anakod=@anakod WHERE altkod=@altkod";
            command.Parameters.AddWithValue("@altgrup", txtAltktg.Text);
            command.Parameters.AddWithValue("@anakod", cmbAnaktg.SelectedValue);
            command.Parameters.AddWithValue("@altkod", Convert.ToInt32(txtaltid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Alt Kategori Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }


        void KaydetAltKtg()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM altkategori WHERE altkod=@altkod";
            command.Parameters.AddWithValue("@altkod", txtaltid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Alt Kategori Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelleAltktg();
                }
                else
                {
                    MessageBox.Show("Alt Kategori Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekleAltktg();
            }
        }

       

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (cmbAnaktg.SelectedIndex!=-1)
            {
               if(txtAltktg.Text!="")
               {
                   if(FrmAnaktg.SayisalMi(txtAltktg.Text)==false)
                   {
                       KaydetAltKtg();
                   }

                   else
                   {
                       MessageBox.Show("Alt Kategori Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       txtAltktg.Focus();
                       txtAltktg.SelectAll();
                   }
               }

               else
               {
                   MessageBox.Show("Alt Kategori Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txtAltktg.Focus();
               }
            }
            else
            {
                MessageBox.Show("Lütfen Ana Kategori Adı Seçimi Yapınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAnaktg.Focus();
            }
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtaltid.Clear();
            txtAltktg.Clear();
            cmbAnaktg.SelectedIndex = -1;
            cmbAnaktg.Focus();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Alt Kategori Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "SELECT COUNT(*) FROM urunler WHERE altkod=@altkod";
                command.Parameters.AddWithValue("@altkod", dgAltktg.CurrentRow.Cells[0].Value.ToString());
                int count = Convert.ToInt32(command.ExecuteScalar());
                baglan();
                if (count <= 0)
                {
                    command.CommandText = "DELETE FROM altkategori WHERE altkod=@altkod";
                    command.Parameters.AddWithValue("@altkod", Convert.ToInt32(dgAltktg.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alt Kategori Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ana Kategori Silme İşlemi İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Alt Kategori Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }

        private void FrmAltktg_Load(object sender, EventArgs e)
        {
            listele();
            AnaKtgDoldur();
        }

        private void txtAltktg_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM altkategori WHERE altgrup LIKE @altgrup ORDER BY altkod";
            command.Parameters.AddWithValue("@altgrup", "%" + txtAltktg.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgAltktg.DataSource = tablo;
            conn.Close();
        }

        private void dgAltktg_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM altkategori WHERE altkod=@altkod";
            command.Parameters.AddWithValue("@anakod", dgAltktg.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtaltid.Text = tablo.Rows[0]["altkod"].ToString();
            txtAltktg.Text = tablo.Rows[0]["altgrup"].ToString();
            cmbAnaktg.Text = tablo.Rows[0]["anakod"].ToString();
            conn.Close();
        }

       

    }
}
