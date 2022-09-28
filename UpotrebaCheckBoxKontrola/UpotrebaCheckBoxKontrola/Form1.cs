using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpotrebaCheckBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntPoslaj_Click(object sender, EventArgs e)
        {
            string text = "Odabrali ste:"+Environment.NewLine;
            if (chkDorucak.Checked==true) { text += "Dorucak" + Environment.NewLine; }
            if (chkRucak.Checked == true) { text += "Rucak" + Environment.NewLine; }
            if (chkVecera.Checked == true) { text += "Vecera" + Environment.NewLine; }
            txtMain.Text = text;
        }

        private void chkSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if(txtMain.Visible==false)
                txtMain.Visible=true;
            else
                txtMain.Visible=false;
        }
    }
}
