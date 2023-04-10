using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormPays A = new FormPays();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Membre_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormMembre A = new FormMembre();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormProvince A = new FormProvince();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAffiliation A = new FormAffiliation();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Club_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormClub A = new FormClub();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Ville_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormVille A = new FormVille();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Territoire_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormTerritoire A = new FormTerritoire();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Province_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormProvince A = new FormProvince();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void Btn_Pays_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormPays A = new FormPays();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void DepotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormTerritoire A = new FormTerritoire();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void FournissurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormVille A = new FormVille();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void CommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormClub A = new FormClub();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void MembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAffiliation A = new FormAffiliation();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void DemmandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormMembre A = new FormMembre();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void AJOUTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAjoutUtilisateur A = new FormAjoutUtilisateur();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void AproposDeJaneGodallInstituteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAproposdeNous A = new FormAproposdeNous();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void AProposDeLAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAproposdeAutor A = new FormAproposdeAutor();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void AproposDeROOTSHOOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            FormAproposdeRS A = new FormAproposdeRS();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }
    }
}
