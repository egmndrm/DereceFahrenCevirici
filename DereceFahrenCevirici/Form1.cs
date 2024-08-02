using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DereceFahrenCevirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahreDonustur_Click(object sender, EventArgs e)
        {
            double derece = Convert.ToDouble(txbDerece.Text);
            lbSonuc.Text = Convert.ToString(derece * 1.8 + 32);


        }

        private void btnDereceDonustur_Click(object sender, EventArgs e)
        {
            double fahren = Convert.ToDouble(txbFahre.Text);
            lbSonuc.Text = Convert.ToString((fahren - 32) / 1.8);


        }

        private void btnKelvindenDerece_Click(object sender, EventArgs e)
        {
            double kelvin = Convert.ToDouble(txbKelvin.Text);
            lbSonuc.Text = Convert.ToString(kelvin - 273.15);
        }
    }
}
