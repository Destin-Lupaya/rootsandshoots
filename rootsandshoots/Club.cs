using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Club
    {
        String CodeClub;
        String NomClub;
        String AnneeAdhesion;
        String CodeAffiliation;
        String TypeAdhesion;
        String NombreMembres;
        String GroupeAge;
        String AdresseClub;
        String Territoire_Ville;
        String Province;
        String NomPresidentClub;
        String NomCoordinateur;
        String ProfessionCoordinateur;
        String AdresseCoordinateur;
        String Telephone;
        String mail;

        public string CodeClub1 { get => CodeClub; set => CodeClub = value; }
        public string NomClub1 { get => NomClub; set => NomClub = value; }
        public string AnneeAdhesion1 { get => AnneeAdhesion; set => AnneeAdhesion = value; }
        public string CodeAffiliation1 { get => CodeAffiliation; set => CodeAffiliation = value; }
        public string TypeAdhesion1 { get => TypeAdhesion; set => TypeAdhesion = value; }
        public string NombreMembres1 { get => NombreMembres; set => NombreMembres = value; }
        public string GroupeAge1 { get => GroupeAge; set => GroupeAge = value; }
        public string AdresseClub1 { get => AdresseClub; set => AdresseClub = value; }
        public string Territoire_Ville1 { get => Territoire_Ville; set => Territoire_Ville = value; }
        public string Province1 { get => Province; set => Province = value; }
        public string NomPresidentClub1 { get => NomPresidentClub; set => NomPresidentClub = value; }
        public string NomCoordinateur1 { get => NomCoordinateur; set => NomCoordinateur = value; }
        public string ProfessionCoordinateur1 { get => ProfessionCoordinateur; set => ProfessionCoordinateur = value; }
        public string AdresseCoordinateur1 { get => AdresseCoordinateur; set => AdresseCoordinateur = value; }
        public string Telephone1 { get => Telephone; set => Telephone = value; }
        public string Mail { get => mail; set => mail = value; }

        // Construction d'insertion et Modification

        public Club(String CodeClub1, String NomClub1, String AnneeAdhesion1, String CodeAffiliation1, String TypeAdhesion1, String NombreMembres1, String GroupeAge1, String AdresseClub1, String Territoire_Ville1, String Province1, String NomPresidentClub1, String NomCoordinateur1, String ProfessionCoordinateur1, String AdresseCoordinateur1 , String Telephone1, String Mail)
        {
            this.CodeClub = CodeClub1;
            this.NomClub = NomClub1;
            this.AnneeAdhesion = AnneeAdhesion1;
            this.CodeAffiliation = CodeAffiliation1;
            this.TypeAdhesion = TypeAdhesion1;
            this.NombreMembres = NombreMembres1;
            this.GroupeAge = GroupeAge1;
            this.AdresseClub = AdresseClub1;
            this.Territoire_Ville = Territoire_Ville1;
            this.Province = Province1;
            this.NomPresidentClub = NomPresidentClub1;
            this.NomCoordinateur = NomCoordinateur1;
            this.ProfessionCoordinateur = ProfessionCoordinateur1;
            this.AdresseCoordinateur = AdresseCoordinateur1;
            this.Telephone = Telephone1;
            this.Mail = Mail;
        }
        public Club()
        {

        }

        //Constructeur de Suppresion
        public Club(int Codeclu)
        {
            this.CodeClub = CodeClub1;
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
                MessageBox.Show("Création effectué avec succès!'" + NomClub + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
