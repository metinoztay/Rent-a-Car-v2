using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar2
{
    public partial class frm_AracTeslimAl : Form
    {
        
        public frm_AracTeslimAl()
        {
            InitializeComponent();
        }

        private void frm_AracTeslimAl_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }

        private void btn_TeslimAl_Click(object sender, EventArgs e)
        {
            string plaka = "";
            if (txt_isimSoyisim.Text == string.Empty)
            {
                MessageBox.Show("Musteri Bilgisi Girilmeden Araç Teslimi Yapılamaz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach (ListViewItem arac in list_Araclar.SelectedItems)
            {
                plaka = arac.SubItems[0].Text;
            }

            if (plaka == "")
            {
                MessageBox.Show("Teslim Alınan Aracı Seçiniz", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult secim = MessageBox.Show("Aracın Teslim Alındığını Onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim==DialogResult.Yes)
            {
                secim = MessageBox.Show("Aracta Hasar Var mı?", "Kontrol", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim==DialogResult.Yes)
                {
                    frm_HasarGiris hasarGiris = new frm_HasarGiris();
                    hasarGiris.ShowDialog();
                    StreamReader hasarOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Hasar.txt");
                    string[] hasar = hasarOku.ReadToEnd().Split("\r");
                    hasarOku.Close();


                    StreamWriter hasarEkle = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\AracTeslim.txt", true);
                    hasarEkle.WriteLine(
                        mtxt_TC.Text + "#" +
                        plaka + "#" +
                        "Hasar" + "#" +
                        "00:00" + "#" +
                        "Hasar" + "#" +
                        "00:00" + "#" +
                        hasar[0] + "#"
                        );
                    hasarEkle.Close();
                }
              
                
                frm_AracSecTeslim aracSecTeslim = new frm_AracSecTeslim();
                aracSecTeslim.aracUygunlukDegistir(plaka, "UYGUN");
                MessageBox.Show("Aracın Teslim Alınması Tamamlandı","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_AnaMenu anaMenu = new frm_AnaMenu();
                this.Hide();
                anaMenu.ShowDialog();
                
            }       
        }

        private void frm_AracTeslimAl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            txt_isimSoyisim.Text = String.Empty;          
            mtxt_telefon.Text = String.Empty;
            bool varMi = false;
            string[] musteriler;
            string[] musteriBilgileri;
            StreamReader musteriAra = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt");
            musteriler = musteriAra.ReadToEnd().Split('\n');
            musteriAra.Close();
            foreach (var musteri in musteriler)
            {
                if (musteri == "")
                {
                    break;
                }
                musteriBilgileri = musteri.Split('#');

                if (mtxt_TC.Text == musteriBilgileri[0])
                {
                    txt_isimSoyisim.Text = musteriBilgileri[1]+" " +musteriBilgileri[2];                     
                    mtxt_telefon.Text = musteriBilgileri[3];
                    varMi = true;
                    break;
                }

            }

            if (!varMi)
            {
                MessageBox.Show("Müşteri Bilgisi Bulunamadi.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string plaka = "", marka = "", model = "", tip = "", yakit = "", vites = "", uygunluk = "";

                string[] aracBilgileri;
                string[] araclar;
                StreamReader aracListesi = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
                araclar = aracListesi.ReadToEnd().Split("\n");

                foreach (var arac in araclar)
                {
                    if (arac == "")
                    {
                        break;
                    }
                    aracBilgileri = arac.Split("#");
                    plaka = aracBilgileri[0];
                    marka = aracBilgileri[1];
                    model = aracBilgileri[2];
                    tip = aracBilgileri[3];
                    yakit = aracBilgileri[4];
                    vites = aracBilgileri[5];
                    uygunluk = aracBilgileri[8];

                    if (uygunluk != "UYGUN")
                    {
                        string[] satir = { plaka, marka, model, tip, uygunluk };
                        ListViewItem lst = new ListViewItem(satir);
                        list_Araclar.Items.Add(lst);
                    }
                }

                aracListesi.Close();
            }
        }
    }
}
