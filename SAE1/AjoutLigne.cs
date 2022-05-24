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
    public partial class AjoutLigne : Form
    {
        public AjoutLigne()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
            if (ValeurSelection > AncienneValeur)
            {
                if (ValeurSelection <= 2)
                    pnlArrets.Controls[$"CBOArret{ValeurSelection}"].Enabled = true;
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
                }
                //on reprend la logique d'affichage du panel
                pnlArrets.ResumeLayout();
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
        }

        private void CBOArret_Enter(object sender, EventArgs e)
        {
            ComboBox cbobox = (ComboBox)sender;
            cbobox.Items.Clear();
            List<string> lignes = new List<string>();
            string req = $"Select NomArret from ArretLigne,Arret,Ligne WHERE ArretLigne.N_Arret = Arret.N_Arret AND ArretLigne.N_Ligne = Ligne.N_Ligne ORDER BY NomArret";

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

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?\nVos modifications ne seront pas pris en compte", "Fermeture", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNomLigne_Validating(object sender, CancelEventArgs e)
        {
            List<string> lignes = new List<string>();
            string req = "Select NomLigne from Ligne";
            bool testComparaison = false;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // On teste le nom pour savoir s'il est unique ou pas
            for (int i = 0; i < lignes.Count; i++)
            {
                if (lignes[i] == txtNomLigne.Text)
                    testComparaison = true;
            }

            if(testComparaison == true || String.IsNullOrWhiteSpace(txtNomLigne.Text))
            {
                errorProviderNomLigne.SetError(txtNomLigne, "Nom de ligne déjà utilisé ou le champ est vide.");
                e.Cancel = true;
                cmdValider.Enabled = false;
            }
            else
            {
                errorProviderNomLigne.SetError(txtNomLigne, null);
                e.Cancel = false;
                cmdValider.Enabled = true;
            }
        }          
    }
}
