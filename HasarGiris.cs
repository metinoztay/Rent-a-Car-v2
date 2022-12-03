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
    public partial class frm_HasarGiris : Form
    {
        
        public frm_HasarGiris()
        {
            InitializeComponent();
        }

        private void btn_Onay_Click(object sender, EventArgs e)
        {
            StreamWriter hasarYaz = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Kaynaklar\Hasar.txt");
            hasarYaz.WriteLine(txt_hasar.Text);
            hasarYaz.Close();
            this.Close();
        }

        private void frm_HasarGiris_Load(object sender, EventArgs e)
        {

        }

        private void frm_HasarGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
