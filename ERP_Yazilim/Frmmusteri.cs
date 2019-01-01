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
using System.Text.RegularExpressions;

namespace ERP_Yazilim
{
    public partial class Frmmusteri : Form
    {
        public Frmmusteri()
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

        void listeleMusteri()
        {
            baglan();
            command.CommandText = "SELECT mustc,ad,soyad,tel,eposta,adres,il,ilce,kayittarihi FROM musteri,iller,ilceler WHERE iller.ilkod=musteri.ilkod AND ilceler.ilcekod=musteri.ilcekod ORDER BY ad";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgmusteri.DataSource = tablo;
            dgmusteri.Columns["mustc"].HeaderText = "TC Kimlik No";
            dgmusteri.Columns["ad"].HeaderText = "Ad";
            dgmusteri.Columns["soyad"].HeaderText = "Soyad";
            dgmusteri.Columns["tel"].HeaderText = "Tel No";
            dgmusteri.Columns["eposta"].HeaderText = "E-Psota";
            dgmusteri.Columns["adres"].HeaderText = "Adres";
            dgmusteri.Columns["il"].HeaderText = "İl";
            dgmusteri.Columns["ilce"].HeaderText = "İlçe";
            dgmusteri.Columns["kayittarihi"].HeaderText = "Kayıt Tarihi";
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


        void ilceDoldur()
        {
            try
            {
                baglan();
                command.CommandText = "SELECT * FROM ilceler WHERE ilkod=@ilkod";
                command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
                DataTable tablo = new DataTable();
                tablo.Load(command.ExecuteReader());
                cmbilce.DataSource = tablo;
                cmbilce.DisplayMember = "ilce";
                cmbilce.ValueMember = "ilcekod";
                conn.Close();
            }
            catch { }
        }

        private void Frmmusteri_Load(object sender, EventArgs e)
        {
            txtkayittarihi.Text = DateTime.Today.ToString("d");

            listeleMusteri();
            ilDoldur();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceDoldur();
        }

        void eklemusteri()
        {
            baglan();
            command.CommandText = "INSERT INTO musteri (mustc,ad,soyad,tel,adres,ilkod,ilcekod,eposta,kayittarihi) VALUES (@mustc,@ad,@soyad,@tel,@adres,@ilkod,@ilcekod,@eposta,@kayittarihi)";
            command.Parameters.AddWithValue("@mustc", txtTC.Text);
            command.Parameters.AddWithValue("@ad", txtad.Text);
            command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            command.Parameters.AddWithValue("@tel", mtxttel.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.Parameters.AddWithValue("@ilcekod", cmbilce.SelectedValue);
            command.Parameters.AddWithValue("@eposta", txteposta.Text);
            command.Parameters.AddWithValue("@kayittarihi",txtkayittarihi.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listeleMusteri();
            MessageBox.Show("Müşteri Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void guncellemusteri()
        {
            baglan();
            command.CommandText = "UPDATE musteri SET ad=@ad,soyad=@soyad,tel=@tel,adres=@adres,ilkod=@ilkod,ilcekod=@ilcekod,eposta=@eposta,kayittarihi=@kayittarihi WHERE mustc=@mustc";
            command.Parameters.AddWithValue("@ad", txtad.Text);
            command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            command.Parameters.AddWithValue("@tel", mtxttel.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.Parameters.AddWithValue("@ilcekod", cmbilce.SelectedValue);
            command.Parameters.AddWithValue("@eposta", txteposta.Text);
            command.Parameters.AddWithValue("@kayittarihi", txtkayittarihi.Text);
            command.Parameters.AddWithValue("@mustc", txtTC.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listeleMusteri();
            MessageBox.Show("Müşteri Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        void Kaydetmusteri()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM musteri WHERE mustc=@mustc";
            command.Parameters.AddWithValue("@mustc", txtTC.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Müşteri Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncellemusteri();
                }
                else
                {
                    MessageBox.Show("Müşteri Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listeleMusteri();
                }
            }
            else
            {
                eklemusteri();
            }
        }


        public static bool MailKontrolu(string mail)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(mail, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
         
            if (txtTC.Text != "")
            { 
                if(FrmAnaktg.SayisalMi(txtTC.Text) == true)
                {
                   if(txtad.Text!="")
                   {
                       if(txtsoyad.Text!="")
                       {
                           if(mtxttel.Text!="")
                           {
                               if(txteposta.Text!="")
                               {
                                   if(MailKontrolu(txteposta.Text))
                                   {
                                       Kaydetmusteri();
                                   }
                                   else
                                   {
                                       MessageBox.Show("Lütfen Geçerli Bir E-Posta Adresi Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                       txteposta.Focus();
                                   }
                               }
                               else
                               {
                                   MessageBox.Show("E-Posta Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                   txteposta.Focus();
                               }
                           }
                           else
                           {
                               MessageBox.Show("Tel No Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               mtxttel.Focus();
                           }
                       }
                       else
                       {
                           MessageBox.Show("Müşteri Soyadı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           txtsoyad.Focus();
                       }
                   }
                   else
                   {
                       MessageBox.Show("Müşteri Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       txtad.Focus();
                   }
                }
                else
                {
                    MessageBox.Show("TC Kimlik No, Sayısal Değer Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTC.Focus();
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik No Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTC.Focus();
            } 
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT mustc,ad,soyad,tel,eposta,adres,il,ilce,kayittarihi FROM musteri,iller,ilceler WHERE iller.ilkod=musteri.ilkod AND ilceler.ilcekod=musteri.ilcekod AND mustc=@mustc ORDER BY ad";
            command.Parameters.AddWithValue("@mustc", "%" + txtTC.Text + "%");
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgmusteri.DataSource = tablo;
            conn.Close();
        }

        private void dgmusteri_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT mustc,ad,soyad,tel,eposta,adres,il,ilce,kayittarihi FROM musteri,iller,ilceler WHERE iller.ilkod=musteri.ilkod AND ilceler.ilcekod=musteri.ilcekod AND mustc=@mustc ORDER BY ad";
            command.Parameters.AddWithValue("@mustc", dgmusteri.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtTC.Text = tablo.Rows[0]["mustc"].ToString();
            txtad.Text = tablo.Rows[0]["ad"].ToString();
            txtsoyad.Text = tablo.Rows[0]["soyad"].ToString();
            mtxttel.Text = tablo.Rows[0]["tel"].ToString();
            txteposta.Text = tablo.Rows[0]["eposta"].ToString();
            txtadres.Text = tablo.Rows[0]["adres"].ToString();
            cmbil.Text = tablo.Rows[0]["il"].ToString();
            cmbilce.Text = tablo.Rows[0]["ilce"].ToString();
            txtkayittarihi.Text = tablo.Rows[0]["kayittarihi"].ToString();
            conn.Close();
        }


        void temizle()
        {
            txtad.Clear();
            txtadres.Clear();
            txteposta.Clear();
            txtkayittarihi.Text = DateTime.Today.ToString("d");
            txtsoyad.Clear();
            txtTC.Clear();
            mtxttel.Clear();
            cmbilce.SelectedIndex = -1;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            DialogResult cevap = MessageBox.Show("Seçilen Müşteri Kaydı ve İlgili Müşteriye Bağlı Diğer Tüm Kayıtlar Da Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "DELETE FROM satis WHERE mustc=@mustc";
                command.Parameters.AddWithValue("@mustc", dgmusteri.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                conn.Close();

                baglan();
                command.CommandText = "DELETE FROM iade WHERE mustc=@mustc";
                command.Parameters.AddWithValue("@mustc",dgmusteri.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                conn.Close();

                baglan();
                command.CommandText = "DELETE FROM musteri WHERE mustc=@mustc";
                command.Parameters.AddWithValue("@mustc", dgmusteri.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteriye Ait Tüm Bilgiler Kalıcı Bir Şekilde Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Müşteri Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listeleMusteri();

        }
    }
}
