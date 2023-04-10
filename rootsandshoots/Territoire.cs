using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Territoire
    {
        String CodeTerritoire;
        String NomTerritoire;
        String CodeClub;

        public string CodeTerritoire1 { get => CodeTerritoire; set => CodeTerritoire = value; }
        public string NomTerritoire1 { get => NomTerritoire; set => NomTerritoire = value; }
        public string CodeClub1 { get => CodeClub; set => CodeClub = value; }

        // Construction d'insertion et Modification

        public Territoire(String CodeTerritoire1, String NomTerritoire1, String CodeClub1)
        {
            this.CodeTerritoire = CodeTerritoire1;
            this.NomTerritoire = NomTerritoire1;
            this.CodeClub1 = CodeTerritoire1;
           

        }
        public Territoire()
        {

        }
        //Constructeur de Suppresion
        public Territoire(int Codeterr)
        {
            this.CodeTerritoire = CodeTerritoire1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomTerritoire + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
