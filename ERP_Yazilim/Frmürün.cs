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
    public partial class Frmürün : Form
    {
        public Frmürün()
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
            command.CommandText = "SELECT urunkod,adi,marka,aciklama,satisfiyati,kdv,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod ORDER BY adi";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgurunler.DataSource = tablo;
            dgurunler.Columns["urunkod"].HeaderText = "Barkod";
            dgurunler.Columns["adi"].HeaderText = "Ürün Adı";
            dgurunler.Columns["marka"].HeaderText = "Marka";
            dgurunler.Columns["aciklama"].HeaderText = "Açıklama";
            dgurunler.Columns["satisfiyati"].HeaderText = "Satış Fiyatı";
            dgurunler.Columns["kdv"].HeaderText = "KDV";
            dgurunler.Columns["anagrup"].HeaderText = "Ana Kategori";
            dgurunler.Columns["altgrup"].HeaderText = "Alt Kategori";
            dgurunler.Columns["stok"].HeaderText = "Stok Sayısı";
            cmbAnaKtg.SelectedIndex = -1;
            cmbAltktg.SelectedIndex = -1;
            conn.Close();
        }


        void AnaktgDoldur()
        {
            baglan();
            command.CommandText = "SELECT * FROM anakategori";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbAnaKtg.DataSource = tablo;
            cmbAnaKtg.DisplayMember = "anagrup";
            cmbAnaKtg.ValueMember = "anakod";
            conn.Close();
        }


        void AltKtgDoldur()
        {
            try
            {
                baglan();
                command.CommandText = "SELECT * FROM altkategori WHERE anakod=@anakod";
                command.Parameters.AddWithValue("@anakod", cmbAnaKtg.SelectedValue);
                DataTable tablo = new DataTable();
                tablo.Load(command.ExecuteReader());
                cmbAltktg.DataSource = tablo;
                cmbAltktg.DisplayMember = "altgrup";
                cmbAltktg.ValueMember = "altkod";
                conn.Close();
            }
            catch { }
           
        }

        void ekleurun()
        {
            baglan();
            command.CommandText = "INSERT INTO urunler (urunkod,adi,marka,aciklama,satisfiyati,kdv,altkod,anakod,stok) VALUES (@urunkod,@adi,@marka,@aciklama,@satisfiyati,@kdv,@altkod,@anakod,@stok)";
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
            command.Parameters.AddWithValue("@adi", txturunadi.Text);
            command.Parameters.AddWithValue("@marka", txtmarka.Text);
            command.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
            command.Parameters.AddWithValue("@satisfiyati", txtsatisfiyati.Text);
            command.Parameters.AddWithValue("@kdv", txtkdv.Text);
            command.Parameters.AddWithValue("@altkod", cmbAltktg.SelectedValue);
            command.Parameters.AddWithValue("@anakod", cmbAnaKtg.SelectedValue);
            command.Parameters.AddWithValue("@stok", txtstokadedi.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listele();

            if (dosya.FileName != "")
            {
                baglan();
                command.CommandText = "INSERT INTO urunresim (urunkod,resimyol) VALUES (@urunkod,@resimyol)";
                command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
                command.Parameters.AddWithValue("@resimyol", dosya.FileName);
                command.ExecuteNonQuery();

                baglan();
                command.CommandText = "SELECT MAX(resimkod) FROM urunresim";
                txtresimkodu.Text = command.ExecuteScalar().ToString();
                conn.Close();
            }

            MessageBox.Show("Ürün Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void guncelleurun()
        {
            baglan();
            command.CommandText = "UPDATE urunler SET adi=@adi,marka=@marka,aciklama=@aciklama,satisfiyati=@satisfiyati,kdv=@kdv,altkod=@altkod,anakod=@anakod WHERE urunkod=@urunkod";
            command.Parameters.AddWithValue("@adi", txturunadi.Text);
            command.Parameters.AddWithValue("@marka", txtmarka.Text);
            command.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
            command.Parameters.AddWithValue("@satisfiyati", txtsatisfiyati.Text);
            command.Parameters.AddWithValue("@kdv", txtkdv.Text);
            command.Parameters.AddWithValue("@altkod", cmbAltktg.SelectedValue);
            command.Parameters.AddWithValue("@anakod", cmbAnaKtg.SelectedValue);
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listele();

            if(txtresimkodu.Text!="")
            {
                baglan();
                command.CommandText = "UPDATE urunresim SET urunkod=@urunkod,resimyol=@resimyol WHERE resimkod=@resimkod";
                command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
                command.Parameters.AddWithValue("@resimyol", dosya.FileName);
                command.Parameters.AddWithValue("@resimkod", txtresimkodu.Text);
                command.ExecuteNonQuery();
            }
            
            MessageBox.Show("Ürün Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void Kaydeturun()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM urunler WHERE urunkod=@urunkod";
            command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Ürün Kaydı Güncellenecektir.Bu Güncellemeden Diğer Bazı Kayıtlar Etkilenebilir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelleurun();
                }
                else
                {
                    MessageBox.Show("Ürün Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekleurun();
            }
        }

        private void Frmürün_Load(object sender, EventArgs e)
        {
            AnaktgDoldur();
            listele();
        }

       

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
                if (txtbarkod.Text != "")
                {
                    if(txturunadi.Text!="")
                    {
                        if(cmbAnaKtg.SelectedIndex!=-1)
                        {
                            if(cmbAltktg.SelectedIndex!=-1)
                            {
                                if(txtsatisfiyati.Text!="")
                                {
                                    if (FrmAnaktg.SayisalMi(txtsatisfiyati.Text) == true)
                                     {
                                         if(txtkdv.Text!="")
                                         {
                                             if (FrmAnaktg.SayisalMi(txtkdv.Text) == true)
                                             {
                                                 Kaydeturun();
                                             }
                                             else
                                             {
                                              MessageBox.Show("KDV Alanı Sayısal Değer Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                              txtkdv.Focus();
                                              txtkdv.SelectAll();
                                             }
                                         }
                                         else
                                         {
                                             MessageBox.Show("KDV Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                             txtkdv.Focus(); 
                                         }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Satış Fiyatı Sayısal Değer Olmalıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtsatisfiyati.Focus();
                                        txtsatisfiyati.SelectAll();
                                    }
                                 }
                                else
                                {
                                    MessageBox.Show("Satış Fiyatı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtsatisfiyati.Focus();
                                }
                                   
                             }
                            else
                            {
                                MessageBox.Show("Alt Kategori Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cmbAltktg.Focus();
                            }
                         }

                        else
                        {
                            MessageBox.Show("Ana Kategori Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmbAnaKtg.Focus();
                        }
                      }
                    else
                    {
                        MessageBox.Show("Ürün Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txturunadi.Focus();
                    }
                  }
                
                else
                {
                    MessageBox.Show("Ürün Barkod Alanı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbarkod.Focus();
                }
            }


        private void btnResimekle_Click(object sender, EventArgs e)
        {
            
            
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            pbResim.ImageLocation = dosya.FileName;
        }


        void filtreliara()
        {
            try
            {
                baglan();

                if (txtbarkod.Text != "" && txturunadi.Text != "")
                {
                    command.CommandText = "SELECT * FROM urunler WHERE urunkod LIKE @urunkod AND adi LIKE @adi ORDER BY urunkod";
                    command.Parameters.AddWithValue("@urunkod", "%" + txtbarkod.Text + "%");
                    command.Parameters.AddWithValue("@adi", "%" + txturunadi.Text + "%");
                }

                else if (txtbarkod.Text != "")
                {
                    command.CommandText = "SELECT * FROM urunler WHERE urunkod LIKE @urunkod ORDER BY urunkod";
                    command.Parameters.AddWithValue("@urunkod", "%" + txtbarkod.Text + "%");
                }

                else if (txturunadi.Text != "")
                {
                    command.CommandText = "SELECT * FROM urunler WHERE adi LIKE @adi ORDER BY urunkod";
                    command.Parameters.AddWithValue("@adi", "%" + txturunadi.Text + "%");
                }
                else { }

                DataTable tablo = new DataTable();
                tablo.Load(command.ExecuteReader());
                dgurunler.DataSource = tablo;
                conn.Close();
            }
            catch
            { }
           
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            filtreliara();
        }

        private void txturunadi_TextChanged(object sender, EventArgs e)
        {
            filtreliara();
        }

        private void dgurunler_DoubleClick(object sender, EventArgs e)
        {

            baglan();
            command.CommandText = "SELECT * FROM urunler WHERE urunkod=@urunkod";
            command.Parameters.AddWithValue("@urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtbarkod.Text = tablo.Rows[0]["urunkod"].ToString();
            txturunadi.Text = tablo.Rows[0]["adi"].ToString();
            txtmarka.Text = tablo.Rows[0]["marka"].ToString();
            txtaciklama.Text = tablo.Rows[0]["aciklama"].ToString();
            txtsatisfiyati.Text = tablo.Rows[0]["satisfiyati"].ToString();
            txtkdv.Text = tablo.Rows[0]["kdv"].ToString();
            cmbAnaKtg.Text = tablo.Rows[0]["anakod"].ToString();
            cmbAltktg.Text = tablo.Rows[0]["altkod"].ToString();
            txtstokadedi.Text = tablo.Rows[0]["stok"].ToString();
            conn.Close();

            try
            {
                baglan();
                command.CommandText = "SELECT TOP 1 resimyol FROM urunresim WHERE urunkod=@urunkod";
                command.Parameters.AddWithValue("@urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString());

                pbResim.ImageLocation = command.ExecuteScalar().ToString();

                conn.Close();
            }
            catch
            { }

            if (Frmsatis.durum == true)
            {
                Frmsatis.barkod = dgurunler.CurrentRow.Cells[0].Value.ToString();
                Frmsatis.urunadi = dgurunler.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            pbResim.ImageLocation = "";
            txtbarkod.Clear();
            txtaciklama.Clear();
            txtkdv.Clear();
            txtmarka.Clear();
            txtresimkodu.Clear();
            txtsatisfiyati.Clear();
            txtstokadedi.Clear();
            txturunadi.Clear();
            cmbAnaKtg.SelectedIndex = -1;
            cmbAltktg.SelectedIndex = -1;
            txtstokadedi.Text = "0";
            listele();
            txtbarkod.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Ürün Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if (frmilce.iliskikontrolü("sepet", "urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString()) != true)
                {
                    if (frmilce.iliskikontrolü("satis", "urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString()) != true)
                    {
                        if(frmilce.iliskikontrolü("iade","urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString()) != true)
                        {
                            if (frmilce.iliskikontrolü("altkategori", "urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString()) != true)
                            {
                                if (frmilce.iliskikontrolü("anakategori", "urunkod", dgurunler.CurrentRow.Cells[0].Value.ToString()) != true)
                                {
                                    command.CommandText = "DELETE FROM urunresim WHERE resimkod=@resimkod";
                                    command.Parameters.AddWithValue("@resimkod", txtresimkodu.Text);
                                    command.ExecuteNonQuery();
                                    conn.Close();

                                    baglan();
                                    command.CommandText = "DELETE FROM urunler WHERE urunkod=@urunkod";
                                    command.Parameters.AddWithValue("@urunkod", Convert.ToInt32(dgurunler.CurrentRow.Cells[0].Value.ToString()));
                                    command.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Ürün Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnyeni_Click(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ürün Silme İşlemi İptal Edildi.İlişkili Tablo: Ana Kategori", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ürün Silme İşlemi İptal Edildi.İlişkili Tablo: Alt Kategori", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ürün Silme İşlemi İptal Edildi.İlişkili Tablo: İade", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ürün Silme İşlemi İptal Edildi.İlişkili Tablo: Satış", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Ürün Silme İşlemi İptal Edildi.İlişkili Tablo: Sepet", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Ürün Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }

  

        private void cmbAnaKtg_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKtgDoldur();
        }

        private void dgurunler_Click(object sender, EventArgs e)
        {
            dgurunler_DoubleClick(sender, e);
        }



           
      }
    }

