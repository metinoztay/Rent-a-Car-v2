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
    public partial class frm_AracSecRezervasyon : Form
    {
        public string musteriTC="";
        public frm_AracSecRezervasyon()
        {
            InitializeComponent();
        }

        private void btn_RezervasyonEkle_Click(object sender, EventArgs e)
        {
            string plaka = "";
            foreach (ListViewItem item in list_Araclar.SelectedItems)
            {
                plaka = item.SubItems[6].Text;
            }

            StreamWriter rezervasyonEkle = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Rezervasyonlar.txt",true);
            rezervasyonEkle.WriteLine(
                musteriTC + "#" +
                plaka + "#" +
                dtp_kiraTarihi.Text + "#" +
                mtxt_kiraSaati.Text + "#" +
                dtp_teslimTarihi.Text + "#" +
                mtxt_teslimSaati.Text + "#"
                );
            rezervasyonEkle.Close();

            MessageBox.Show("Rezervasyon Başarı İle Eklendi","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }

        private void btn_devamEt_Click(object sender, EventArgs e)
        {
            list_Araclar.Items.Clear();
            string plaka="",marka = "", model = "", tip = "", yakit = "", vites = "", uygunluk = "";

            string[] aracBilgileri;
            string[] araclar;
            if (mtxt_kiraSaati.Text!= "  :" && mtxt_teslimSaati.Text!= "  :")
            {
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

                    string[] satir = { marka, model, tip, yakit, vites, uygunluk,plaka};
                    ListViewItem lst = new ListViewItem(satir);
                    list_Araclar.Items.Add(lst);
                }

                aracListesi.Close();

                list_Araclar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Saat Bilgileri Boş Bırakılamaz","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void list_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_Rezervasyonlar.Items.Clear();
            string secilenPlaka="",plaka="",musteriTC="",isim="",soyisim="",kiraTarihi="",kiraSaati="",teslimTarihi="",teslimSaati="";
            string[] rezervasyonlar;
            string[] rezervasyonBilgileri;
            string[] musteriler;
            string[] musteriBilgileri;
            string tip = "";
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
                if (rezervasyon=="")
                {
                    break;
                }
                rezervasyonBilgileri=rezervasyon.Split("#");
                if (secilenPlaka==rezervasyonBilgileri[1])
                {
                    musteriTC = rezervasyonBilgileri[0];
                    kiraTarihi = rezervasyonBilgileri[2];
                    kiraSaati = rezervasyonBilgileri[3];
                    teslimTarihi = rezervasyonBilgileri[4];
                    teslimSaati = rezervasyonBilgileri[5];

                    StreamReader musteriBilgisiAl = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Musteriler.txt");
                    musteriler = musteriBilgisiAl.ReadToEnd().Split("\n");
                    musteriBilgisiAl.Close();
                    foreach (var musteri in musteriler)
                    {
                        if (musteri=="")
                        {
                            break;
                        }
                        musteriBilgileri=musteri.Split("#");
                        if (musteriTC==musteriBilgileri[0])
                        {
                            isim = musteriBilgileri[1];
                            soyisim=musteriBilgileri[2];
                            break;
                        }
                    }
                    string[] satir = { isim + " " + soyisim, kiraTarihi, kiraSaati, kiraTarihi, kiraSaati };
                    ListViewItem lst = new ListViewItem(satir);
                    list_Rezervasyonlar.Items.Add(lst);

                }

            }        


        }

        private void dtp_kiraTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimTarihi.MinDate = dtp_kiraTarihi.Value;
            dtp_teslimTarihi.Value = dtp_kiraTarihi.Value;
        }

        private void frm_AracSecRezervasyon_Load(object sender, EventArgs e)
        {
           dtp_kiraTarihi.MinDate = DateTime.Now;
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            this.Hide();
            anaMenu.ShowDialog();
        }
    }
}
