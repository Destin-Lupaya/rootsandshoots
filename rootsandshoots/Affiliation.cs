using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Affiliation
    {
        String CodeAffiliation;
        String NomAffiliation;
        String CodeMembre;
        String DateAffiliation;

        public string CodeAffiliation1 { get => CodeAffiliation; set => CodeAffiliation = value; }
        public string NomAffiliation1 { get => NomAffiliation; set => NomAffiliation = value; }
        public string CodeMembre1 { get => CodeMembre; set => CodeMembre = value; }
        public string DateAffiliation1 { get => DateAffiliation; set => DateAffiliation = value; }

        // Construction d'insertion et Modification

        public Affiliation(String CodeAffiliation1, String NomAffiliation1, String CodeMembre1, String DateAffiliation1)
        {
            this.CodeAffiliation = CodeAffiliation1;
            this.NomAffiliation = NomAffiliation1;
            this.CodeMembre = CodeMembre1;
            this.DateAffiliation = DateAffiliation1;
           
        }
        public Affiliation()
        {

        }
        //Constructeur de Suppresion
        public Affiliation(int CodeAff)
        {
            this.CodeMembre = CodeMembre1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomAffiliation + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
