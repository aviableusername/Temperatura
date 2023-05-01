using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class temperatura : Form
    {
        public temperatura()
        {
            InitializeComponent();
        }

        private void temperatura_Load(object sender, EventArgs e)
        {

        }
        
        private void Janalan()
        {

            double shelek;
            if (double.TryParse(guna2TextBox1.Text, out shelek))
            {
                string birinshi = guna2ComboBox1.Text;
                string ekinshi = guna2ComboBox2.Text;
                double jiber = KonvertTemperatura(shelek, birinshi, ekinshi);
                guna2TextBox2.Text = jiber.ToString();
            }
        }



        private double KonvertTemperatura(double kiriwshi, string birinshi, string ekinshi)
        {
            double aa;
            switch (birinshi)
            {
                case "Celsy": aa = kiriwshi; break;
                case "Farengeyt": aa = (kiriwshi - 32) * 5 / 9; break;
                case "Kelvin": aa = kiriwshi - 273.15; break;
                default: aa = 0; break;
            }

            double kett;
            switch (ekinshi)
            {

                case "Celsy": kett = aa; break;
                case "Farengeyt": kett = aa * 9 / 5 + 32; break;
                case "Kelvin": kett = aa + 273.15; break;
                default: kett = aa; break;
            }

            return kett;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Janalan();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Janalan();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Janalan();
            if(guna2TextBox1.Text == "")
            {
                guna2TextBox2.Text = "";
            }

        }
    }
}
