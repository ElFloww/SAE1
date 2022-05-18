using BDs;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace SAE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Affichage des lignes

            bool connexionOuverte = BDD.initConnexion();
            if (connexionOuverte)
            {
                MessageBox.Show("Connexion à la base réussi !");
                CBOArret.Enabled = false;
                cmdAfficher1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Echec de connexion à la base !");
                this.Close();
            }
        }

        private void CBOLigne_Enter(object sender, EventArgs e)
        {
            CBOLigne.Items.Clear();
            List<string> lignes = new List<string>();
            string req = "Select NomLigne from Ligne";

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

                object[] liste = lignes.ToArray<object>();
                CBOLigne.Items.AddRange(liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            CBOArret.Enabled = true;
            if(CBOLigne.Text != null)
            {
                cmdAfficher1.Enabled = true;
            }
        }

        private void CBOArret_Enter(object sender, EventArgs e)
        {
            CBOArret.Items.Clear();
            List<string> lignes = new List<string>();
            string req = $"Select NomArret from ArretLigne,Arret,Ligne WHERE ArretLigne.N_Arret = Arret.N_Arret AND ArretLigne.N_Ligne = Ligne.N_Ligne AND NomLigne = '{CBOLigne.Text}' ORDER BY NomArret";

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

                object[] liste = lignes.ToArray<object>();
                CBOArret.Items.AddRange(liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CBOArretA_Enter(object sender, EventArgs e)
        {
            CBOArretA.Items.Clear();
            List<string> lignes = new List<string>();
            string req = "Select NomArret from Arret ORDER BY NomArret";

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

                object[] liste = lignes.ToArray<object>();
                CBOArretA.Items.AddRange(liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CBOArretB_Enter(object sender, EventArgs e)
        {
            CBOArretB.Items.Clear();
            List<string> lignes = new List<string>();
            string req = "Select NomArret from Arret ORDER BY NomArret";

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

                object[] liste = lignes.ToArray<object>();
                CBOArretB.Items.AddRange(liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}