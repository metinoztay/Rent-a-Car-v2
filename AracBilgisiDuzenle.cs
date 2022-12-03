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
    public partial class frm_AracBilgisiDuzenle : Form
    {
        public frm_AracBilgisiDuzenle()
        {
            InitializeComponent();
        }

        private void AracBilgisiDuzenle_Load(object sender, EventArgs e)
        {
            cbx_Araclar.Items.Clear();
            string[] aracBilgileri;
            string[] araclar;
            string plaka, marka, model, tip, yakit, vites, uygunluk;
            StreamReader AracListesi = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
            araclar = AracListesi.ReadToEnd().Split('\n');
            foreach (var arac in araclar)
            {
                if (arac == "\r")
                {
                    break;
                }

                aracBilgileri = arac.Split('#');

                if (aracBilgileri[0]=="")
                {
                    break;
                }

                plaka = aracBilgileri[0];
                marka = aracBilgileri[1];
                model = aracBilgileri[2];
                tip = aracBilgileri[3];
                yakit = aracBilgileri[4];
                vites = aracBilgileri[5];
                uygunluk = aracBilgileri[8];
                cbx_Araclar.Items.Add(plaka + " - " + marka + " - " + model + " - " + tip + " - " + yakit + " - " + vites + " - " + uygunluk);
            }
            
            AracListesi.Close();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            anaMenu.ShowDialog();
        }

        private void cbx_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aracNo = cbx_Araclar.SelectedIndex;
            string[] aracBilgileri;
            string[] araclar;
            StreamReader aracBilgisiOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
            araclar = aracBilgisiOku.ReadToEnd().Split('\n');

            aracBilgileri = araclar[aracNo].Split('#');

            txt_plaka.Text = aracBilgileri[0];
            txt_marka.Text = aracBilgileri[1];
            txt_model.Text = aracBilgileri[2];
            cbx_tip.SelectedItem = aracBilgileri[3];
            cbx_yakit.SelectedItem = aracBilgileri[4];
            cbx_vites.SelectedItem = aracBilgileri[5];
            mtxt_sigorta.Text=aracBilgileri[6];
            mtxt_kasko.Text=aracBilgileri[7];
            cbx_uygunluk.SelectedItem=aracBilgileri[8];
            aracBilgisiOku.Close();

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            int aracNo = 0;            
            string[] araclar;
            string[] gecici;
            StreamReader aracOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
            araclar = aracOku.ReadToEnd().Split('\n');
            aracOku.Close();
            
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt", string.Empty);
            StreamWriter aracYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt", true);
            foreach (var arac in araclar)
            {
                if (arac=="")
                {
                    break;
                }

                if (aracNo != cbx_Araclar.SelectedIndex)
                {
                    gecici = arac.Split("\r");
                    aracYaz.WriteLine(gecici[0]);    
                }
                else
                {
                    aracYaz.WriteLine(
                    txt_plaka.Text.Trim() + "#" +
                    txt_marka.Text.Trim() + "#" +
                    txt_model.Text.Trim() + "#" +
                    cbx_tip.SelectedItem.ToString() + "#" +
                    cbx_yakit.SelectedItem.ToString() + "#" +
                    cbx_vites.SelectedItem.ToString() + "#" +
                    mtxt_sigorta.Text.Trim() + "#" +
                    mtxt_kasko.Text.Trim() + "#" +
                    cbx_uygunluk.SelectedItem.ToString() +"#"
                    );
                    
                }
                
                aracNo++;
            }
            aracYaz.Close();
            MessageBox.Show("Arac Bilgileri Başarı İle Değiştirildi.", "İşlem Başarılı");
            AracBilgisiDuzenle_Load(sender, e);
            

        }

        private void frm_AracBilgisiDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
