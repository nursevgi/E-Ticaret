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
    public partial class Frmkargo : Form
    {
        public Frmkargo()
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
            command.CommandText = "SELECT * FROM kargo ORDER BY kargoadi";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgkargolar.DataSource = tablo;
            dgkargolar.Columns["kargono"].Visible = false;
            dgkargolar.Columns["kargoadi"].HeaderText = "KARGO ADI";
            dgkargolar.Columns["sube"].HeaderText = "ŞUBE";
            dgkargolar.Columns["adres"].HeaderText = "ADRES";
            conn.Close();
        }

        private void Frmkargo_Load(object sender, EventArgs e)
        {
            listele();
        }

        void eklekargo()
        {
            baglan();
            command.CommandText = "INSERT INTO kargo (kargoadi,sube,adres) VALUES (@kargoadi,@sube,@adres)";
            command.Parameters.AddWithValue("@kargoadi", txtkargoadi.Text);
            command.Parameters.AddWithValue("@sube", txtsube.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kargo Firması Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(kargono) FROM kargo";
            txtkargoid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncellekargo()
        {
            baglan();
            command.CommandText = "UPDATE kargo SET kargoadi=@kargoadi,sube=@sube,adres=@adres WHERE kargono=@kargono";
            command.Parameters.AddWithValue("@kargoadi", txtkargoadi.Text);
            command.Parameters.AddWithValue("@sube", txtsube.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.Parameters.AddWithValue("@kargono", Convert.ToInt32(txtkargoid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kargo Firması Bilgileri Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void Kaydetkargo()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM kargo WHERE kargono=@kargono";
            command.Parameters.AddWithValue("@kargono", txtkargoid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Kargo Firmasına Ait Kayıt Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncellekargo();
                }
                else
                {
                    MessageBox.Show("Kargo Firması Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                eklekargo();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkargoadi.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtkargoadi.Text) == false)
                {
                    if (txtsube.Text != "")
                    {
                        if (FrmAnaktg.SayisalMi(txtsube.Text) == false)
                        {
                            Kaydetkargo();
                        }

                        else
                        {
                            MessageBox.Show("Şube Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtsube.Focus();
                            txtsube.SelectAll();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Şube Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtsube.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Kargo Firması Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtkargoadi.Focus();
                    txtkargoadi.SelectAll();
                }
            }

            else
            {
                MessageBox.Show("Kargo Firması Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkargoadi.Focus();
            }
        }

        void temizle()
        {
            txtkargoadi.Clear();
            txtsube.Clear();
            txtadres.Clear();
            txtkargoid.Clear();
            txtkargoadi.Focus();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtkargoadi_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM kargo WHERE kargoadi LIKE @kargoadi ORDER BY kargono";
            command.Parameters.AddWithValue("@kargoadi", "%" + txtkargoadi.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgkargolar.DataSource = tablo;
            conn.Close();
        }

        private void dgkargolar_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM kargo WHERE kargono=@kargono";
            command.Parameters.AddWithValue("@kargono", dgkargolar.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtkargoid.Text = tablo.Rows[0]["kargono"].ToString();
            txtkargoadi.Text = tablo.Rows[0]["kargoadi"].ToString();
            txtsube.Text = tablo.Rows[0]["sube"].ToString();
            txtadres.Text = tablo.Rows[0]["adres"].ToString();
            conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Frmilce ilce = new Frmilce();
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Kargo Firması Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                
                if (ilce.iliskikontrolü("siparisler","kargono",dgkargolar.CurrentRow.Cells[0].Value.ToString()) != true)
                {
                    command.CommandText = "DELETE FROM kargo WHERE kargono=@kargono";
                    command.Parameters.AddWithValue("@kargono", Convert.ToInt32(dgkargolar.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kargo Firması Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Kargo Firması Silme İşlemi İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Kargo Firması Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
            temizle();
        }



    }
}
