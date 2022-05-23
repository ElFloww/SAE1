using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDs;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SAE1
{
    public partial class modification : Form
    {
        public modification()
        {
            InitializeComponent();
        }

        private void modification_Load(object sender, EventArgs e)
        {
            string req = $"Select COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne AND NomLigne = 'Ligne 1';";
            List<string> lignes = new List<string>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString(0));
                }
                rdr.Close();
                cmd.Dispose();

                radLigne1.Text = $"Ligne 1                                                  Nombre d'arret(s) : {lignes[0]}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            lignes.Clear();
            req = $"Select COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne AND NomLigne = 'Ligne 5';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString(0));
                }
                rdr.Close();
                cmd.Dispose();

                radLigne5.Text = $"Ligne 5                                                  Nombre d'arret(s) : {lignes[0]}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            lignes.Clear();
            req = $"Select COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne AND NomLigne = 'Ligne 7';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString(0));
                }
                rdr.Close();
                cmd.Dispose();

                radLigne7.Text = $"Ligne 7                                                 Nombre d'arret(s) : {lignes[0]}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            lignes.Clear();
            req = $"Select COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne AND NomLigne = 'Ligne 8';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString(0));
                }
                rdr.Close();
                cmd.Dispose();

                radLigne8.Text = $"Ligne 8                                                  Nombre d'arret(s) : {lignes[0]}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cmdQuitterAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCreation_Click(object sender, EventArgs e)
        {
            Form formCreationLigne = new AjoutLigne();
            formCreationLigne.ShowDialog();
        }
    }
}
