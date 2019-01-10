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
    public partial class Frmpersonel : Form
    {
        public Frmpersonel()
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

        void listelePersonel()
        {
            baglan();
            command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod ORDER BY ad";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgpersonel.DataSource = tablo;
            dgpersonel.Columns["calisantc"].HeaderText = "TC Kimlik No";
            dgpersonel.Columns["ad"].HeaderText = "Ad";
            dgpersonel.Columns["soyad"].HeaderText = "Soyad";
            dgpersonel.Columns["tel"].HeaderText = "Tel No";
            dgpersonel.Columns["eposta"].HeaderText = "E-Psota";
            dgpersonel.Columns["adres"].HeaderText = "Adres";
            dgpersonel.Columns["il"].HeaderText = "İl";
            dgpersonel.Columns["ilce"].HeaderText = "İlçe";
            dgpersonel.Columns["depadi"].HeaderText = "Departman";
            dgpersonel.Columns["isbastarih"].HeaderText = "Başlangıç Tarihi";
            dgpersonel.Columns["sifre"].Visible = false;
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


        void DepDoldur()
        {
            baglan();
            command.CommandText = "SELECT * FROM departman";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            cmbdep.DataSource = tablo;
            cmbdep.DisplayMember = "depadi";
            cmbdep.ValueMember = "depkod";
            conn.Close();
        }

        private void Frmpersonel_Load(object sender, EventArgs e)
        {
            temizle();
            listelePersonel();
            ilDoldur();
            DepDoldur();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceDoldur();
        }





        void eklepersonel()
        {
            baglan();
            command.CommandText = "INSERT INTO calisan (calisantc,ad,soyad,tel,eposta,adres,ilkod,ilcekod,depkod,isbastarih,sifre) VALUES (@calisantc,@ad,@soyad,@tel,@eposta,@adres,@ilkod,@ilcekod,@depkod,@isbastarih,@sifre)";
            command.Parameters.AddWithValue("@calisantc", txtTC.Text);
            command.Parameters.AddWithValue("@ad", txtad.Text);
            command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            command.Parameters.AddWithValue("@tel", mtxttel.Text);
            command.Parameters.AddWithValue("@eposta", txteposta.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.Parameters.AddWithValue("@ilcekod", cmbilce.SelectedValue);
            command.Parameters.AddWithValue("@depkod", cmbdep.SelectedValue);
            command.Parameters.AddWithValue("@isbastarih", txtbastarih.Text);
            command.Parameters.AddWithValue("@sifre", txtsifre.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listelePersonel();
            MessageBox.Show("Personel Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void guncellepersonel()
        {
            baglan();
            command.CommandText = "UPDATE calisan SET ad=@ad,soyad=@soyad,tel=@tel,eposta=@eposta,adres=@adres,ilkod=@ilkod,ilcekod=@ilcekod,depkod=@depkod,isbastarih=@isbastarih,sifre=@sifre WHERE calisantc=@calisantc";
            command.Parameters.AddWithValue("@ad", txtad.Text);
            command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            command.Parameters.AddWithValue("@tel", mtxttel.Text);
            command.Parameters.AddWithValue("@eposta", txteposta.Text);
            command.Parameters.AddWithValue("@adres", txtadres.Text);
            command.Parameters.AddWithValue("@ilkod", cmbil.SelectedValue);
            command.Parameters.AddWithValue("@ilcekod", cmbilce.SelectedValue);
            command.Parameters.AddWithValue("@depkod", cmbdep.SelectedValue);
            command.Parameters.AddWithValue("@isbastarihi", txtbastarih.Text);
            command.Parameters.AddWithValue("@sifre", txtsifre.Text);
            command.Parameters.AddWithValue("@calisantc", txtTC.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listelePersonel();
            MessageBox.Show("Personel Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void Kaydetpersonel()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM calisan WHERE calisantc=@calisantc";
            command.Parameters.AddWithValue("@calisantc", txtTC.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Personel Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncellepersonel();
                }
                else
                {
                    MessageBox.Show("Personel Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listelePersonel();
                }
            }
            else
            {
                eklepersonel();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            
            if (txtTC.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtTC.Text) == true)
                {
                    if (txtad.Text != "")
                    {
                        if (txtsoyad.Text != "")
                        {
                            if (mtxttel.Text != "")
                            {
                                if (txteposta.Text != "")
                                {
                                    if (Frmmusteri.MailKontrolu(txteposta.Text)==true)
                                    {
                                        if(cmbdep.SelectedIndex!=-1)
                                        {
                                            Kaydetpersonel();
                                            btnsifre.Enabled = true;
                                            btnmail.Enabled = true;
                                            txtsifre.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Departman Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            cmbdep.Focus();
                                        }
                                        
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
                            MessageBox.Show("Personel Soyadı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtsoyad.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod AND calisantc LIKE @calisantc ORDER BY ad";
            command.Parameters.AddWithValue("@calisantc", "%" + txtTC.Text + "%");
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgpersonel.DataSource = tablo;
            dgpersonel.Columns["sifre"].Visible = false;
            conn.Close();
        }

        private void dgpersonel_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod AND calisantc=@calisantc ORDER BY ad";
            command.Parameters.AddWithValue("@calisantc",dgpersonel.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtTC.Text = tablo.Rows[0]["calisantc"].ToString();
            txtad.Text = tablo.Rows[0]["ad"].ToString();
            txtsoyad.Text = tablo.Rows[0]["soyad"].ToString();
            mtxttel.Text = tablo.Rows[0]["tel"].ToString();
            txteposta.Text = tablo.Rows[0]["eposta"].ToString();
            txtadres.Text = tablo.Rows[0]["adres"].ToString();
            cmbil.Text = tablo.Rows[0]["il"].ToString();
            cmbilce.Text = tablo.Rows[0]["ilce"].ToString();
            cmbdep.Text = tablo.Rows[0]["depadi"].ToString();
            txtbastarih.Text = tablo.Rows[0]["isbastarih"].ToString();
            txtsifre.Text = tablo.Rows[0]["sifre"].ToString();
            conn.Close();

            if (Frmsatis.durum == true)
            {
                Frmsatis.personeltc = dgpersonel.CurrentRow.Cells[0].Value.ToString();
                Frmsatis.personeladsoyad = dgpersonel.CurrentRow.Cells[1].Value.ToString() + " " + dgpersonel.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
        }

        void temizle()
        {
            txtad.Clear();
            txtadres.Clear();
            txteposta.Clear();
            txtbastarih.Text = DateTime.Today.ToString("d");
            txtsoyad.Clear();
            txtTC.Clear();
            mtxttel.Clear();
            cmbilce.SelectedIndex = -1;
            cmbdep.SelectedIndex = -1;
            txtsifre.Clear();
            txtsifre.Enabled = false;
            btnmail.Enabled = false;
            btnsifre.Enabled = false;
            txtTC.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Personel Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                baglan();
                command.CommandText = "SELECT COUNT(*) FROM satis WHERE calisantc=@calisantc";
                command.Parameters.AddWithValue("@calisantc", dgpersonel.CurrentRow.Cells[0].Value.ToString());
                int count = Convert.ToInt32(command.ExecuteScalar());
              
                if (count>0)
                {
                    
                    baglan();
                    command.CommandText = "SELECT COUNT(*) FROM iade WHERE calisantc=@calisantc";
                    command.Parameters.AddWithValue("@calisantc", dgpersonel.CurrentRow.Cells[0].Value.ToString());
                    int count1 = Convert.ToInt32(command.ExecuteScalar());

                    if(count1<=0)
                    {
                        baglan();
                        command.CommandText = "DELETE FROM personel WHERE calisantc=@calisantc";
                        command.Parameters.AddWithValue("@calisantc", Convert.ToInt32(dgpersonel.CurrentRow.Cells[0].Value.ToString()));
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Personel Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Personel Silme İşlemi İptal Edildi.İlişkili Tablo: İade", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                }

                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Personel Silme İşlemi İptal Edildi.İlişkili Tablo: Satış", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Personel Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listelePersonel();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {

            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                int ascii = rastgele.Next(32, 127);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);

            }
            txtsifre.Text=sb.ToString();
            MessageBox.Show(txtsifre.Text.ToString());

            guncellepersonel();
        }

        private void btnmail_Click(object sender, EventArgs e)
        {
            //Mail Gönderme Kodu Yazılacak !!!!!!!
            MessageBox.Show("Yapım Aşamasında...");
        }

       


       
    }
}
