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
    public partial class Frmsorgurapor : Form
    {
        public Frmsorgurapor()
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

        private void cmbSorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            baglan();

            if (cmbSorgu.SelectedIndex == 0)   //Tüm ürünler
            {
                txtdeger.Enabled = false;
                command.CommandText = "SELECT urunkod,adi,marka,aciklama,satisfiyati,kdv,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod ORDER BY adi";
            }

           else  if (cmbSorgu.SelectedIndex == 1) //Markaya Göre Ürünler
            {   try
                {
                    lblbaslik.Text = "Marka Giriniz:";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT urunkod,adi,marka,aciklama,satisfiyati,kdv,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND marka LIKE @marka ORDER BY marka";
                    command.Parameters.AddWithValue("@marka", "%" + txtdeger.Text + "%");
                }
                catch
                { }
                
            }

           else  if (cmbSorgu.SelectedIndex == 2) //Anakategoriye Göre Ürünler
            {
                try
                {
                    lblbaslik.Text = "Ana Kategori Giriniz:";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT urunkod,adi,marka,aciklama,satisfiyati,kdv,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND anagrup LIKE @anagrup ORDER BY anagrup";
                    command.Parameters.AddWithValue("@anagrup", "%"+txtdeger.Text+"%");
                }
                catch
                { }

            }

           else  if (cmbSorgu.SelectedIndex == 3) //Altkategoriye Göre Ürünler
            {
                try
                {
                    lblbaslik.Text = "Alt Kategori Giriniz:";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT urunkod,adi,marka,aciklama,satisfiyati,kdv,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND altgrup LIKE @altgrup ORDER BY altgrup";
                    command.Parameters.AddWithValue("@altgrup", "%" + txtdeger.Text + "%");
                }
                catch
                { }

            }

            else if (cmbSorgu.SelectedIndex == 4) //Tüm Personeller
            {
                try
                {
                    txtdeger.Enabled = false;
                    command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod ORDER BY ad";
                }
                catch
                { }

            }

            else if (cmbSorgu.SelectedIndex == 5) //Departmana Göre  Personeller
            {
                try
                {
                    lblbaslik.Text = "Departman Giriniz:";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod AND depadi LIKE @depadi ORDER BY depadi";
                    command.Parameters.AddWithValue("@depadi", "%" + txtdeger.Text + "%");
                }
                catch
                { }

            }

            else if (cmbSorgu.SelectedIndex == 6) //Aya  Göre  İşe Başlayan Personeller
            {
                try
                {
                    lblbaslik.Text = "Ay Giriniz: (1-12)";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod AND isbastarih LIKE @isbastarih ORDER BY isbastarih";
                    command.Parameters.AddWithValue("@isbastarih", "%"+txtdeger.Text + "%");
                }
                catch
                { }

            }

            else if (cmbSorgu.SelectedIndex == 7) //İllere  Göre  Personeller
            {
                try
                {
                    lblbaslik.Text = "İl Giriniz:";
                    txtdeger.Enabled = true;
                    command.CommandText = "SELECT calisantc,ad,soyad,tel,eposta,adres,il,ilce,depadi,isbastarih,sifre FROM calisan,iller,ilceler,departman WHERE iller.ilkod=calisan.ilkod AND ilceler.ilcekod=calisan.ilcekod AND departman.depkod=calisan.depkod AND il LIKE @il ORDER BY il";
                    command.Parameters.AddWithValue("@il", "%" + txtdeger.Text + "%");
                }
                catch
                { }

            }

            else if (cmbSorgu.SelectedIndex == 8) //2 Tarih Arasındaki Satışlar
            {
                try
                {
                    txtbastarih.Enabled = true;
                    txtbittarih.Enabled = true;
                    txtdeger.Enabled = false;
                    command.CommandText = "SELECT satis.urunkod,adi,adet,satis.satisfiyati,satistarihi FROM urunler,satis WHERE urunler.urunkod=satis.urunkod AND satistarihi>=@satbastarih AND satistarihi<=@satbittarih ORDER BY satistarihi";
                    command.Parameters.AddWithValue("@satbastarih", txtbastarih.Text);
                    command.Parameters.AddWithValue("@satbittarih", txtbittarih.Text);
                }
                catch
                { }

            }

           else
            {
               
            }

                DataTable sonuclar = new DataTable();
                sonuclar.Load(command.ExecuteReader());
                dgsonuc.DataSource = sonuclar;
            }
    
           
        }
    }

