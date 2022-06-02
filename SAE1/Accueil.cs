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
            //Connection à la base de données
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
            if (CBOArretA.Text != "" && CBOArretB.Text != "")
            {
                cmdAfficher2.Enabled = true;
            }
        }

        private void HoraireValidation(object sender, EventArgs e)
        {
            if (CBOLigne.Text != "")
            {
                CBOArret.Enabled = true;
            }
            if (CBOArret.Text != "")
            {
                CBOSens.Enabled = true;
            }
            if (CBOArret.Text != "" && CBOLigne.Text != "" && CBOSens.Text != "")
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
            Form formmodif = new modification();
            formmodif.ShowDialog();
        }
        private void CBOSens_Enter(object sender, EventArgs e)
        {
            CBOSens.Items.Clear();
            List<string> liste = new List<string>();
            List<int> ArretDepart = new List<int>();
            List<int> ArretTerminus = new List<int>();
            string depart = "";
            string terminus = "";
            string req = $"Select N_ArretDepart,N_ArretTerminus,COUNT(*) FROM Trajet,Ligne WHERE Ligne.N_Ligne = Trajet.N_Ligne AND NomLigne = '{CBOLigne.Text}' AND N_TypeJour = 1 GROUP BY N_ArretDepart,N_ArretTerminus ORDER BY COUNT(*) DESC LIMIT 2;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ArretDepart.Add(rdr.GetInt32(0));
                    ArretTerminus.Add(rdr.GetInt32(1));
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < ArretDepart.Count; i++)
            {
                req = $"Select NomArret From Arret WHERE N_ARRET = {ArretDepart[i]}";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        depart = rdr.GetString(0);
                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                req = $"Select NomArret From Arret WHERE N_ARRET = {ArretTerminus[i]}";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        terminus = rdr.GetString(0);
                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                liste.Add($"{depart} : {terminus}");
            }
            object[] liste2 = liste.ToArray<object>();
            CBOSens.Items.AddRange(liste2);
        }
        private void CBOArret_SelectedValueChanged(object sender, EventArgs e)
        {
            CBOSens.Enabled = true;
        }
        private void cmdAfficher1_Click(object sender, EventArgs e)
        {
            tabHoraire.Visible = true;
        }
        private void cmdQuitterAccueil_Click(object sender, EventArgs e)
        {
            // Demande confirmation à l'utilisateur pour quitter le logiciel
            DialogResult confirmation = MessageBox.Show("Voulez-vous vraiment quitter le logiciel ?", "Quitter le logiciel", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                //Deconnexion de la base de données
                bool connexionFeremer = BDD.fermerConnexion();
                if (connexionFeremer)
                {
                    MessageBox.Show("Deconnexion à la base réussi !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Echec de la déconnexion à la base !");
                    this.Close();
                }
            }
        }
    }
}