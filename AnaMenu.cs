using System.IO;

namespace RentACar2
{
    public partial class frm_AnaMenu : Form
    {
        public frm_AnaMenu()
        {
            InitializeComponent();
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AracEkle aracEkle = new frm_AracEkle();
            aracEkle.ShowDialog();
           
        }

        private void frm_AnaMenu_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\");   
           
        }

        private void btn_AracListesi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AracListesi aracListesi = new frm_AracListesi();
            aracListesi.ShowDialog();
        }

        private void btn_AracBilgisiDuzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AracBilgisiDuzenle aracBilgisiDuzenle = new frm_AracBilgisiDuzenle();
            aracBilgisiDuzenle.ShowDialog();
        }

        private void btn_AracCikar_Click(object sender, EventArgs e)
        {
            frm_AracCikar aracCikar = new frm_AracCikar();
            this.Hide();
            aracCikar.ShowDialog();
        }

        private void btn_AracTeslimEt_Click(object sender, EventArgs e)
        {
            frm_AracTeslimEt aracTeslimEt = new frm_AracTeslimEt();
            this.Hide();
            aracTeslimEt.ShowDialog();
        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            frm_Rezervasyon rezervasyon = new frm_Rezervasyon();
            this.Hide();
            rezervasyon.ShowDialog();
        }

        private void btn_AracTeslimAl_Click(object sender, EventArgs e)
        {
            frm_AracTeslimAl aracTeslimAl = new frm_AracTeslimAl();
            this.Hide();
            aracTeslimAl.ShowDialog();
        }

        private void btn_MaliIslemler_Click(object sender, EventArgs e)
        {
            frm_MaliIslemler maliIslemler = new frm_MaliIslemler();
            this.Hide();
            maliIslemler.ShowDialog();      

        }
    }
}