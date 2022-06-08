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

            // On récupère toutes les lignes de bus 
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

            // On récupère tous les arrêts de bus que la ligne utilise 
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

            // On récupère tous les arrêts de bus sauf celui déjà utilisé dans l'arrêt B
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

            // On récupère tous les arrêts de bus sauf celui déjà utilisé dans l'arrêt A
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

        // Les deux champs doivent être obligatoirement entré
        private void ItineraireValidation(object sender, EventArgs e)
        {
            if (CBOArretA.Text != "" && CBOArretB.Text != "")
            {
                cmdAfficher2.Enabled = true;
            }
        }

        // Les trois champs doivent être obligatoirement entré
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

        // A chaque changement de ligne, on supprime le contenu des autres champs
        private void CBOLigne_SelectedValueChanged(object sender, EventArgs e)
        {
            CBOArret.Text = null;
            CBOSens.Text = null;
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

            // On récupère les sens du trajet de la ligne de bus (seulement pour les trajets déjà présent dans la base)
            // En effet, les bus peuvent faire des aller-retour, il y a donc deux sens
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

            // On récupère l'arrêt de départ et le terminus
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

        // Affichage des horaires
        private void cmdAfficher1_Click(object sender, EventArgs e)
        {
            int N_Arret_Prochain = 0;
            int N_Arret_Actuel = 0;
            int N_Arret_Precedent = 0;
            int N_Arret_Objectif = 0;
            int Heure_Total = 0;
            int Minute_Total = 0;
            int N_Ligne = 0;

            // On récupère l'index de la ligne de bus
            string req = $"Select N_Ligne from Ligne where NomLigne = '{CBOLigne.Text}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    N_Ligne = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // On récupère lindedx de l'arrêt de bus 
            req = $"Select N_Arret from Arret where NomArret = '{CBOArret.Text}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    N_Arret_Objectif = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // On récupère le sens
            List<int> ArretDepart = new List<int>();
            List<int> ArretTerminus = new List<int>();

            req = $"Select N_ArretDepart,N_ArretTerminus,COUNT(*) FROM Trajet WHERE N_Ligne = {N_Ligne} AND N_TypeJour = 1 GROUP BY N_ArretDepart,N_ArretTerminus ORDER BY COUNT(*) DESC LIMIT 2;";
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

            /*__________________________________________________________________________LE SENS_________________________________________________________*/
            string[] Sens = { };
            string CboTxt = CBOSens.Text;
            Sens = CboTxt.Split(":");

            int N_ArretTerminus = 0;
            int N_ArretDepart = 0;

            req = $"Select N_Arret from Arret where NomArret = '{Sens[0]}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    N_Arret_Actuel = rdr.GetInt32(0);
                    N_ArretDepart = N_Arret_Actuel;
                }
                rdr.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            string terminus = Sens[1];
            terminus = terminus.Remove(0, 1);
            req = $"Select N_Arret from Arret where NomArret = '{terminus}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    N_ArretTerminus = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            bool BOOLSensUnique = false;
            int sens = 0;

            do
            {
                try
                {
                    if (N_Arret_Actuel != N_Arret_Objectif)
                    {
                        req = $"Select * FROM TempsTrajet WHERE N_Ligne = {N_Ligne} AND (N_ArretA = {N_Arret_Actuel} OR N_ArretB = {N_Arret_Actuel}) ORDER BY N_Sens;";

                        MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        int Naa, Nab;
                        string[] HeureMinute = { };

                        while (rdr.Read())
                        {
                            Naa = rdr.GetInt32(1);
                            Nab = rdr.GetInt32(2);
                            sens = rdr.GetInt32(4);

                            if (sens == 1 && !BOOLSensUnique)
                            {
                                if (Naa != N_Arret_Precedent && Nab != N_Arret_Precedent)
                                {
                                    if (Naa == N_Arret_Actuel)
                                    {
                                        N_Arret_Prochain = Nab;
                                    }
                                    else
                                    {
                                        N_Arret_Prochain = Naa;
                                    }

                                    HeureMinute = rdr.GetString(3).Split(":");
                                    Heure_Total += Convert.ToInt32(HeureMinute[0]);
                                    Minute_Total += Convert.ToInt32(HeureMinute[1]);

                                    if (Minute_Total >= 60)
                                    {
                                        Minute_Total -= 60;
                                        Heure_Total++;
                                    }

                                    BOOLSensUnique = true;
                                }
                            }
                            else if (sens == 2 && !BOOLSensUnique && Naa == N_Arret_Actuel)
                            {
                                BOOLSensUnique = true;
                                N_Arret_Prochain = Nab;
                                HeureMinute = rdr.GetString(3).Split(":");
                                Heure_Total += Convert.ToInt32(HeureMinute[0]);
                                Minute_Total += Convert.ToInt32(HeureMinute[1]);

                                if (Minute_Total >= 60)
                                {
                                    Minute_Total -= 60;
                                    Heure_Total++;
                                }
                            }
                        }

                        rdr.Close();
                        cmd.Dispose();
                        N_Arret_Precedent = N_Arret_Actuel;
                        N_Arret_Actuel = N_Arret_Prochain;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                BOOLSensUnique = false;
            } while(N_Arret_Objectif != N_Arret_Actuel && N_Arret_Actuel != N_ArretTerminus);

            if(N_Arret_Actuel == N_ArretTerminus && N_Arret_Objectif != N_ArretTerminus)
            {
                MessageBox.Show("L'arret n'est pas déservi dans ce sens");
            }
            else
            {
                tabHoraire.SuspendLayout();
                tabHoraire.Visible = false;
                tabHoraire.Controls.Clear();

                for (int i = 0; i < 24; i++)
                {
                    Label nom = new Label();
                    nom.Text = $"{i}h";
                    nom.TextAlign = ContentAlignment.MiddleCenter;
                    tabHoraire.Controls.Add(nom, i, 0);
                }

                string[] HeureMinute = { };
                int heurepassage = 0;
                int minutepassage = 0;

                req = $"Select * from Trajet WHERE N_Ligne = {N_Ligne} AND N_TypeJour = 1 AND N_ArretDepart = {N_ArretDepart} ORDER BY HeureDepart;";

                try
                {
                    int ind0 = 1, ind1 = 1, ind2 = 1, ind3 = 1, ind4 = 1, ind5 = 1, ind6 = 1, ind7 = 1, ind8 = 1, ind9 = 1, ind10 = 1, ind11 = 1, ind12 = 1, ind13 = 1, ind14 = 1, ind15 = 1, ind16 = 1, ind17 = 1, ind18 = 1, ind19 = 1, ind20 = 1, ind21 = 1, ind22 = 1, ind23 = 1;
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        HeureMinute = rdr.GetString(4).Split(":");
                        heurepassage = Heure_Total + Convert.ToInt32(HeureMinute[0]);
                        minutepassage = Minute_Total + Convert.ToInt32(HeureMinute[1]);

                        if(minutepassage >= 60)
                        {
                            minutepassage -= 60;
                            heurepassage++;
                        }

                        Label nom = new Label();
                        nom.Text = Convert.ToString(minutepassage);
                        nom.TextAlign = ContentAlignment.MiddleCenter;

                        switch (heurepassage)
                        {
                            case 0:
                                tabHoraire.Controls.Add(nom, 0, ind0);
                                ind0++;
                                break;
                            case 1:
                                tabHoraire.Controls.Add(nom, 1, ind1);
                                ind1++;
                                break;
                            case 2:
                                tabHoraire.Controls.Add(nom, 2, ind2);
                                ind2++;
                                break;
                            case 3:
                                tabHoraire.Controls.Add(nom, 3, ind3);
                                ind3++;
                                break;
                            case 4:
                                tabHoraire.Controls.Add(nom, 4, ind4);
                                ind4++;
                                break;
                            case 5:
                                tabHoraire.Controls.Add(nom, 5, ind5);
                                ind5++;
                                break;
                            case 6:
                                tabHoraire.Controls.Add(nom, 6, ind6);
                                ind6++;
                                break;
                            case 7:
                                tabHoraire.Controls.Add(nom, 7, ind7);
                                ind7++;
                                break;
                            case 8:
                                tabHoraire.Controls.Add(nom, 8, ind8);
                                ind8++;
                                break;
                            case 9:
                                tabHoraire.Controls.Add(nom, 9, ind9);
                                ind9++;
                                break;
                            case 10:
                                tabHoraire.Controls.Add(nom, 10, ind10);
                                ind10++;
                                break;
                            case 11:
                                tabHoraire.Controls.Add(nom, 11, ind11);
                                ind11++;
                                break;
                            case 12:
                                tabHoraire.Controls.Add(nom, 12, ind12);
                                ind12++;
                                break;
                            case 13:
                                tabHoraire.Controls.Add(nom, 13, ind13);
                                ind13++;
                                break;
                            case 14:
                                tabHoraire.Controls.Add(nom, 14, ind14);
                                ind14++;
                                break;
                            case 15:
                                tabHoraire.Controls.Add(nom, 15, ind15);
                                ind15++;
                                break;
                            case 16:
                                tabHoraire.Controls.Add(nom, 16, ind16);
                                ind16++;
                                break;
                            case 17:
                                tabHoraire.Controls.Add(nom, 17, ind17);
                                ind17++;
                                break;
                            case 18:
                                tabHoraire.Controls.Add(nom, 18, ind18);
                                ind18++;
                                break;
                            case 19:
                                tabHoraire.Controls.Add(nom, 19, ind19);
                                ind19++;
                                break;
                            case 20:
                                tabHoraire.Controls.Add(nom, 20, ind20);
                                ind20++;
                                break;
                            case 21:
                                tabHoraire.Controls.Add(nom, 21, ind21);
                                ind21++;
                                break;
                            case 22:
                                tabHoraire.Controls.Add(nom, 22, ind22);
                                ind22++;
                                break;
                            case 23:
                                tabHoraire.Controls.Add(nom, 23, ind23);
                                ind23++;
                                break;
                            default:
                                break;
                        }

                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                tabHoraire.ResumeLayout();
                tabHoraire.Visible = true;
            }
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

        private void cmdAfficher2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'est pas encore présente !\nVeuillez nous excuser pour la gène occasionnée");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}