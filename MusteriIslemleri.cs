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
    public partial class frm_MusteriIslemleri : Form
    {
        public frm_MusteriIslemleri()
        {
            InitializeComponent();
        }

        private void frm_MusteriIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            txt_isimSoyisim.Text = String.Empty;            
            mtxt_telefon.Text = String.Empty;
            list_Kiralar.Items.Clear();
            list_Odemeler.Items.Clear();
            txt_Kira.Text=String.Empty;
            txt_Borc.Text=String.Empty;
            txt_Odenen.Text=String.Empty;
            mtxt_odenenTutar.Text=String.Empty;

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
                    txt_isimSoyisim.Text = musteriBilgileri[1] + " "+musteriBilgileri[2];             
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
                string[] kiralar;
                string[] kiraBilgileri;
                int toplamBorc = 0;

                StreamReader kiraGecmisi = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\AracTeslim.txt");
                kiralar = kiraGecmisi.ReadToEnd().Split("\n");
                kiraGecmisi.Close();
                foreach (var kira in kiralar)
                {
                    if (kira == "")
                    {
                        break;
                    }

                    kiraBilgileri = kira.Split("#");
                    if (mtxt_TC.Text == kiraBilgileri[0])
                    {
                        string[] lstkira = { kiraBilgileri[1], kiraBilgileri[2], kiraBilgileri[4], kiraBilgileri[6] + " ₺" };
                        ListViewItem kiraSatir = new ListViewItem(lstkira);
                        list_Kiralar.Items.Add(kiraSatir);
                        toplamBorc += int.Parse(kiraBilgileri[6]);
                    }
                }

                
                txt_Kira.Text = toplamBorc.ToString() +" ₺";
                

                string[] odemeler;
                string[] odemeBilgileri;
                
                int toplamOdenen=0;
                StreamReader odemeGecmisi = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Odemeler.txt");
                odemeler=odemeGecmisi.ReadToEnd().Split("\n");
                odemeGecmisi.Close();
                foreach (var odeme in odemeler)
                {
                    if (odeme=="")
                    {
                        break;
                    }
                    odemeBilgileri=odeme.Split("#");
                    if (mtxt_TC.Text==odemeBilgileri[0])
                    {
                        string[] lstodenen = { odemeBilgileri[1], odemeBilgileri[2]+" ₺"};
                        ListViewItem odemeSatir = new ListViewItem(lstodenen);
                        list_Odemeler.Items.Add(odemeSatir);
                        toplamOdenen += int.Parse(odemeBilgileri[2]);
                    }

                }

                txt_Odenen.Text = toplamOdenen.ToString() +" ₺";
                txt_Borc.Text= (toplamBorc-toplamOdenen).ToString() + " ₺";

            }




        }

        private void btn_odemeAl_Click(object sender, EventArgs e)
        {
            if (txt_isimSoyisim.Text==string.Empty)
            {
                MessageBox.Show("Musteri bilgisi girilmeden ödeme alınamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mtxt_odenenTutar.Text.Trim()!=String.Empty)
            {
                StreamWriter odemeAl = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Odemeler.txt", true);
                odemeAl.WriteLine(
                    mtxt_TC.Text + "#" +
                    dtp_odemeTarihi.Text + "#" +
                    mtxt_odenenTutar.Text + "#"
                    );
                odemeAl.Close();

                MessageBox.Show("Ödeme işlemi tamamlandı.", "Ödeme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Ara_Click(sender, e);
            }
            
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }
    }
}
