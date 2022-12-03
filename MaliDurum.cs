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
    public partial class frm_MaliDurum : Form
    {
        public string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"};
        public int[] aylikOdemeler = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0};
        public frm_MaliDurum()
        {
            InitializeComponent();
        }

        private void MaliDurum_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();           
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            string[] odemeler;
            string[] odemeBilgileri;
            string[] odemeDetay;
           
            StreamReader maliDurum = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+@"Kaynaklar\Odemeler.txt");
            odemeler = maliDurum.ReadToEnd().Split("\n");
            maliDurum.Close();
            foreach (var odeme in odemeler)
            {
                if (odeme == "")
                {
                    break;
                }

                odemeBilgileri = odeme.Split("#");
                odemeDetay = odemeBilgileri[1].Split(" ");
                if (odemeDetay[2]==mtxt_Yil.Text)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (odemeDetay[1]==aylar[i])
                        {
                            aylikOdemeler[i] += int.Parse(odemeBilgileri[2]);
                        }

                    }
                }
            }

            if (int.Parse(mtxt_Yil.Text.Trim())>=2000)
            {
                int toplam = 0;
                list_MaliDurum.Items.Clear();
                for (int i = 0; i < 12; i++)
                {
                    toplam += aylikOdemeler[i];
                    string[] lstSatir = { aylar[i], aylikOdemeler[i].ToString() };
                    ListViewItem satir = new ListViewItem(lstSatir);
                    list_MaliDurum.Items.Add(satir);
                }
                
                string[] toplam2 = { "Toplam" , toplam.ToString()};
                ListViewItem satir2 = new ListViewItem(toplam2);
                list_MaliDurum.Items.Add(satir2);

            }
            
        }

        private void frm_MaliDurum_Load(object sender, EventArgs e)
        {
            string[] ucretler;
            string[] ucretBilgisi;
            StreamReader fiyatOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Ucretler.txt");
            ucretler = fiyatOku.ReadToEnd().Split("\n");
            fiyatOku.Close();
            foreach (var ucret in ucretler)
            {
                if (ucret=="")
                {
                    break;
                }
                ucretBilgisi = ucret.Split("#");
                switch (ucretBilgisi[0])
                {
                    case "EKO": 
                        mtxt_eko.Text = ucretBilgisi[1];
                        break;
                    case "LUX": 
                        mtxt_lux.Text = ucretBilgisi[1];
                        break;
                    case "PRO":
                        mtxt_pro.Text = ucretBilgisi[1];
                        break;
                    case "VİP":
                        mtxt_vip.Text = ucretBilgisi[1];
                        break;
                    default:
                        break;
                }

            }
        }

        private void btn_FiyatBelirle_Click(object sender, EventArgs e)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Ucretler.txt",string.Empty);
            StreamWriter fiyatBelirle = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Ucretler.txt",true);
            fiyatBelirle.WriteLine(
                "EKO" + "#" + mtxt_eko.Text + "#\n" +
                "LUX" + "#" + mtxt_lux.Text + "#\n" +
                "PRO" + "#" + mtxt_pro.Text + "#\n" +
                "VİP" + "#" + mtxt_vip.Text + "#"
                );
            fiyatBelirle.Close();

            MessageBox.Show("Yeni fiyatlar sisteme kaydedildi.","Fiyatlandırma Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }
    }
}
