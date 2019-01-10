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
    public partial class Frmiade : Form
    {
        public Frmiade()
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

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtbarkod.Clear();
            txtfaturano.Clear();
            txtiadenedeni.Clear();
            txtiadetarih.Text = DateTime.Today.ToString("d");
            txtpersoneltc.Clear();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(txtbarkod.Text!="" && txtfaturano.Text!="")
            {
                baglan();
                command.CommandText = "SELECT * FROM iade WHERE faturano=@faturano AND urunkod=@urunkod";
                command.Parameters.AddWithValue("@faturano", txtfaturano.Text);
                command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);

                if(Convert.ToInt32(command.ExecuteScalar())<0)
                {
                    MessageBox.Show("Girilen Bilgilere Ait Ürün Satışı Bulunamadı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baglan();
                    command.CommandText = "INSERT INTO iade (faturano,urunkod,iadetarihi,neden,adet,calisantc) VALUES (@faturano,@urunkod,@iadetarihi,@neden,@adet,@calisantc)";
                    command.Parameters.AddWithValue("@faturano", txtfaturano.Text);
                    command.Parameters.AddWithValue("@urunkod", txtbarkod.Text);
                    command.Parameters.AddWithValue("@iadetarihi", txtiadetarih.Text);
                    command.Parameters.AddWithValue("@neden", txtiadenedeni.Text);
                    command.Parameters.AddWithValue("@adet", numerikadet.Value);
                    command.Parameters.AddWithValue("@calisantc", txtpersoneltc.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("İade Alma İşlemi BAŞARILI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }

        private void Frmiade_Load(object sender, EventArgs e)
        {
            btnyeni_Click(sender, e);
        }

       
       


       

    }
}
