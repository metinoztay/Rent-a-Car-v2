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
    public partial class frm_AracEkle : Form
    {
        public frm_AracEkle()
        {
            InitializeComponent();
        }

        private void frm_AracEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AnaMenu AnaMenu = new frm_AnaMenu();
            AnaMenu.ShowDialog();
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            StreamWriter aracEkle = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt",true);
            try
            {
                aracEkle.WriteLine(
                txt_plaka.Text.Trim() + "#" +
                txt_marka.Text.Trim() + "#" +
                txt_model.Text.Trim() + "#" +
                cbx_tip.SelectedItem.ToString() + "#" +
                cbx_yakit.SelectedItem.ToString() + "#" +
                cbx_vites.SelectedItem.ToString() + "#" +
                mtxt_sigorta.Text.Trim() + "#" +
                mtxt_kasko.Text.Trim() + "#" +
                cbx_uygunluk.SelectedItem.ToString() + "#"
                );
                aracEkle.Close();

                MessageBox.Show("Araç Başarı İle Eklendi", "Araç Ekleme");
            }
            catch (Exception ex)
            {
                // Hata Mesajı yazdırma
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }

        }

        private void frm_AracEkle_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt"))
            {
                FileStream olustur = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Araclar.txt");
                olustur.Close();
            }
        }
    }
}
