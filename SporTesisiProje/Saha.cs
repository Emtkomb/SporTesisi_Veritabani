using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporTesisiProje
{
    public partial class Saha : Form
    {
        public Saha()
        {
            InitializeComponent();
        }

        private void btnkirala_Click(object sender, EventArgs e)
        {
            sahakiralama yeniSayfa = new sahakiralama();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void btnsahalar_Click(object sender, EventArgs e)
        {
            Sahalarımız yeniSayfa = new Sahalarımız();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void btnindrm_Click(object sender, EventArgs e)
        {
            indirim yeniSayfa = new indirim();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }
    }
}
