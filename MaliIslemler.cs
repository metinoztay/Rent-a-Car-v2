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
    public partial class frm_MaliIslemler : Form
    {
        public frm_MaliIslemler()
        {
            InitializeComponent();
        }

        private void btn_MusteriIslemleri_Click(object sender, EventArgs e)
        {
            
            frm_MusteriIslemleri musteriIslemleri = new frm_MusteriIslemleri();            
            musteriIslemleri.ShowDialog();
            this.Hide();

        }

        private void btn_MaliDurum_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_MaliDurum maliDurum = new frm_MaliDurum();
            maliDurum.ShowDialog();
            
        }
    }
}
