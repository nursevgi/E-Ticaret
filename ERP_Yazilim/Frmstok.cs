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
    public partial class Frmstok : Form
    {
        public Frmstok()
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


        void renklendir()
        {
            
            for (int i = 0; i < dgstoklar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dgstoklar.Rows[i].Cells["stok"].Value)>0 && (Convert.ToInt32(dgstoklar.Rows[i].Cells["stok"].Value) <= 10))
                {
                    renk.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(dgstoklar.Rows[i].Cells["stok"].Value)>100)
                {
                    renk.BackColor = Color.GreenYellow;
                }
                else if (Convert.ToInt32(dgstoklar.Rows[i].Cells["stok"].Value) ==0)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else { }
                dgstoklar.Rows[i].DefaultCellStyle = renk;
            }
        }
        private void Frmstok_Load(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT urunkod,adi,marka,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod ORDER BY stok";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgstoklar.DataSource = tablo;
            dgstoklar.Columns["urunkod"].HeaderText = "Barkod";
            dgstoklar.Columns["adi"].HeaderText = "Ürün Adı";
            dgstoklar.Columns["marka"].HeaderText = "Marka";
            dgstoklar.Columns["anagrup"].HeaderText = "Ana Kategori";
            dgstoklar.Columns["altgrup"].HeaderText = "Alt Kategori";
            dgstoklar.Columns["stok"].HeaderText = "Stok Sayısı";
            conn.Close();

            renklendir();
        
        }

        private void txtaranan_TextChanged(object sender, EventArgs e)
        {
           
               try
              {
                baglan();

                if (rburunadi.Checked)
                {
                    command.CommandText = "SELECT urunkod,adi,marka,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND adi LIKE @adi ORDER BY stok";
                    command.Parameters.AddWithValue("@adi", "%" + txtaranan.Text + "%");
                }

                else if (rbadet.Checked)
                {
                    command.CommandText = "SELECT urunkod,adi,marka,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND stok LIKE @stok ORDER BY stok";
                    command.Parameters.AddWithValue("@stok", "%" + txtaranan.Text + "%");
                }

                else if (rbmarka.Checked)
                {
                    command.CommandText = "SELECT urunkod,adi,marka,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND marka LIKE @marka ORDER BY stok";
                    command.Parameters.AddWithValue("@marka", "%" + txtaranan.Text + "%");
                }

                else if (rbbarkod.Checked)
                {
                    command.CommandText = "SELECT urunkod,adi,marka,anagrup,altgrup,stok FROM urunler,anakategori,altkategori WHERE anakategori.anakod=urunler.anakod AND altkategori.altkod=urunler.altkod AND urunkod LIKE @barkod ORDER BY stok";
                    command.Parameters.AddWithValue("@barkod", "%" + txtaranan.Text + "%");
                }

                else { }

           }
               catch { } 
          
            
                DataTable tablo = new DataTable();
                tablo.Load(command.ExecuteReader());
                dgstoklar.DataSource = tablo;
                conn.Close();
                renklendir();
            }
            
        }
    }

