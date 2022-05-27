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
        // Liste globale qui stockera toutes les radiobouttons des lignes de bus lors du chargement du formulaire
        public List<RadioButton> ligneBusRadioButton = new List<RadioButton>();

        public modification()
        {
            InitializeComponent();
        }

        public void ActualiserLigne(object sender, EventArgs e)
        {
            // A chaque ouverture du formulaire on supprime le contenu de la liste globale
            ligneBusRadioButton.Clear();
            //On cherche à connaître le nombre de ligne pour savoir le nombre de radiobutton à créer
            string req = $"Select Count(N_Ligne) from Ligne;";
            int n = 0;
            int nbArret = 0;
            string NomLigne = "";
            List<string> liste = new List<string>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
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

            for (int i = 1; i <= n; i++)
            {
                liste.Clear();
                req = $"Select NomLigne,COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne AND ArretLigne.N_Ligne = {i};";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        NomLigne = rdr.GetString(0);
                        nbArret = rdr.GetInt32(1);
                    }

                    rdr.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (i == 1)
                {
                    pnlLigne.Controls["radLigne1"].Text = $"{NomLigne}                                                  Nombre d'arret(s) : {nbArret}";
                    pnlLigne.Controls["radLigne1"].Enabled = true;
                    // On ajoute le premier radioButton
                    ligneBusRadioButton.Add(radLigne1);
                }
                else
                {
                    RadioButton newOPT = new RadioButton();

                    int OPThauteur = radLigne1.Size.Height;
                    int OPTlargeur = radLigne1.Size.Width;

                    int OPTDist = radLigne1.Location.Y - cmdCreation.Location.Y;
                    int OPTx = radLigne1.Location.X;
                    int OPTy = pnlLigne.Controls[$"radLigne{i - 1}"].Location.Y + OPTDist;

                    newOPT.Name = $"radLigne{i}";
                    newOPT.Size = new Size(OPTlargeur, OPThauteur);
                    newOPT.Location = new Point(OPTx, OPTy);

                    newOPT.Font = new Font(newOPT.Font, FontStyle.Regular);
                    newOPT.ForeColor = Color.Black;

                    newOPT.Text = $"{NomLigne}                                                  Nombre d'arret(s) : {nbArret}";
                    newOPT.Appearance = Appearance.Button;
                    newOPT.TextAlign = ContentAlignment.MiddleCenter;

                    pnlLigne.Controls.Add(newOPT);

                    // On ajoute le radion button dans la liste global
                    ligneBusRadioButton.Add(newOPT);
                }
            }
            pnlLigne.ResumeLayout();
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

        // Fonction qui renvoie l'index du radioButton actif (checked == true)
        public int renvoieIndexLigneBus()
        {
            bool condArret = true;
            int compteur = 0;

            // On cherche quel radioBoutton est actif
            while (condArret)
            {
                if (ligneBusRadioButton[compteur].Checked == true)
                    condArret = false;
                else
                    compteur++;
            }

            // On renvoie l'index
            return compteur;
        }

        private void cmdSuppression_Click(object sender, EventArgs e)
        {   
            // On récupère l'indexe du radioButton actif
            int indexRadionButtonChecked = renvoieIndexLigneBus();

            // Demande confirmation à l'utilisateur pour supprimer la ligne
            if(indexRadionButtonChecked <= 3)
            {
                MessageBox.Show("Impossible de supprimer cette ligne, car c'est une ligne de base du réseau\n Vous pouvez seulement supprimer les lignes que vous avez créer !");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show($"Voulez - vous vraiment supprimer la {ligneBusRadioButton[indexRadionButtonChecked].Text} ?", "Suppression de ligne", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string req = $"DELETE FROM ArretLigne WHERE N_Ligne = {indexRadionButtonChecked + 1};";
                    List<string> liste = new List<string>();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                        cmd.ExecuteNonQuery();
                        req = $"DELETE FROM Trajet WHERE N_Ligne = {indexRadionButtonChecked + 1};";
                        try
                        {
                            cmd = new MySqlCommand(req, BDD.BDConnection);
                            cmd.ExecuteNonQuery();
                            req = $"DELETE FROM Ligne WHERE N_Ligne = {indexRadionButtonChecked + 1};";
                            try
                            {
                                cmd = new MySqlCommand(req, BDD.BDConnection);
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("La ligne à été supprimée");
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
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            Form modification = new ModificationLigne();
            modification.ShowDialog();
        }
    }
}
