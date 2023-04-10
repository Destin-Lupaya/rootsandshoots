using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Ville
    {
        String CodeVille;
        String NomVille;
        String CodeClub;

        public string CodeVille1 { get => CodeVille; set => CodeVille = value; }
        public string NomVille1 { get => NomVille; set => NomVille = value; }
        public string CodeClub1 { get => CodeClub; set => CodeClub = value; }

        // Construction d'insertion et Modification

        public Ville(String CodeVille1, String NomVille1, String CodeClub1)
        {
            this.CodeVille = CodeVille1;
            this.NomVille = NomVille1;
            this.CodeClub = CodeClub1;


        }
        public Ville()
        {

        }
        //Constructeur de Suppresion
        public Ville(int Codeterr)
        {
            this.CodeVille = CodeVille1;
        }

        public void EnregistrerAgent(String A, String B, String C, String D, String E, String F, String G, String H, String I, String J)
        {

            try
            {
                Donnees RootsAndShoots = new Donnees();
                RootsAndShoots.connecter();
                RootsAndShoots.Cmd = RootsAndShoots.Con.CreateCommand();
                RootsAndShoots.Cmd.CommandText = string.Format(@"INSERT INTO Agents(Id_Agent,Login_Compte,NomAg,PostNomAg,PrenomAg,SexeAg,FonctionAg,ServiceAg,Tel,PassWord1) values ('" + A + "','" + B + "','" + C + "','" + D + "','" + E + "','" + F + "','" + G + "','" + H + "','" + I + "','" + J + "')");
                RootsAndShoots.Cmd.ExecuteNonQuery();
                MessageBox.Show("Création effectué avec succès!'" + NomVille + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
