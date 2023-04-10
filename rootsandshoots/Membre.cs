using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootsandshoots
{
    class Membre
    {
        String CodeMembre;
        public String Nom { get; set; }
        String PostNom;
        String Prenom;
        String Age;
        String Sexe;
        String ClassEtude;
        String NiveauEtude;
        String Numero;
        String FonctionMembre;
        String AdresseMembre;
        String mail;

        public string CodeMembre1 { get => CodeMembre; set => CodeMembre = value; }
        public string PostNom1 { get => PostNom; set => PostNom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public string Age1 { get => Age; set => Age = value; }
        public string Sexe1 { get => Sexe; set => Sexe = value; }
        public string ClassEtude1 { get => ClassEtude; set => ClassEtude = value; }
        public string NiveauEtude1 { get => NiveauEtude; set => NiveauEtude = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
        public string FonctionMembre1 { get => FonctionMembre; set => FonctionMembre = value; }
        public string AdresseMembre1 { get => AdresseMembre; set => AdresseMembre = value; }
        public string Mail { get => mail; set => mail = value; }


        // Construction d'insertion et Modification

        public Membre(String CodeMembre1, String Nom1, String PostNom1, String Prenom1, String Age1, String Sexe1, String ClassEtude1, String NiveauEtude1, String Numero1, String FonctionMembre1, String Mail1)
        {
            this.CodeMembre = CodeMembre1;
            this.Nom = Nom1;
            this.PostNom = PostNom1;
            this.Prenom = Prenom1;
            this.Age = Age1;
            this.Sexe = Sexe1;
            this.ClassEtude = ClassEtude1;
            this.NiveauEtude = NiveauEtude1;
            this.Numero = Numero1;
            this.FonctionMembre = FonctionMembre1;
            this.Mail = Mail1;
        }
        public Membre()
        {

        }
        //Constructeur de Suppresion
        public Membre(int IdAge)
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
                MessageBox.Show("Création effectué avec succès!'" + Nom + "'");
                RootsAndShoots.deconnecter();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        }



    }
