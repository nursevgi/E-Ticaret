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
    public partial class Frmalis : Form
    {
        public Frmalis()
        {
            InitializeComponent();
        }

        SqlCommand command = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        OpenFileDialog dosya = new OpenFileDialog();
        Frmilce frmilce = new Frmilce();


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
            command.CommandText = "SELECT alisno,alis.urunkod,adi,adet,alisfiyati,alistarihi FROM alis,urunler WHERE urunler.urunkod=alis.urunkod ORDER BY alistarihi DESC";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgalinanurunler.DataSource = tablo;
            dgalinanurunler.Columns["urunkod"].HeaderText = "Barkod";
            dgalinanurunler.Columns["adi"].HeaderText = "Ürün Adı";
            dgalinanurunler.Columns["adet"].HeaderText = "Adet";
            dgalinanurunler.Columns["alisfiyati"].HeaderText = "Ürün Birim Alım Fiyatı";
            dgalinanurunler.Columns["alistarihi"].HeaderText = "Ürün Alım Tarihi";
            dgalinanurunler.Columns["alisno"].Visible=false;
            conn.Close();
        }


        void eklealinanurun()
        {
            txtalistarihi.Text = Convert.ToString(DateTime.Today);
            baglan();
            command.CommandText = "INSERT INTO alis (urunkod,adet,alisfiyati,alistarihi) VALUES (@urunkod,@adet,@alisfiyati,@alistarihi)";
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
            command.Parameters.AddWithValue("@adet", numerikadet.Value);
            command.Parameters.AddWithValue("@alisfiyati", txtalisbirimfiyati.Text);
            command.Parameters.AddWithValue("@alistarihi", Convert.ToDateTime(txtalistarihi.Text));
            command.ExecuteNonQuery();
            conn.Close();


            baglan();
            command.CommandText = "SELECT MAX(alisno) FROM alis";
            txtalisid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();

            MessageBox.Show("Ürün Alım Kaydı Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void guncellealinanurun()
        {
            baglan();
            command.CommandText = "UPDATE alis SET urunkod=@urunkod,adet=@adet,alisfiyati=@alisfiyati,alistarihi=@alistarihi WHERE alisno=@alisno";
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
            command.Parameters.AddWithValue("@adet", numerikadet.Value);
            command.Parameters.AddWithValue("@alisfiyati", txtalisbirimfiyati.Text);
            command.Parameters.AddWithValue("@alistarihi", Convert.ToDateTime(txtalistarihi.Text));
            command.Parameters.AddWithValue("@alisno", txtalisid.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listele();

            MessageBox.Show("Ürün Alım Kaydı Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void Kaydetalis()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM alis WHERE alisno=@alisno";
            command.Parameters.AddWithValue("@alisno", txtalisid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Ürün Alım Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncellealinanurun();
                }
                else
                {
                    MessageBox.Show("Ürün Alım Kaydı Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                eklealinanurun();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            bool validasyon=false;
             if(txtbarkod.Text!="")
             {
                 if(FrmAnaktg.SayisalMi(txtbarkod.Text)==true)
                 {
                     if(numerikadet.Value>0)
                         {
                             if(txtalisbirimfiyati.Text!="")
                             {
                                if (FrmAnaktg.SayisalMi(txtalisbirimfiyati.Text) == true)
                                {
                                    Kaydetalis();
                                }
                                else
                                {
                                    MessageBox.Show("Alış Birim Fiyatı Sayısal Değer Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtalisbirimfiyati.Focus();
                                    txtalisbirimfiyati.SelectAll();
                                }
                             }
                             else
                             {
                                  MessageBox.Show("Alış Birim Fiyatı Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                  txtalisbirimfiyati.Focus();
                             }
                         }
                     else
                     {
                         MessageBox.Show("Adet Alanı 0'dan Büyük Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                  }
                 else
                 {
                    MessageBox.Show("Barkod Sayısal Değer Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbarkod.Focus();
                    txtbarkod.SelectAll();
                 }
              }
             else
             {
                
                MessageBox.Show("Barkod Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbarkod.Focus();
             }

         }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtalisid.Clear();
            txtalisbirimfiyati.Clear();
            txtalistarihi.Clear();
            txtbarkod.Clear();
            txturunadi.Clear();
            numerikadet.Value=0;
            txtbarkod.Focus();
            txtbarkod.Enabled = true;
        }

        private void Frmalis_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        private void dgalinanurunler_DoubleClick(object sender, EventArgs e)
        {
            txtbarkod.Enabled = false;
            baglan();
            command.CommandText = "SELECT alisno,alis.urunkod,adi,adet,alisfiyati,alistarihi FROM alis,urunler WHERE urunler.urunkod=alis.urunkod AND alisno=@alisno";
            command.Parameters.AddWithValue("@alisno", dgalinanurunler.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtalisid.Text = tablo.Rows[0]["alisno"].ToString();
            txtbarkod.Text = tablo.Rows[0]["urunkod"].ToString();
            txturunadi.Text = tablo.Rows[0]["adi"].ToString();
            numerikadet.Value = Convert.ToInt32(tablo.Rows[0]["adet"]);
            txtalisbirimfiyati.Text = tablo.Rows[0]["alisfiyati"].ToString();
            txtalistarihi.Text = tablo.Rows[0]["alistarihi"].ToString();
            conn.Close();
        }



        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Seçilen Stok Girişi Kaydı Silinecektir.Bu İşlem Stok Sayısını Değiştirebilir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "DELETE FROM alis WHERE alisno=@alisno";
                command.Parameters.AddWithValue("@alisno", Convert.ToInt32(dgalinanurunler.CurrentRow.Cells[0].Value.ToString()));
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Stok Girişi Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnyeni_Click(sender, e);
                listele();
            }
            else
                MessageBox.Show("Stok Girişi Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

     

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglan();
                command.CommandText = "SELECT COUNT(*) FROM urunler WHERE urunkod=@urunkod";
                command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);


                int ks = Convert.ToInt32(command.ExecuteScalar());
                if (ks <= 0)
                {
                    txturunadi.Text = "Barkod Kaydı Bulunamadı";
                    conn.Close();
                }
                else
                {
                    baglan();
                    command.CommandText = "SELECT adi FROM urunler WHERE urunkod=@urunkod";
                    command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
                    txturunadi.Text = command.ExecuteScalar().ToString();

                }
            }
            catch { }
            
        }

       



        }
    }

