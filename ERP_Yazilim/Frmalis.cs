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
            command.CommandText = "SELECT alis.urunkod,adi,adet,alisfiyati,alistarihi FROM alis,urunler WHERE urunler.urunkod=alis.urunkod ORDER BY alistarihi DESC";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgalinanurunler.DataSource = tablo;
            dgalinanurunler.Columns["urunkod"].HeaderText = "Barkod";
            dgalinanurunler.Columns["adi"].HeaderText = "Ürün Adı";
            dgalinanurunler.Columns["adet"].HeaderText = "Adet";
            dgalinanurunler.Columns["alisfiyati"].HeaderText = "Ürün Birim Alım Fiyatı";
            dgalinanurunler.Columns["alistarihi"].HeaderText = "Ürün Alım Tarihi";
            conn.Close();
        }


        void eklealinanurun()
        {
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
            command.Parameters.AddWithValue("@alistarihi", txtalistarihi.Text);
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
            txtalistarihi.Text=Convert.ToString(DateTime.Today);
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
                                    validasyon=true;
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


            //Barkod VT kayıtlı mı kontrolü ekle

            baglan();
            command.CommandText = "SELECT adi FROM urunler WHERE urunkod=@urunkod";
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
            txturunadi.Text = command.ExecuteScalar().ToString();
            conn.Close();
     
            if(validasyon==true)
            {
                Kaydetalis();
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
        }

        private void Frmalis_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        private void dgalinanurunler_DoubleClick(object sender, EventArgs e)
        {
            //Kaydı aktar kodu ekle
        }




        }
    }

