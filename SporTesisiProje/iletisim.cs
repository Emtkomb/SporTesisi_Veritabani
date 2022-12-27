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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void btnadrescopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richtxtadres.Text);
        }

        private void btnepostacopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtesposta.Text);
        }

        private void btntlfncopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(maskedtxttlfn.Text);
        }

        private void btnfaxcopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(maskettxtfax.Text);
        }
    }
}
