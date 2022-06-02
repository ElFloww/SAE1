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
using SAE1;

namespace SAE1
{
    public partial class ModificationLigne : Form
    {
        public List<ComboBox> arretBusComboBox = new List<ComboBox>();
        public List<NumericUpDown> HeureNumericUpDown = new List<NumericUpDown>();
        public List<NumericUpDown> MinuteNumericUpDown = new List<NumericUpDown>();

        public ModificationLigne()
        {
            InitializeComponent();
        }

        private void CBOArret_Enter(object sender, EventArgs e)
        {
            ComboBox cbobox = (ComboBox)sender;
            cbobox.Items.Clear();
            List<string> lignes = new List<string>();
            string req = $"Select NomArret from Arret ORDER BY NomArret";

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
                cbobox.Items.AddRange(liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void CalculLigne(String NomLigne)
        {
            List<int> ArretLigne = new List<int>();
            List<int> liste = new List<int>();
            List<string> listeArretTerminus = new List<string>();
            List<int> ArretDepart = new List<int>();
            List<int> ArretTerminus = new List<int>();
            string depart = "";
            string terminus = "";
            string req = $"Select N_ArretDepart,N_ArretTerminus,COUNT(*) FROM Trajet,Ligne WHERE Ligne.N_Ligne = Trajet.N_Ligne AND NomLigne = '{NomLigne}' AND N_TypeJour = 1 GROUP BY N_ArretDepart,N_ArretTerminus ORDER BY COUNT(*) DESC LIMIT 2;";
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
                req = $"Select NomArret From Arret WHERE N_ARRET = {ArretTerminus[0]}";
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
                listeArretTerminus.Add($"{depart} : {terminus}");
            }

            /*__________________________________________________________________________________________________________*/

            req = $"SELECT N_Arret FROM ArretLigne,Ligne WHERE Ligne.N_Ligne = ArretLigne.N_Ligne AND NomLigne = '{NomLigne}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ArretLigne.Add(rdr.GetInt32(0));
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            /*_____________________________________________________________________________________________________________*/
            int prochain_arret = 0;
            int precedent_arret = 0;
            req = $"Select * From TempsTrajet WHERE N_ArretA = {ArretDepart[0]} OR N_ArretB = {ArretDepart[0]}";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    precedent_arret = ArretDepart[0];
                    prochain_arret = rdr.GetInt32(1);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            do
            {
                prochain_arret = 0;
            }
            while (prochain_arret != ArretTerminus[0]);
        }

        private void ModificationLigne_Load(object sender, EventArgs e)
        {
            string NomLigneSelection = SAE1.modification.NomLigneSelection;
            List<string> Trajet = new List<string>();
            string[] HeureMinute = { };

            // On récupère le nom de la ligne
            string req = $"Select NomLigne from Ligne where NomLigne = '{NomLigneSelection}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtNomLigne.Text = rdr.GetString(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // On récupère le nombre d'arrêt
            req = $"SELECT COUNT(Ligne.N_Ligne) FROM ArretLigne,Ligne WHERE Ligne.N_Ligne = ArretLigne.N_Ligne AND NomLigne = '{NomLigneSelection}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    nudNbArrets.Value = rdr.GetInt32(0);
                    nudNbArrets.Tag = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // On récupère l'heure de début de la ligne
            req = $"SELECT MIN(HeureDepart) FROM Trajet,Ligne WHERE Ligne.N_Ligne = Trajet.N_Ligne AND NomLigne = '{NomLigneSelection}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    HeureMinute = rdr.GetString(0).Split(":");
                }
                rdr.Close();
                cmd.Dispose();

                nudHeureDepart.Value = Convert.ToInt32(HeureMinute[0]);
                nudMinuteDepart.Value = Convert.ToInt32(HeureMinute[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Ajout dynamique des arrêts de bus ainsi que les horaires 
            req = $"SELECT DISTINCT NomArret, HeureDepart FROM Arret, Trajet WHERE Arret.N_Arret = Trajet.N_ArretDepart and NomLigne = '{NomLigneSelection}'";
            int compteur = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    pnlArrets.SuspendLayout();
                    if (compteur == 0) // Première ligne du panel déja présent
                    {
                        arretBusComboBox.Add(CBOArret1);
                        HeureNumericUpDown.Add(NUDHeureDepart1);
                        MinuteNumericUpDown.Add(NUDMinuteDepart1);

                        CBOArret1.Text = rdr.GetString(0);
                        HeureMinute = rdr.GetString(1).Split(":");
                        NUDHeureDepart1.Value = rdr.GetInt32(HeureMinute[0]);
                        NUDHeureDepart1.Value = rdr.GetInt32(HeureMinute[1]);

                        compteur++;
                    }
                    else if (compteur == 1) // Second ligne du panel déja présent
                    {
                        arretBusComboBox.Add(CBOArret2);
                        HeureNumericUpDown.Add(NUDHeureDepart2);
                        MinuteNumericUpDown.Add(NUDMinuteDepart2);

                        CBOArret2.Text = rdr.GetString(0);
                        HeureMinute = rdr.GetString(1).Split(":");
                        NUDHeureDepart2.Value = rdr.GetInt32(HeureMinute[0]);
                        NUDHeureDepart2.Value = rdr.GetInt32(HeureMinute[1]);

                        compteur++;
                    }
                    else // Création des autres lignes dans le panel
                    {
                        //création des nouveaux éléments
                        ComboBox newCBOBox = new ComboBox();
                        NumericUpDown NUDHeureDepart = new NumericUpDown();
                        NumericUpDown NUDMinuteDepart = new NumericUpDown();
                        Label newLabel = new Label();

                        //définition d'une largeur et d'une hauteur basée sur les éléments prééxistant
                        int CBOhauteur = CBOArret1.Size.Height;
                        int CBOlargeur = CBOArret1.Size.Width;
                        int NUD1hauteur = NUDHeureDepart1.Size.Height;
                        int NUD1largeur = NUDHeureDepart1.Size.Width;
                        int NUD2hauteur = NUDMinuteDepart1.Size.Height;
                        int NUD2largeur = NUDMinuteDepart1.Size.Width;
                        int LBLhauteur = LBLSplit1.Size.Height;
                        int LBLlargeur = LBLSplit1.Size.Width;

                        //définition des variables de position et distance basée sur les textbox txtEnfant1 et txtEnfant2
                        int CBODist = CBOArret2.Location.Y - CBOArret1.Location.Y;
                        int CBOX = CBOArret1.Location.X;
                        int CBOY = pnlArrets.Controls[$"CBOArret{compteur - 1}"].Location.Y + CBODist;
                        /////
                        int NUD1Dist = NUDHeureDepart2.Location.Y - NUDHeureDepart1.Location.Y;
                        int NUD1X = NUDHeureDepart1.Location.X;
                        int NUD1Y = pnlArrets.Controls[$"NUDHeureDepart{compteur - 1}"].Location.Y + NUD1Dist;
                        /////
                        int NUD2Dist = NUDMinuteDepart2.Location.Y - NUDMinuteDepart1.Location.Y;
                        int NUD2X = NUDMinuteDepart1.Location.X;
                        int NUD2Y = pnlArrets.Controls[$"NUDMinuteDepart{compteur - 1}"].Location.Y + NUD2Dist;
                        /////
                        int LBLDist = LBLSplit2.Location.Y - LBLSplit1.Location.Y;
                        int LBLX = LBLSplit1.Location.X;
                        int LBLY = pnlArrets.Controls[$"LBLSplit{compteur - 1}"].Location.Y + LBLDist;

                        //Paramétrage de la nouvelle textbox
                        newCBOBox.Name = $"CBOArret{compteur}";
                        newCBOBox.Size = new Size(CBOlargeur, CBOhauteur);
                        newCBOBox.Location = new Point(CBOX, CBOY);

                        // Paramétrage des nud pour les heures et minutes
                        NUDHeureDepart.Name = $"NUDHeureDepart{compteur}";
                        NUDHeureDepart.Size = new Size(NUD1largeur, NUD1hauteur);
                        NUDHeureDepart.Location = new Point(NUD1X, NUD1Y);

                        NUDMinuteDepart.Name = $"NUDMinuteDepart{compteur}";
                        NUDMinuteDepart.Size = new Size(NUD2largeur, NUD2hauteur);
                        NUDMinuteDepart.Location = new Point(NUD2X, NUD2Y);

                        newLabel.Name = $"LBLSplit{compteur}";
                        newLabel.Size = new Size(LBLlargeur, LBLhauteur);
                        newLabel.Location = new Point(LBLX, LBLY);

                        //définition du style et de la couleur de la police
                        newCBOBox.Font = new Font(newCBOBox.Font, FontStyle.Regular);
                        newCBOBox.ForeColor = Color.Black;

                        NUDHeureDepart.Font = new Font(NUDHeureDepart.Font, FontStyle.Regular);
                        NUDHeureDepart.ForeColor = Color.Black;

                        NUDMinuteDepart.Font = new Font(NUDMinuteDepart.Font, FontStyle.Regular);
                        NUDMinuteDepart.ForeColor = Color.Black;

                        newLabel.Font = new Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        newLabel.ForeColor = Color.Black;

                        //Associer les événements enter et leave de la nouvelle textbox aux procédures dédiées
                        newCBOBox.Enter += new System.EventHandler(this.CBOArret_Enter);
                        NUDHeureDepart.Minimum = 0;
                        NUDHeureDepart.Maximum = 23;
                        NUDMinuteDepart.Minimum = 0;
                        NUDMinuteDepart.Maximum = 59;
                        newCBOBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        newLabel.Text = "/";

                        //Ajout des elements au panel pour l'afficher à l'écran
                        pnlArrets.Controls.Add(newCBOBox);
                        pnlArrets.Controls.Add(NUDHeureDepart);
                        pnlArrets.Controls.Add(NUDMinuteDepart);
                        pnlArrets.Controls.Add(newLabel);

                        arretBusComboBox.Add(newCBOBox);
                        HeureNumericUpDown.Add(NUDHeureDepart);
                        MinuteNumericUpDown.Add(NUDMinuteDepart);

                        // Ajout des valeurs dans le nouveau controle
                        newCBOBox.Text = rdr.GetString(0);
                        HeureMinute = rdr.GetString(1).Split(":");
                        NUDHeureDepart.Value = rdr.GetInt32(HeureMinute[0]);
                        NUDMinuteDepart.Value = rdr.GetInt32(HeureMinute[1]);

                        compteur++;
                    }
                    pnlArrets.ResumeLayout();
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?\nVos modifications ne seront pas pris en compte", "Fermeture", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
