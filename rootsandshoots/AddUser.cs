using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class AddUser
    {
        String NomUtilisateur;
        String Motdepass;
        String TypeUtilisateur;

        public string NomUtilisateur1 { get => NomUtilisateur; set => NomUtilisateur = value; }
        public string Motdepass1 { get => Motdepass; set => Motdepass = value; }
        public string TypeUtilisateur1 { get => TypeUtilisateur; set => TypeUtilisateur = value; }

        // Construction d'insertion et Modification

        public AddUser(String NomUtilisateur1, String Motdepass1, String TypeUtilisateur1)
        {
            this.NomUtilisateur1 = NomUtilisateur;
            this.Motdepass = Motdepass1;
            this.TypeUtilisateur1 = TypeUtilisateur;
           

        }
        public AddUser()
        {

        }
        //Constructeur de Suppresion
        public AddUser(int IdUser)
        {
            this.NomUtilisateur = NomUtilisateur1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomUtilisateur + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
