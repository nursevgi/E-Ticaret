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
    public partial class Frmsatis : Form
    {
        public Frmsatis()
        {
            InitializeComponent();
        }

        static public string personeltc, personeladsoyad, mustc, musadsoyad, barkod, urunadi;
        static public bool durum = false;


        SqlCommand command = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        DataTable mussepet = new DataTable();

        public void baglan()
        {
            conn.Close();
            conn.ConnectionString = "server=.; Initial Catalog=erp;Integrated Security=SSPI";
            command.Connection = conn;
            command.Parameters.Clear();
            conn.Open();
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            personeltc = "";
            personeladsoyad = "";
            durum = true;
            Frmpersonel personel = new Frmpersonel();
            personel.ShowDialog();

            txtpersoneltc.Text = personeltc;
            txtpersoneladsoyad.Text = personeladsoyad;
            durum = false;
        }

        private void btnMara_Click(object sender, EventArgs e)
        {
            mustc = "";
            musadsoyad = "";

            durum = true;
            Frmmusteri musteri = new Frmmusteri();
            musteri.ShowDialog();

            txtmusteritc.Text = mustc;
            txtmusteriadsoyad.Text = musadsoyad;
            durum = false;
        }

        private void btnBara_Click(object sender, EventArgs e)
        {
            barkod = "";
            urunadi = "";
            durum = true;
            Frmürün urun = new Frmürün();
            urun.ShowDialog();

            txtbarkod.Text = barkod;
            txturunadi.Text = urunadi;
            durum = false;
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbarkod.Text != "")
                {
                    baglan();

                    command.CommandText = "SELECT COUNT(*) FROM urunler WHERE urunkod=@urunkod";
                    command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);

                    if (Convert.ToInt32(command.ExecuteScalar()) < 0)
                    {
                        txturunadi.Text = "Ürün Bulunamadı...";
                    }

                    else
                    {
                        baglan();
                        command.CommandText = "SELECT adi,satisfiyati FROM urunler WHERE urunkod=@urunkod";
                        command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);

                        DataTable tablo = new DataTable();
                        tablo.Load(command.ExecuteReader());

                        txturunadi.Text = tablo.Rows[0]["adi"].ToString();
                        txtsatisbirimfiyati.Text = tablo.Rows[0]["satisfiyati"].ToString();
                    }
                } 
            }
            catch { }
        }

        private void txtpersoneltc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtpersoneltc.Text != "")
                {
                    baglan();

                    command.CommandText = "SELECT COUNT(*) FROM calisan WHERE calisantc=@calisantc";
                    command.Parameters.AddWithValue("@calisantc", txtpersoneltc.Text);

                    if (Convert.ToInt32(command.ExecuteScalar()) < 0)
                    {
                        txtpersoneladsoyad.Text = "Personel Bulunamadı...";
                    }

                    else
                    {
                        baglan();
                        command.CommandText = "SELECT ad,soyad FROM calisan WHERE calisantc=@calisantc";
                        command.Parameters.AddWithValue("@calisantc", txtpersoneltc.Text);

                        DataTable tablo = new DataTable();
                        tablo.Load(command.ExecuteReader());

                        txtpersoneladsoyad.Text = tablo.Rows[0]["ad"].ToString() + " " + tablo.Rows[0]["soyad"].ToString();

                    }
                }
            }
            catch { }
            
        }

        private void txtmusteritc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtmusteritc.Text != "")
                {
                    baglan();

                    command.CommandText = "SELECT COUNT(*) FROM musteri WHERE mustc=@mustc";
                    command.Parameters.AddWithValue("@mustc", txtmusteritc.Text);

                    if (Convert.ToInt32(command.ExecuteScalar()) < 0)
                    {
                        txtmusteriadsoyad.Text = "Müşteri Bulunamadı...";
                    }

                    else
                    {
                        baglan();
                        command.CommandText = "SELECT ad,soyad FROM musteri WHERE mustc=@mustc";
                        command.Parameters.AddWithValue("@mustc", txtmusteritc.Text);

                        DataTable tablo = new DataTable();
                        tablo.Load(command.ExecuteReader());

                        txtmusteriadsoyad.Text = tablo.Rows[0]["ad"].ToString() + " " + tablo.Rows[0]["soyad"].ToString();

                    }
                }

            }

            catch { }

        }

        private void Frmsatis_Load(object sender, EventArgs e)
        {
            txtsatistarih.Text = DateTime.Today.ToString("d");
            mussepet.Columns.Add("Barkod", typeof(int));
            mussepet.Columns.Add("Ürün Adı", typeof(string));
            mussepet.Columns.Add("Adet", typeof(byte));
            mussepet.Columns.Add("Satış Fiyatı", typeof(int));
            mussepet.Columns.Add("Tarih", typeof(string));
            mussepet.Columns.Add("Müşteri TC Kimlik No", typeof(string));
            mussepet.Columns.Add("Personel TC Kimlik No", typeof(string));
        }

        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
            mussepet.Rows.Add(txtbarkod.Text,txturunadi.Text,numerikadet.Value,txtsatisbirimfiyati.Text,txtsatistarih.Text,txtpersoneltc.Text,txtmusteritc.Text);
            dgmusterisepet.DataSource=mussepet;

            lbltoplamtutar.Text=(Convert.ToInt32(lbltoplamtutar.Text)+Convert.ToInt32(numerikadet.Value)*Convert.ToInt32(txtsatisbirimfiyati.Text)).ToString();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM satis";
            int satisno = Convert.ToInt32(command.ExecuteScalar());

            txtsatisno.Text = Convert.ToString( satisno+ 1) ;
            txtbarkod.Clear();
            txtsatisbirimfiyati.Clear();
            txtfaturano.Clear();
            txturunadi.Clear();
            numerikadet.Value = 0;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT MAX(faturano) FROM satis";
            int sonfaturano = Convert.ToInt32(command.ExecuteScalar());
            txtfaturano.Text = (sonfaturano + 1).ToString();
            conn.Close();

            
            for (int i=0;i<mussepet.Rows.Count;i++)
            {
                baglan();
                command.CommandText = "INSERT INTO satis (faturano,urunkod,adet,satisfiyati,mustc,calisantc,satistarihi) VALUES (@faturano,@urunkod,@adet,@satisfiyati,@mustc,@calisantc,@satistarihi)";
                command.Parameters.AddWithValue("@faturano",txtfaturano.Text);
                command.Parameters.AddWithValue("@urunkod",mussepet.Rows[i][0]);
                command.Parameters.AddWithValue("@adet", mussepet.Rows[i][2]);
                command.Parameters.AddWithValue("@satisfiyati",mussepet.Rows[i][3]);
                command.Parameters.AddWithValue("@mustc", txtmusteritc.Text);
                command.Parameters.AddWithValue("@calisantc",txtpersoneltc.Text);
                command.Parameters.AddWithValue("@satistarihi", mussepet.Rows[i][4].ToString());
                command.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Ürün Satışı BAŞARILI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnfatura_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Yapım Aşamasında...");
        }
    }
}