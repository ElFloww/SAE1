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

        // Nom de la ligne du RadioBouton qui sera sélectionné et réutilisé dans le formualaie de ModificationLigne
        public static string NomLigneSelection = "";

        // Index du bouton radio sélectionné qui sera utilisé dans le formualaie de ModificationLigne
        public static int indexRadionButtonChecked = 0;

        public modification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procédure d'actualisation d'affichage des lignes dans le panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ActualiserLigne(object sender, EventArgs e)
        {
            // A chaque ouverture du formulaire on supprime le contenu de la liste globale
            ligneBusRadioButton.Clear();

            //On cherche à connaître le nombre de ligne pour savoir le nombre de radiobutton à créer
            int n = 0;
            int nbArret = 0;
            string NomLigne = "";
            List<string> liste = new List<string>();

            string req = $"Select NomLigne,COUNT(ArretLigne.N_Arret) from ArretLigne,Ligne WHERE ArretLigne.N_Ligne = Ligne.N_Ligne GROUP BY ArretLigne.N_Ligne";

            try
            {
                int i = 0;
                MySqlCommand cmd = new MySqlCommand(req, BDD.BDConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                    NomLigne = rdr.GetString(0);
                    nbArret = rdr.GetInt32(1);
                    if (i == 1)
                    {
                        // On ajoute le premier radioButton existant 
                        pnlLigne.Controls["radLigne1"].Text = $"{NomLigne}";
                        pnlLigne.Controls["radLigne1"].Enabled = true;
                        ligneBusRadioButton.Add(radLigne1);
                    }
                    else
                    {   
                        // On crée les autres radioButton
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

                        newOPT.Text = $"{NomLigne}";
                        newOPT.Appearance = Appearance.Button;
                        newOPT.TextAlign = ContentAlignment.MiddleCenter;

                        // On affiche le radioButton
                        pnlLigne.Controls.Add(newOPT);

                        // On ajoute le radion button dans la liste global
                        ligneBusRadioButton.Add(newOPT);
                    }
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            this.Close();
        }

        /// <summary>
        /// Fonction qui renvoie l'index du radioButton actif (checked == true)
        /// </summary>
        /// <returns> L'index du radioButton selectionné</returns>
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
            NomLigneSelection = ligneBusRadioButton[compteur].Text;

            // On renvoie l'index
            return compteur;
        }

        private void cmdSuppression_Click(object sender, EventArgs e)
        {   
            // On récupère l'index du radioButton actif
            indexRadionButtonChecked = renvoieIndexLigneBus();

            int N_Ligne = 0;

            string req = $"Select N_Ligne from Ligne where NomLigne = '{NomLigneSelection}';";
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

            // On ne veut pas que l'utilsiateur modifie les lignes déjà existantes dans la base de données
            if (indexRadionButtonChecked <= 3)
            {
                MessageBox.Show("Impossible de supprimer cette ligne, car il appartient au réseau de base.\nVous pouvez seulement supprimer les lignes que vous avez créé !", "Suppression refusée");
            }
            else // Demande confirmation à l'utilisateur pour supprimer la ligne
            {
                DialogResult confirmation = MessageBox.Show($"Voulez - vous vraiment supprimer la {ligneBusRadioButton[indexRadionButtonChecked].Text} ?", "Suppression de ligne", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
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
                }             
            }
            this.Close();
        }


        private void cmdModifier_Click(object sender, EventArgs e)
        {
            // On récupère l'index du radioButton actif
            indexRadionButtonChecked = renvoieIndexLigneBus();

            // On ne veut pas que l'utilsiateur modifie les lignes déjà existantes dans la base de données
            if(indexRadionButtonChecked <= 3)
            {
                MessageBox.Show("Impossible de modifier cette ligne, car il appartient au réseau de base.\nVous pouvez seulement supprimer les lignes que vous avez créé !", "Modification refusée");
            }
            else
            {
                Form modification = new ModificationLigne();
                modification.ShowDialog();
            }
            this.Close();
        }
    }
}
