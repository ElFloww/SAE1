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

        public void ActualiserLigne(object sender, EventArgs e)
        {
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

            for(int i = 1; i <= n; i++)
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
                if (i <= 4)
                {
                    pnlLigne.Controls[$"radLigne{i}"].Text = $"{NomLigne}                                                  Nombre d'arret(s) : {nbArret}";
                    pnlLigne.Controls[$"radLigne{i}"].Enabled = true;
                }
                else
                {
                    RadioButton newOPT = new RadioButton();

                    int OPThauteur = radLigne1.Size.Height;
                    int OPTlargeur = radLigne1.Size.Width;

                    int OPTDist = radLigne4.Location.Y - radLigne3.Location.Y;
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
    }
}
