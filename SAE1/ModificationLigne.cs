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

        private void ModificationLigne_Load(object sender, EventArgs e)
        {
            string NomLigneSelection = SAE1.modification.NomLigneSelection;
            List<string> Trajet = new List<string>();
            string[] HeureMinute = { };

            // On récupère le nom de la ligne
            txtNomLigne.Tag = NomLigneSelection;
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
            req = $"SELECT COUNT(Ligne.N_Ligne) FROM ArretLigne,Ligne WHERE Ligne.N_Ligne = ArretLigne.N_Ligne AND NomLigne = '{NomLigneSelection}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    nudNbArrets.Tag = rdr.GetInt32(0);
                    nudNbArrets.Value = Convert.ToInt32(nudNbArrets.Tag);
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


            List<int> ArretDepart = new List<int>();
            List<int> ArretTerminus = new List<int>();
            string depart = "";
            string terminus = "";
            req = $"Select N_ArretDepart,N_ArretTerminus,COUNT(*) FROM Trajet,Ligne WHERE Ligne.N_Ligne = Trajet.N_Ligne AND NomLigne = '{NomLigneSelection}' AND N_TypeJour = 1 GROUP BY N_ArretDepart,N_ArretTerminus ORDER BY COUNT(*) DESC LIMIT 2;";
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

            req = $"Select NomArret From Arret WHERE N_ARRET = {ArretDepart[0]}";
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
            int arret_prochain = 0;
            int arret_precedent = ArretDepart[0];
            int compteur = 0;
            string arret = "";
            int TotalHeure = Convert.ToInt32(nudHeureDepart.Value);
            int TotalMinute = Convert.ToInt32(nudMinuteDepart.Value);
            pnlArrets.SuspendLayout();
            do
            {
                try
                {
                    if (compteur == 0) // Première ligne du panel déja présent
                    {
                        arretBusComboBox.Add(CBOArret1);
                        HeureNumericUpDown.Add(NUDHeureDepart1);
                        MinuteNumericUpDown.Add(NUDMinuteDepart1);

                        CBOArret1.Text = depart;
                        NUDHeureDepart1.Value = nudHeureDepart.Value;
                        NUDMinuteDepart1.Value = nudMinuteDepart.Value;
                        compteur++;
                    }
                    req = $"Select * FROM TempsTrajet,Ligne WHERE Ligne.N_Ligne = TempsTrajet.N_Ligne AND NomLigne = '{NomLigneSelection}' AND (N_ArretA = {arret_precedent}) LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        arret_prochain = rdr.GetInt32(2);
                        HeureMinute = rdr.GetString(3).Split(":");

                    }
                    rdr.Close();
                    cmd.Dispose();
                    req = $"Select NomArret From Arret WHERE N_ARRET = {arret_prochain}";
                    try
                    {
                        cmd = new MySqlCommand(req, BDD.BDConnection);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            arret = rdr.GetString(0);
                        }
                        rdr.Close();
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    if (compteur == 1) // Second ligne du panel déja présent
                    {
                        arretBusComboBox.Add(CBOArret2);
                        HeureNumericUpDown.Add(NUDHeureDepart2);
                        MinuteNumericUpDown.Add(NUDMinuteDepart2);

                        CBOArret2.Text = arret;
                        TotalHeure += Convert.ToInt32(HeureMinute[0]);
                        TotalMinute += Convert.ToInt32(HeureMinute[1]);
                        if(TotalMinute > 59)
                        {
                            TotalMinute -= 60;
                            TotalHeure++;
                        }
                        NUDHeureDepart2.Value = Convert.ToInt32(TotalHeure);
                        NUDMinuteDepart2.Value = Convert.ToInt32(TotalMinute);
                    }
                    else // Création des autres lignes dans le panel
                    {
                        if (compteur == 2)
                        {
                            compteur++;
                        }
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
                        //newCBOBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
                        newCBOBox.Text = arret;
                        TotalHeure += Convert.ToInt32(HeureMinute[0]);
                        TotalMinute += Convert.ToInt32(HeureMinute[1]);
                        if (TotalMinute > 59)
                        {
                            TotalMinute -= 60;
                            TotalHeure++;
                        }
                        NUDHeureDepart.Value = Convert.ToInt32(TotalHeure);
                        NUDMinuteDepart.Value = Convert.ToInt32(TotalMinute);
                    }
                    compteur++;

                    arret_precedent = arret_prochain;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } while (arret_prochain != ArretTerminus[0]);
            pnlArrets.ResumeLayout();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?\nVos modifications ne seront pas pris en compte", "Fermeture", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            int N_Ligne = 0;
            string req = $"Select N_Ligne from Ligne where NomLigne = '{txtNomLigne.Tag}';";
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

            // On récupère l'indexe du radioButton actif
            int indexRadionButtonChecked = SAE1.modification.indexRadionButtonChecked;

            req = $"DELETE FROM ArretLigne WHERE N_Ligne = {N_Ligne};";
            List<string> liste = new List<string>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                cmd.ExecuteNonQuery();
                req = $"DELETE FROM Trajet WHERE N_Ligne = {N_Ligne};";
                try
                {
                    cmd = new MySqlCommand(req, BDD.BDConnection);
                    cmd.ExecuteNonQuery();
                    req = $"DELETE FROM TempsTrajet WHERE N_Ligne = {N_Ligne};";
                    try
                    {
                        cmd = new MySqlCommand(req, BDD.BDConnection);
                        cmd.ExecuteNonQuery();
                        req = $"DELETE FROM Ligne WHERE N_Ligne = {N_Ligne};";
                        try
                        {
                            cmd = new MySqlCommand(req, BDD.BDConnection);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                cmd.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Erreur System");
                                cmd.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            req = $"Select Count(N_Ligne) from Ligne;";
            int n = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    n = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            req = $"INSERT INTO Ligne(N_Ligne,NomLigne) VALUES ({n + 1},'{txtNomLigne.Text}')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //ARRET DEPART
            int N_ArretDepart = 0;
            int N_ArretTerminus = 0;
            req = $"Select N_Arret from Arret WHERE NomArret = '{CBOArret1.Text}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    N_ArretDepart = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //ARRET TERMINUS
            req = $"Select N_Arret from Arret WHERE NomArret = '{arretBusComboBox[(int)nudNbArrets.Value - 1].Text}';";
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

            Random aleatoire = new Random();
            int N_Conducteur = aleatoire.Next(1, 30);
            int N_Bus = aleatoire.Next(1, 27);
            int N_TypeJour = 1;
            string HeureDepart = Convert.ToString((int)nudHeureDepart.Value + ":" + (int)nudMinuteDepart.Value);
            //HeureDepart = "10:30";
            req = $"INSERT INTO Trajet(N_Conducteur,N_Bus,N_TypeJour,N_Ligne,HeureDepart,N_ArretDepart,N_ArretTerminus) VALUES ('{N_Conducteur}','{N_Bus}',{N_TypeJour},{n + 1},'{HeureDepart}',{N_ArretDepart},{N_ArretTerminus})";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
 
            for (int i = 0; i < (int)nudNbArrets.Value; i++)
            {
                int N_Arret = 0;
                req = $"SELECT N_Arret FROM Arret WHERE NomArret = '{arretBusComboBox[i].Text}';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        N_Arret = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                req = $"INSERT INTO ArretLigne (N_Ligne,N_Arret) VALUES ({n + 1},{N_Arret});";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            for (int i = 0; i < (int)nudNbArrets.Value - 1; i++)
            {
                int N_ArretA = 0;
                int N_ArretB = 0;
                //RECHERCHE ARRET A
                req = $"Select N_Arret from Arret WHERE NomArret = '{arretBusComboBox[i].Text}';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        N_ArretA = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                //RECHERCHE ARRET B
                req = $"Select N_Arret from Arret WHERE NomArret = '{arretBusComboBox[i + 1].Text}';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        N_ArretB = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                string difference = "";
                int differenceHeure = (int)HeureNumericUpDown[i + 1].Value - (int)HeureNumericUpDown[i].Value;
                int differenceMinute = (int)MinuteNumericUpDown[i + 1].Value - (int)MinuteNumericUpDown[i].Value;
                if (differenceHeure >= 1 || differenceMinute < 0)
                {
                    differenceHeure--;
                    differenceMinute += 60;
                }
                if (differenceMinute < 10)
                {
                    difference = Convert.ToString(differenceHeure + ":0" + differenceMinute);
                }
                else
                {
                    difference = Convert.ToString(differenceHeure + ":" + differenceMinute);
                }
                req = $"INSERT INTO TempsTrajet (N_Ligne,N_ArretA, N_ArretB,tempstrajet,N_Sens) VALUES ({N_Ligne},{N_ArretA},{N_ArretB},'{difference}',1)";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            MessageBox.Show($"{txtNomLigne.Text} à bien été modifié !");
            this.Close();
        }

        private void nudNbArrets_ValueChanged(object sender, EventArgs e)
        {
            //Evt déclencheur : changement de valeur (nudNArrets.ValueChanged)
            //Action : active/désactive les textbox des arrêts, ajoute/supprime
            //         en fonction du nombre d'enfants sélectionné dans nudNbEnfants

            //déclaration des variables 
            int ValeurSelection = (int)nudNbArrets.Value;           //valeur sélectionnée dans le numericUpDown
            int AncienneValeur = Convert.ToInt32(nudNbArrets.Tag);  //précédente valeur du numericUpDown

            //on suspend la logique d'affichage du panel pour y faire des modifs
            pnlArrets.SuspendLayout();
            //si la valeur du NUD est incrémentée
            if(ValeurSelection == AncienneValeur)
            {
                return;
            }
            if (ValeurSelection > AncienneValeur)
            {
                if (ValeurSelection <= 2)
                {
                    pnlArrets.Controls[$"CBOArret{ValeurSelection}"].Enabled = true;
                }
                else
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
                    int CBOY = pnlArrets.Controls[$"CBOArret{ValeurSelection - 1}"].Location.Y + CBODist;
                    /////
                    int NUD1Dist = NUDHeureDepart2.Location.Y - NUDHeureDepart1.Location.Y;
                    int NUD1X = NUDHeureDepart1.Location.X;
                    int NUD1Y = pnlArrets.Controls[$"NUDHeureDepart{ValeurSelection - 1}"].Location.Y + NUD1Dist;
                    /////
                    int NUD2Dist = NUDMinuteDepart2.Location.Y - NUDMinuteDepart1.Location.Y;
                    int NUD2X = NUDMinuteDepart1.Location.X;
                    int NUD2Y = pnlArrets.Controls[$"NUDMinuteDepart{ValeurSelection - 1}"].Location.Y + NUD2Dist;
                    /////
                    int LBLDist = LBLSplit2.Location.Y - LBLSplit1.Location.Y;
                    int LBLX = LBLSplit1.Location.X;
                    int LBLY = pnlArrets.Controls[$"LBLSplit{ValeurSelection - 1}"].Location.Y + LBLDist;

                    //Paramétrage de la nouvelle textbox
                    newCBOBox.Name = $"CBOArret{ValeurSelection}";
                    newCBOBox.Size = new Size(CBOlargeur, CBOhauteur);
                    newCBOBox.Location = new Point(CBOX, CBOY);

                    NUDHeureDepart.Name = $"NUDHeureDepart{ValeurSelection}";
                    NUDHeureDepart.Size = new Size(NUD1largeur, NUD1hauteur);
                    NUDHeureDepart.Location = new Point(NUD1X, NUD1Y);

                    NUDMinuteDepart.Name = $"NUDMinuteDepart{ValeurSelection}";
                    NUDMinuteDepart.Size = new Size(NUD2largeur, NUD2hauteur);
                    NUDMinuteDepart.Location = new Point(NUD2X, NUD2Y);

                    newLabel.Name = $"LBLSplit{ValeurSelection}";
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

                }
                //on reprend la logique d'affichage du panel
            }
            else //Si la valeur du NUD est décrémentée
            {
                this.pnlArrets.Controls[$"CBOArret{AncienneValeur}"].Enter -= new System.EventHandler(this.CBOArret_Enter);
                pnlArrets.Controls.RemoveByKey($"CBOArret{AncienneValeur}");
                pnlArrets.Controls.RemoveByKey($"NUDHeureDepart{AncienneValeur}");
                pnlArrets.Controls.RemoveByKey($"NUDMinuteDepart{AncienneValeur}");
                pnlArrets.Controls.RemoveByKey($"LBLSplit{AncienneValeur}");
            }
            nudNbArrets.Tag = ValeurSelection;
            pnlArrets.ResumeLayout();
        }
    }
}
