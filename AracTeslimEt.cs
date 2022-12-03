using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RentACar2
{
    public partial class frm_AracTeslimEt : Form
    {
        public frm_AracTeslimEt()
        {
            InitializeComponent();
        }

        private void btn_Onay_Click(object sender, EventArgs e)
        {
            int kosulSayisi = lst_kosullar.CheckedItems.Count;

            if (kosulSayisi == 4)
            {
                grp_Musteri.Visible = true;
                grp_tarih.Visible = true;
                lst_kosullar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tüm koşulları sağlamayan müşterilere araç teslimi yapılamaz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void frm_AracTeslimEt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            txt_isim.Text = String.Empty;
            txt_soyisim.Text = String.Empty;
            mtxt_telefon.Text = String.Empty;
            bool varMi=false;
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
                    txt_isim.Text = musteriBilgileri[1];
                    txt_soyisim.Text = musteriBilgileri[2];
                    mtxt_telefon.Text = musteriBilgileri[3];
                    varMi=true;
                    break;
                }

            }

            if (!varMi)
            {
                MessageBox.Show("Müşteri Bilgisi Bulunamadi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void frm_AracTeslimEt_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt"))
            {
                FileStream olustur = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt");
                olustur.Close();
            }
            
            dtp_kiraTarihi.MinDate= DateTime.Now;
        }

        private void btn_DevamEt_Click(object sender, EventArgs e)
        {
            string[] musteriler;
            string[] musteriBilgileri;
            string[] gecici;
            bool var=false;
            
            if (mtxt_TC.Text.Trim() != "" && txt_isim.Text.TrimEnd() != "" && txt_soyisim.Text.Trim() != "" && mtxt_telefon.Text != "(   )    -")
            {
                StreamReader musteriOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt");
                musteriler = musteriOku.ReadToEnd().Split("\n");
                musteriOku.Close();

                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt", String.Empty);
                StreamWriter musteriYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt", true);
                foreach (var musteri in musteriler)
                {
                    if (musteri == "")
                    {
                        break;
                    }
                    musteriBilgileri = musteri.Split("#");

                    if (mtxt_TC.Text == musteriBilgileri[0])
                    {
                        var = true; 
                        musteriYaz.WriteLine(
                            mtxt_TC.Text.Trim() + "#" +
                            txt_isim.Text.TrimEnd() + "#" +
                            txt_soyisim.Text.Trim() + "#" +
                            mtxt_telefon.Text + "#"
                            );                        
                    }
                    else
                    {
                        gecici = musteri.Split('\r');
                        musteriYaz.WriteLine(gecici[0]);
                    }

                }
                if (!var)
                {
                    musteriYaz.WriteLine(
                            mtxt_TC.Text.Trim() + "#" +
                            txt_isim.Text.TrimEnd() + "#" +
                            txt_soyisim.Text.Trim() + "#" +
                            mtxt_telefon.Text + "#"
                            );
                }
                musteriYaz.Close();
                grp_Musteri.Enabled = false;
                grp_tarih.Enabled = true;
            }
            else
            {
                MessageBox.Show("Müşteri Bilgileri Boş Bırakılamaz.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }   
        }

        private void btn_devamEt2_Click(object sender, EventArgs e)
        {
            if (mtxt_kiraSaati.Text != "  :" && mtxt_teslimSaati.Text != "  :")
            {
                frm_AracSecTeslim aracSecTeslim = new frm_AracSecTeslim();
                aracSecTeslim.musteriTC = mtxt_TC.Text.Trim();
                aracSecTeslim.kiraTarihi = dtp_kiraTarihi.Text;
                aracSecTeslim.kiraSaati = mtxt_kiraSaati.Text;
                aracSecTeslim.teslimTarihi = dtp_teslimTarihi.Text;
                aracSecTeslim.teslimSaati = mtxt_teslimSaati.Text;
                this.Hide();
                aracSecTeslim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Saat Bilgileri Boş Bırakılamaz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }

        private void dtp_kiraTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimTarihi.MinDate = dtp_kiraTarihi.Value;
            dtp_teslimTarihi.Value=dtp_kiraTarihi.Value;
        }
    }
}
