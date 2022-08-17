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
    public partial class Matematik : Form
    {
        public Matematik()
        {
            InitializeComponent();
        }

        public int topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        public int carp(int p1,int p2, int p3)
        {
            int sonuc = p1 * p2 * p3;
            return sonuc;
        }

        private void Matematik_Load(object sender, EventArgs e)
        {

        }
    }
}
