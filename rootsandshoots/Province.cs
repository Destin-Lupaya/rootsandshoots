using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Province
    {
        String CodeProvince;
        String NomProvince;
        String CodeTerritoire;
        String CodeVille;

        public string CodeProvince1 { get => CodeProvince; set => CodeProvince = value; }
        public string NomProvince1 { get => NomProvince; set => NomProvince = value; }
        public string CodeTerritoire1 { get => CodeTerritoire; set => CodeTerritoire = value; }
        public string CodeVille1 { get => CodeVille; set => CodeVille = value; }

        // Construction d'insertion et Modification

        public Province(String CodeProvince1, String NomProvince1, String CodeTerritoire1, String CodeVille1)
        {
            this.CodeProvince = CodeProvince1;
            this.NomProvince = NomProvince1;
            this.CodeTerritoire = CodeTerritoire1;
            this.CodeVille = CodeVille1;


        }
        public Province()
        {

        }
        //Constructeur de Suppresion
        public Province(int CodeProv)
        {
            this.CodeProvince = CodeProvince1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomProvince + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
