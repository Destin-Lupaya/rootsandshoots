using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace rootsandshoots
{
    class Donnees
    {
        public SqlConnection Con = new SqlConnection();
        public SqlDataAdapter DA = new SqlDataAdapter();
        public SqlCommand Cmd = new SqlCommand();
        public DataSet Ds = new DataSet();
        public DataTable Dt = new DataTable();


        public void connecter() // Creation de la connexion
        {
            if (Con.State == ConnectionState.Closed)
            {
                //Con.ConnectionString = @"Server=.\SQLEXPRESS; Database=Gestion_Des_Operations_Coopec_Sange; Integrated Security=true";
                Con.ConnectionString = @"Server=.\SQLEXPRESS; Database=Gestion_Des_Operations_Coopeerative_Final; Integrated Security=true";
                Con.Open();
            }
        }

        public void deconnecter() // Creation de la connexion  La déconnexion
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        public void remplirDGV(string sqlStatement, DataGridView dgv)
        {
            connecter();
            Cmd = Con.CreateCommand();
            Cmd.CommandText = sqlStatement;
            DA.SelectCommand = Cmd;
            DA.Fill(Ds);
            dgv.DataSource = Ds.Tables[0];
            deconnecter();


        }

        public void remplirComboBox(string sqlStatement, ComboBox cbo, string valueMember, string displayMember)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connecter();
            SqlCommand cmd1 = Con.CreateCommand();
            cmd1.CommandText = sqlStatement;
            DA.SelectCommand = Cmd;
            DA.Fill(ds);
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.DataSource = ds.Tables[0];
            deconnecter();
        }

    }
}
