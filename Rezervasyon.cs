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
    public partial class frm_Rezervasyon : Form
    {
        public frm_Rezervasyon()
        {
            InitializeComponent();
        }

        private void frm_Rezervasyon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_RezervasyonEkle_Click(object sender, EventArgs e)
        {
            string[] musteriler;
            string[] musteriBilgileri;
            string[] gecici;
            bool var = false;
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

                frm_AracSecRezervasyon aracSecRezervasyon = new frm_AracSecRezervasyon();
                aracSecRezervasyon.musteriTC = mtxt_TC.Text;
                this.Hide();
                aracSecRezervasyon.ShowDialog();

            }
            else
            {
                MessageBox.Show("Müşteri Bilgileri Boş Bırakılamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            txt_isim.Text = String.Empty;
            txt_soyisim.Text = String.Empty;
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
                    txt_isim.Text = musteriBilgileri[1];
                    txt_soyisim.Text = musteriBilgileri[2];
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
                list_Rezervasyonlar.Items.Clear();
                string[] rezervasyonlar;
                string[] rezervasyonBilgileri;
                string[] araclar;
                string[] araclarBilgileri;
                string musteriTC=mtxt_TC.Text, plaka="",marka="",model="", kiraTarihi="", kiraSaati="", teslimTarihi="", teslimSaati="";
                StreamReader rezervasyonOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt");
                rezervasyonlar = rezervasyonOku.ReadToEnd().Split("\n");
                rezervasyonOku.Close();
                foreach (var rezervasyon in rezervasyonlar)
                {
                    if (rezervasyon=="")
                    {
                        break;
                    }
                    rezervasyonBilgileri=rezervasyon.Split("#");
                    if (musteriTC==rezervasyonBilgileri[0])
                    {
                        plaka=rezervasyonBilgileri[1];
                        kiraTarihi=rezervasyonBilgileri[2];
                        kiraSaati=rezervasyonBilgileri[3];
                        teslimTarihi = rezervasyonBilgileri[4];
                        teslimSaati=rezervasyonBilgileri[5];

                        StreamReader aracBilgisiAl = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
                        araclar=aracBilgisiAl.ReadToEnd().Split("\n");
                        aracBilgisiAl.Close();
                        foreach (var arac in araclar)
                        {
                            if (arac=="")
                            {
                                break;
                            }
                            araclarBilgileri=arac.Split("#");
                            if (plaka==araclarBilgileri[0])
                            {
                                marka = araclarBilgileri[1];
                                model = araclarBilgileri[2];
                                
                                string[] satir = {marka,model,kiraTarihi,kiraSaati,teslimTarihi,teslimSaati,plaka};
                                ListViewItem listitem = new ListViewItem(satir);
                                list_Rezervasyonlar.Items.Add(listitem);
                                break;
                            }

                        }
                    }

                }
            }
        }

        private void frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt"))
            {
                FileStream olustur = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt");
                olustur.Close();
            }
           
            
        }

        private void btn_RezervasyonSil_Click(object sender, EventArgs e)
        {
            string silPlaka="",silTC="",silKiraTarihi="";
            int secimSayisi = list_Rezervasyonlar.CheckedItems.Count;
            if (secimSayisi>1)
            {
                MessageBox.Show("Tek seferde yalnızca bir rezervasyon silinebilir.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (secimSayisi==0)
            {
                MessageBox.Show("Lutfen bir seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Seçili Rezervasyonu Silmeyi Onaylıyor musunuz?", "Dikkat.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    foreach (ListViewItem rezervasyon in list_Rezervasyonlar.CheckedItems)
                    {
                        silTC = mtxt_TC.Text;
                        silKiraTarihi=rezervasyon.SubItems[2].Text;                       
                        silPlaka=rezervasyon.SubItems[6].Text;
                    }
                    string[] rezervasyonlar;
                    string[] rezervasyonBilgileri;
                    string[] gecici;
                    StreamReader rezervasyonOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+@"Kaynaklar\Rezervasyonlar.txt");
                    rezervasyonlar = rezervasyonOku.ReadToEnd().Split("\n");
                    rezervasyonOku.Close();
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt", string.Empty);
                    StreamWriter rezervasyonYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt",true);
                    foreach (var rezervasyon in rezervasyonlar)
                    {
                        if (rezervasyon=="")
                        {
                            break;
                        }

                        rezervasyonBilgileri = rezervasyon.Split("#");
                        if (silTC==rezervasyonBilgileri[0]&&silPlaka==rezervasyonBilgileri[1]&&silKiraTarihi==rezervasyonBilgileri[2])
                        {
                            continue;
                        }
                        else
                        {
                            gecici = rezervasyon.Split("\r");
                            rezervasyonYaz.WriteLine(gecici[0]);
                        }

                    }
                    rezervasyonYaz.Close();
                    btn_Ara_Click(sender, e);
                }
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
