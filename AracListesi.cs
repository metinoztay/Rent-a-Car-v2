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
    public partial class frm_AracListesi : Form
    {
        public frm_AracListesi()
        {
            InitializeComponent();
        }

        private void AracListesi_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt"))
            {
                FileStream olustur = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
                olustur.Close();
            }

            list_Araclar.Columns.Add("Marka", 157);
            list_Araclar.Columns.Add("Model", 150);
            list_Araclar.Columns.Add("Tip", 75);
            list_Araclar.Columns.Add("Yakıt", 150);
            list_Araclar.Columns.Add("Vites", 150);
            list_Araclar.Columns.Add("Uygunluk", 150);

            string marka="", model="", tip="", yakit="", vites="", uygunluk="";
            
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
                marka = aracBilgileri[1];
                model = aracBilgileri[2];
                tip = aracBilgileri[3];
                yakit = aracBilgileri[4];
                vites = aracBilgileri[5];
                uygunluk = aracBilgileri[8];

                string[] satir = { marka, model, tip, yakit, vites, uygunluk };
                ListViewItem lst = new ListViewItem(satir);
                list_Araclar.Items.Add(lst);
            }

            aracListesi.Close();          

        }

        private void frm_AracListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            anaMenu.ShowDialog();

        }

        private void list_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
