using BDs;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace SAE1
{
    public partial class frmFilibusAccueil : Form
    {
        public frmFilibusAccueil()
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
            string req = $"Select NomArret from Arret WHERE NomArret != '{CBOArretB.Text}'ORDER BY NomArret";

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
            string req = $"Select NomArret from Arret WHERE NomArret != '{CBOArretA.Text}'ORDER BY NomArret";

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

        private void ItineraireValidation(object sender, EventArgs e)
        {
            if(CBOArretA.Text != "" && CBOArretB.Text != "")
            {
                cmdAfficher2.Enabled = true;
            }
        }

        private void HoraireValidation(object sender, EventArgs e)
        {
            if(CBOLigne.Text != "")
            {
                CBOArret.Enabled = true;
            }
            if (CBOArret.Text != "" && CBOLigne.Text != "")
            {
                cmdAfficher1.Enabled = true;
            }
        }

        private void CBOLigne_SelectedValueChanged(object sender, EventArgs e)
        {
            CBOArret.Text = null;
        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("coucou");
            Form formmodif = new modification();
            formmodif.ShowDialog();

        }
    }
}