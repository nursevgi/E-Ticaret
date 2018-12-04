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
    public partial class Frmdepartman : Form
    {
        public Frmdepartman()
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
            command.CommandText = "SELECT * FROM departman ORDER BY depadi";
            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgdep.DataSource = tablo;
            dgdep.Columns["depkod"].Visible = false;
            dgdep.Columns["depadi"].HeaderText = "DEPARTMAN";
            conn.Close();
        }

        private void Frmdepartman_Load(object sender, EventArgs e)
        {
            listele();
        }


        void ekledep()
        {
            baglan();
            command.CommandText = "INSERT INTO departman (depadi) VALUES (@depadi)";
            command.Parameters.AddWithValue("@depadi", txtdepadi.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Departman Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            baglan();
            command.CommandText = "SELECT MAX(depkod) FROM departman";
            txtdepid.Text = command.ExecuteScalar().ToString();
            conn.Close();
            listele();
        }

        void guncelledep()
        {
            baglan();
            command.CommandText = "UPDATE departman SET depadi=@depadi WHERE depkod=@depkod";
            command.Parameters.AddWithValue("@depadi", txtdepadi.Text);
            command.Parameters.AddWithValue("@depkod", Convert.ToInt32(txtdepid.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Departman Başarıyla Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void Kaydetdep()
        {
            baglan();
            command.CommandText = "SELECT COUNT(*) FROM departman WHERE depkod=@depkod";
            command.Parameters.AddWithValue("@depkod", txtdepid.Text);

            int sayi = Convert.ToInt32(command.ExecuteScalar());

            if (sayi > 0)
            {
                DialogResult cevap = MessageBox.Show("Departman Kaydı Güncellenecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    guncelledep();
                }
                else
                {
                    MessageBox.Show("Departman Güncelleme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            else
            {
                ekledep();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtdepadi.Text != "")
            {
                if (FrmAnaktg.SayisalMi(txtdepadi.Text) == false)
                {
                    Kaydetdep();
                }

                else
                {
                    MessageBox.Show("Departman Adı Sayısal Değer Olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdepadi.Focus();
                    txtdepadi.SelectAll();
                }
            }

            else
            {
                MessageBox.Show("Departman Adı Boş Geçilemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdepadi.Focus();
            }
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtdepid.Clear();
            txtdepadi.Clear();
            txtdepadi.Focus();
        }

        private void txtdepadi_TextChanged(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM departman WHERE depadi LIKE @depadi ORDER BY depkod";
            command.Parameters.AddWithValue("@depadi", "%" + txtdepadi.Text + "%");

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());
            dgdep.DataSource = tablo;
            conn.Close();
        }

        private void dgdep_DoubleClick(object sender, EventArgs e)
        {
            baglan();
            command.CommandText = "SELECT * FROM departman WHERE depkod=@depkod";
            command.Parameters.AddWithValue("@depkod", dgdep.CurrentRow.Cells[0].Value.ToString());

            DataTable tablo = new DataTable();
            tablo.Load(command.ExecuteReader());

            txtdepid.Text = tablo.Rows[0]["depkod"].ToString();
            txtdepadi.Text = tablo.Rows[0]["depadi"].ToString();
            conn.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Frmilce ilce = new Frmilce();
            baglan();
            DialogResult cevap = MessageBox.Show("Seçilen Departman Kaydı Silinecektir.İşleme Devam Etmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if (ilce.iliskikontrolü("calisan", "depkod", dgdep.CurrentRow.Cells[0].Value.ToString()) != true)
                {
                    command.CommandText = "DELETE FROM departman WHERE depkod=@depkod";
                    command.Parameters.AddWithValue("@depkod", Convert.ToInt32(dgdep.CurrentRow.Cells[0].Value.ToString()));
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Departman Silme İşlemi Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinmek İstenen Kayıtla İlişkili Kayıtlar Bulunmaktadır.Departman Silme İşlemi İptal Edildi.İlişikili Kayıtların Bulunduğu Yer:Personel", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Departman Silme İşlemi İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listele();
        }


    }
}
