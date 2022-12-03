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
    public partial class frm_AracSecTeslim : Form
    {
        public string musteriTC="",plaka="",kiraTarihi="",kiraSaati="",teslimTarihi="",teslimSaati="";

        public void aracUygunlukDegistir(string plaka,string yeniDurum)
        {

            int aracNo = 0;
            string[] araclar;
            string[] gecici;
            string[] aracBilgileri;
            StreamReader aracOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
            araclar = aracOku.ReadToEnd().Split('\n');
            aracOku.Close();

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt", string.Empty);
            StreamWriter aracYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt", true);
            foreach (var arac in araclar)
            {
                if (arac == "")
                {
                    break;
                }
                aracBilgileri = arac.Split("#");
                if (plaka!=aracBilgileri[0])
                {
                    gecici = arac.Split("\r");
                    aracYaz.WriteLine(gecici[0]);
                }
                else
                {
                    aracYaz.WriteLine(
                    plaka + "#" +
                    aracBilgileri[1] + "#" +
                    aracBilgileri[2] + "#" +
                    aracBilgileri[3] + "#" +
                    aracBilgileri[4] + "#" +
                    aracBilgileri[5] + "#" +
                    aracBilgileri[6] + "#" +
                    aracBilgileri[7] + "#" +
                    yeniDurum + "#"
                    );

                }

                aracNo++;
            }
            aracYaz.Close();

        }

        public void teslimEdilenRezervasyonSil(string silTc,string silKiraTarihi)
        {
            string[] rezervasyonlar;
            string[] rezervasyonBilgileri;
            string[] gecici;
            StreamReader rezervasyonOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt");
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

                rezervasyonBilgileri=rezervasyon.Split("#");
                if (silTc==rezervasyonBilgileri[0]&&silKiraTarihi==rezervasyonBilgileri[2])
                {
                    continue;
                }
                else
                {
                    gecici=rezervasyon.Split("\r");
                    rezervasyonYaz.WriteLine(gecici[0]);
                }
            }
            rezervasyonYaz.Close();
        
        
        }

        public int ucretHesapla (DateTime kiraTarihi,DateTime teslimTarihi,int ucret)
        {
            int gunSayisi = 0;
            TimeSpan gunler = teslimTarihi - kiraTarihi;
            gunSayisi = int.Parse(gunler.Days.ToString());
            if (gunSayisi > 4 && gunSayisi < 8)
            {
                return ((ucret * gunSayisi) * 90) / 100;
            }
            else if (gunSayisi >= 8 && gunSayisi < 12)
            {
                return ((ucret * gunSayisi) * 85) / 100;
            }
            else if (gunSayisi >= 12)
            {
                return ((ucret * gunSayisi) * 80) / 100;
            }    

            return (ucret * gunSayisi);
        }
        private void btn_TeslimEt_Click(object sender, EventArgs e)
        {
            string tip="";
            string[] ucretler;
            string[] ucretBilgileri;
            int ucret=0;
            DialogResult secim= MessageBox.Show("Arac Teslimini Onaylıyor musunuz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim==DialogResult.Yes)
            {
                foreach (ListViewItem satir in list_Araclar.SelectedItems)
                {
                    plaka = satir.SubItems[6].Text;
                    tip = satir.SubItems[2].Text;
                }
                StreamReader ucretOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Ucretler.txt");
                ucretler = ucretOku.ReadToEnd().Split("\n");
                ucretOku.Close();
                foreach (var fiyat in ucretler)
                {
                    if (fiyat=="")
                    {
                        break;
                    }

                    ucretBilgileri=fiyat.Split("#");
                    if (tip==ucretBilgileri[0])
                    {
                        ucret = ucretHesapla(Convert.ToDateTime(kiraTarihi),Convert.ToDateTime(teslimTarihi),int.Parse(ucretBilgileri[1]));
                    }
                }

                StreamWriter aracTeslim = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\AracTeslim.txt", true);
                aracTeslim.WriteLine(
                    musteriTC + "#" +
                    plaka + "#" +
                    kiraTarihi + "#" +
                    kiraSaati + "#" +
                    teslimTarihi + "#" +
                    teslimSaati + "#" +
                    ucret.ToString() + "#"
                    );
                aracTeslim.Close();

                aracUygunlukDegistir(plaka, "KİRADA");
                teslimEdilenRezervasyonSil(musteriTC, kiraTarihi);

                MessageBox.Show("Arac Teslimi Tamamlandı", "İşlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_AnaMenu anaMenu = new frm_AnaMenu();
                this.Hide();
                anaMenu.ShowDialog();

            }            
            
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }

        private void list_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_Rezervasyonlar.Items.Clear();           
            string[] rezervasyonlar;
            string[] rezervasyonBilgileri;
            string[] musteriler;
            string[] musteriBilgileri;
            string tip="";
            string secilenPlaka="",isim="",soyisim="",rkiraTarihi="",rkiraSaati="",rteslimTarihi="",rteslimSaati="";
            foreach (ListViewItem item in list_Araclar.SelectedItems)
            {
                secilenPlaka = item.SubItems[6].Text;
                tip = item.SubItems[2].Text;
            }

            StreamReader rezervasyonOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt");
            rezervasyonlar = rezervasyonOku.ReadToEnd().Split("\n");
            rezervasyonOku.Close();
            foreach (var rezervasyon in rezervasyonlar)
            {
                if (rezervasyon == "")
                {
                    break;
                }
                rezervasyonBilgileri = rezervasyon.Split("#");
                if (secilenPlaka == rezervasyonBilgileri[1])
                {
                    musteriTC = rezervasyonBilgileri[0];
                    rkiraTarihi = rezervasyonBilgileri[2];
                    rkiraSaati = rezervasyonBilgileri[3];
                    rteslimTarihi = rezervasyonBilgileri[4];
                    rteslimSaati = rezervasyonBilgileri[5];

                    StreamReader musteriBilgisiAl = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt");
                    musteriler = musteriBilgisiAl.ReadToEnd().Split("\n");
                    musteriBilgisiAl.Close();
                    foreach (var musteri in musteriler)
                    {
                        if (musteri == "")
                        {
                            break;
                        }
                        musteriBilgileri = musteri.Split("#");
                        if (musteriTC == musteriBilgileri[0])
                        {
                            isim = musteriBilgileri[1];
                            soyisim = musteriBilgileri[2];
                            break;
                        }
                    }
                    string[] satir = { isim + " " + soyisim, kiraTarihi, kiraSaati, kiraTarihi, kiraSaati };
                    ListViewItem lst = new ListViewItem(satir);
                    list_Rezervasyonlar.Items.Add(lst);

                }

            }

            string[] ucretler;
            string[] ucretBilgileri;
            int ucret=0;
            StreamReader ucretOku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Ucretler.txt");
            ucretler = ucretOku.ReadToEnd().Split("\n");
            ucretOku.Close();
            foreach (var fiyat in ucretler)
            {
                if (fiyat == "")
                {
                    break;
                }

                ucretBilgileri = fiyat.Split("#");
                if (tip == ucretBilgileri[0])
                {
                    ucret = ucretHesapla(Convert.ToDateTime(kiraTarihi), Convert.ToDateTime(teslimTarihi), int.Parse(ucretBilgileri[1]));
                }
            }

            lbl_toplam.Text = "Toplam: " + ucret.ToString();
        }

        public frm_AracSecTeslim()
        {
            InitializeComponent();
        }

        private void AracSecTeslim_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\AracTeslim.txt"))
            {
                FileStream olustur = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\AracTeslim.txt");
                olustur.Close();
            }

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

                if (uygunluk=="UYGUN")
                {
                    string[] satir = { marka, model, tip, yakit, vites, uygunluk ,plaka};
                    ListViewItem lst = new ListViewItem(satir);
                    list_Araclar.Items.Add(lst);
                }                
            }

            aracListesi.Close();
        }
    }
}
