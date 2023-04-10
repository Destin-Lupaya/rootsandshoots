using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    public partial class FormAproposdeAutor : UserControl
    {
        public FormAproposdeAutor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/destin-kabote-lupaya-8a861b121/");
            System.Diagnostics.Process.Start("https://www.facebook.com/destinkabote/");
            System.Diagnostics.Process.Start("https://www.twitter.com/Destinkabote");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.janegoodall.org");
            System.Diagnostics.Process.Start("https://www.fr.wikipedia.org/wiki/Jane_Goodall_Institute");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.janegoodall.org/our-work/our-approach/roots-shoots");
            System.Diagnostics.Process.Start("https://www.rootsandshoots.org");
            System.Diagnostics.Process.Start("https://www.rootsandshoots.org/about-us/");
            System.Diagnostics.Process.Start("https://www.rootsandshoots.org.uk");
            System.Diagnostics.Process.Start("https://www.janegoodall.org.nz/roots-shoots/");
            System.Diagnostics.Process.Start("https://www.rootsandshoots.fr");
        }
    }
}
