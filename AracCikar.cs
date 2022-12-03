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
    public partial class frm_AracCikar : Form
    {
        public frm_AracCikar()
        {
            InitializeComponent();
        }

        private void AracCikar_Load(object sender, EventArgs e)
        {
            list_Araclar.Items.Clear();

            string plaka="",marka = "", model = "", tip = "", yakit = "", vites = "", uygunluk = "";



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

                string[] satir = { plaka,marka, model, tip, yakit, vites, uygunluk };
                ListViewItem lst = new ListViewItem(satir);
                list_Araclar.Items.Add(lst);
            }

            aracListesi.Close();
        }

        private void AracCikar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            anaMenu.ShowDialog();
        }

        private void btn_AraciSil_Click(object sender, EventArgs e)
        {
            int secilenAracSayisi = list_Araclar.CheckedItems.Count;

            string silinecekPlaka="";

            string[] aracBilgileri;
            string[] araclar;
            string[] gecici;
            string plaka;


            if (secilenAracSayisi>1)
            {
                MessageBox.Show("Tek seferde yalnizca bir arac silebilirsiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (secilenAracSayisi==0)
            {
                MessageBox.Show("Lütfen bir araç seçimi yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Aracı Silmek İstediğinize Emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.No)
                {
                    return;
                }

                foreach (ListViewItem item in list_Araclar.CheckedItems)
                {
                    silinecekPlaka = item.Text;
                }           

               
                StreamReader aracBilgileriAl = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
                araclar = aracBilgileriAl.ReadToEnd().Split("\n");
                aracBilgileriAl.Close();
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt", string.Empty);
                StreamWriter aracBilgileriYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt",true);
                foreach (var arac in araclar)
                {
                    if (arac == "")
                    {
                        break;
                    }
                    aracBilgileri = arac.Split("#");

                    plaka = aracBilgileri[0];

                    if(plaka==silinecekPlaka)
                    {
                        continue;
                    }
                    else
                    {
                        gecici = arac.Split("\r");
                        aracBilgileriYaz.WriteLine(gecici[0]);
                    }


                }
                aracBilgileriYaz.Close();

                MessageBox.Show("Arac Başarı ile Silindi","İşlem Başarılı");

                AracCikar_Load(sender, e);
            }

        }
        
    }
}
