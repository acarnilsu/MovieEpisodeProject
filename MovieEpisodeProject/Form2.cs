using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieEpisodeProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sınıfadı nesneadı=new sınıfadı();

            Araba arb=new Araba();
            arb.marka = "Renault";
            arb.model = "2018";
            arb.fiyat = 250000;
            label1.Text = arb.marka + " " + arb.model + " " + arb.fiyat;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
