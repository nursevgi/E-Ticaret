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


namespace ERP_Yazilim
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

       

        private void altmenuUrunler_Click(object sender, EventArgs e)
        {
            Frmürün frmurun = new Frmürün();
            frmurun.ShowDialog();
        }

        private void altmenuAnaktg_Click(object sender, EventArgs e)
        {
            FrmAnaktg frmanaktg = new FrmAnaktg();
            frmanaktg.ShowDialog();
        }

        private void altmenuAltktg_Click(object sender, EventArgs e)
        {
            FrmAltktg frmaltktg = new FrmAltktg();
            frmaltktg.ShowDialog();
        }

        private void altmenuDepartman_Click(object sender, EventArgs e)
        {
            Frmdepartman frmdepartman = new Frmdepartman();
            frmdepartman.ShowDialog();
        }

        private void altmenuKargo_Click(object sender, EventArgs e)
        {
            Frmkargo frmkargo = new Frmkargo();
            frmkargo.ShowDialog();
        }

        private void altmenuSiparisdurum_Click(object sender, EventArgs e)
        {
            Frmsiparisdurum frmsiparisdurum = new Frmsiparisdurum();
            frmsiparisdurum.ShowDialog();
        }

        private void altmenuIller_Click(object sender, EventArgs e)
        {
            Frmil frmil = new Frmil();
            frmil.ShowDialog();
        }

        private void altmenuIlceler_Click(object sender, EventArgs e)
        {
            Frmilce frmilce = new Frmilce();
            frmilce.ShowDialog();
        }

        private void altmenuAlis_Click(object sender, EventArgs e)
        {
            Frmalis frmalis = new Frmalis();
            frmalis.ShowDialog();
        }

        private void altmenuSatis_Click(object sender, EventArgs e)
        {
            Frmsatis frmsatis = new Frmsatis();
            frmsatis.ShowDialog();
        }

        private void altmenuIade_Click(object sender, EventArgs e)
        {
            Frmiade frmiade = new Frmiade();
            frmiade.ShowDialog();
        }

        private void altmenuStok_Click(object sender, EventArgs e)
        {
            Frmstok frmstok = new Frmstok();
            frmstok.ShowDialog();
        }

        private void altmenuSiparis_Click(object sender, EventArgs e)
        {
            Frmsiparis frmsiparis = new Frmsiparis();
            frmsiparis.ShowDialog();
        }

        private void altmenuMusteri_Click(object sender, EventArgs e)
        {
            Frmmusteri frmmusteri = new Frmmusteri();
            frmmusteri.ShowDialog();
        }

        private void altmenuPersonel_Click(object sender, EventArgs e)
        {
            Frmpersonel frmpersonel = new Frmpersonel();
            frmpersonel.ShowDialog();
        }

        private void altmenuSifre_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Yapım Aşamasında...");
            //Frmsifre frmsifre = new Frmsifre();
            //frmsifre.ShowDialog();
        }

        private void altmenuSorgurapor_Click(object sender, EventArgs e)
        {


            Frmsorgurapor frmsorgurapor = new Frmsorgurapor();
            frmsorgurapor.ShowDialog();
        }

        private void altmenuVtyedekle_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Yapım Aşamasında...");
           //DialogResult cevap=MessageBox.Show("Veritabanı Yedekleme İşlemi Başlatılacaktır.İşlemi Onaylıyor Musunuz?", "VT YEDEKLEME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
           //if(cevap==DialogResult.Yes)
           //{
           //    //Veritabanı Yedekleme Kodları Yazılacak
           //    MessageBox.Show("Yedekleme İşlemi Kodlama");
           //}
        }

        private void anamenuCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Program Kapatılacaktır.İşlemi Onaylıyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void btnürün_Click(object sender, EventArgs e)
        {
            altmenuUrunler_Click(sender,e);
        }

        private void btnanaktg_Click(object sender, EventArgs e)
        {
            altmenuAnaktg_Click(sender, e);
        }

        private void btnaltktg_Click(object sender, EventArgs e)
        {
            altmenuAltktg_Click(sender, e);
        }

        private void btndepartman_Click(object sender, EventArgs e)
        {
            altmenuDepartman_Click(sender, e);
        }

        private void btnkargo_Click(object sender, EventArgs e)
        {
            altmenuKargo_Click(sender, e);
        }

        private void btnsiparisdurum_Click(object sender, EventArgs e)
        {
            altmenuSiparisdurum_Click(sender, e);
        }

        private void btnil_Click(object sender, EventArgs e)
        {
            altmenuIller_Click(sender, e);
        }

        private void btnilce_Click(object sender, EventArgs e)
        {
            altmenuIlceler_Click(sender, e);
        }

        private void btnalis_Click(object sender, EventArgs e)
        {
            altmenuAlis_Click(sender, e);
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            altmenuSatis_Click(sender, e);
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            altmenuIade_Click(sender, e);
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            altmenuStok_Click(sender, e);
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            altmenuSiparis_Click(sender, e);
        }

        private void btnmüsteri_Click(object sender, EventArgs e)
        {
            altmenuMusteri_Click(sender, e);
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            altmenuPersonel_Click(sender, e);
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {
            altmenuSifre_Click(sender, e);
        }

        private void btnsorgurapor_Click(object sender, EventArgs e)
        {
           altmenuSorgurapor_Click(sender, e);
        }

        private void btnvtyedekle_Click(object sender, EventArgs e)
        {
            altmenuVtyedekle_Click(sender, e);
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            anamenuCikis_Click(sender, e);
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
