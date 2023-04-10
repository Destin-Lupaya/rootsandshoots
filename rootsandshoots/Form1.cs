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

        private void ErToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class_1erp_Hommes A = new Etat_Class_1erp_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void EToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class_2emP_Hommes A = new Etat_Class_2emP_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void ErToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class_1erP_Femmes A = new Etat_Class_1erP_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void EToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class_2emP_Femmes A = new Etat_Class_2emP_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void ErToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class3emP_Hommes A = new Etat_Class3emP_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void EToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Class3emP_Femmes A = new Etat_Class3emP_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void DegreElementaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elementaire_Primaire A = new Etat_Rapport_Elementaire_Primaire();
            this.SplitContainer1.Panel2.Controls.Add(A);
            
        }

        private void HommesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elem_Prim_Hommes A = new Etat_Rapport_Elem_Prim_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void FemmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elem_Prim_Femmes A = new Etat_Rapport_Elem_Prim_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
            
        }

        private void DegreElementaireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elementaire_Secondaire A = new Etat_Rapport_Elementaire_Secondaire();
            this.SplitContainer1.Panel2.Controls.Add(A);
            
        }

        private void EncadreurCoordinateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Encadreur A = new Etat_Encadreur();
            this.SplitContainer1.Panel2.Controls.Add(A);

        }

        private void HommesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elem_Seco_Hommes A = new Etat_Rapport_Elem_Seco_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void FemmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Elem_Seco_Femmes A = new Etat_Rapport_Elem_Seco_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void FemininToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_Femme A = new Etat_Rapport_Femme();
            this.SplitContainer1.Panel2.Controls.Add(A);
            
        }

        private void G1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G1 A = new Etat_Rapport_G1();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void HommesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G1_Hommes A = new Etat_Rapport_G1_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void FemmesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G1_Femmes A = new Etat_Rapport_G1_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void G2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G2 A = new Etat_Rapport_G2();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void HommesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G2_Hommes A = new Etat_Rapport_G2_Hommes();
            this.SplitContainer1.Panel2.Controls.Add(A);

        }

        private void FemmesToolStripMenuItem5_Click(object sender, EventArgs e)
        {

            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G2_Femmes A = new Etat_Rapport_G2_Femmes();
            this.SplitContainer1.Panel2.Controls.Add(A);
        }

        private void G3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.SplitContainer1.Panel2.Controls.Clear();
            Etat_Rapport_G3 A = new Etat_Rapport_G3();
            this.SplitContainer1.Panel2.Controls.Add(A);
            
        }
    }
    
}
