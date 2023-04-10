using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Pays
    {
        String CodePays;
        String NomPays;
        String CodeProvince;

        public string CodePays1 { get => CodePays; set => CodePays = value; }
        public string NomPays1 { get => NomPays; set => NomPays = value; }
        public string CodeProvince1 { get => CodeProvince; set => CodeProvince = value; }

        // Construction d'insertion et Modification

        public Pays(String CodePays1, String NomPays1, String CodeProvince1)
        {
            this.CodePays = CodePays1;
            this.NomPays = NomPays1;
            this.CodeProvince = CodeProvince1;
           

        }
        public Pays()
        {

        }
        //Constructeur de Suppresion
        public Pays(int CodeP)
        {
            this.CodePays = CodePays1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomPays + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
