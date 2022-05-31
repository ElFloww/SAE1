using BDs;
using MySql.Data;
using MySql.Data.MySqlClient;
using SAE1;
namespace SAE1
{
    partial class frmFilibusAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilibusAccueil));
            this.grpboxHoraires = new System.Windows.Forms.GroupBox();
            this.lblSens = new System.Windows.Forms.Label();
            this.cboSens = new System.Windows.Forms.ComboBox();
            this.lblArret = new System.Windows.Forms.Label();
            this.lblLigne = new System.Windows.Forms.Label();
            this.cmdAfficher1 = new System.Windows.Forms.Button();
            this.CBOLigne = new System.Windows.Forms.ComboBox();
            this.CBOArret = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdQuitterAccueil = new System.Windows.Forms.Button();
            this.cmdAdmin = new System.Windows.Forms.Button();
            this.txtAccueil = new System.Windows.Forms.Label();
            this.CBOArretB = new System.Windows.Forms.ComboBox();
            this.CBOArretA = new System.Windows.Forms.ComboBox();
            this.cmdAfficher2 = new System.Windows.Forms.Button();
            this.lblArretA = new System.Windows.Forms.Label();
            this.lblArretB = new System.Windows.Forms.Label();
            this.grpboxCalcul = new System.Windows.Forms.GroupBox();
            this.grpboxHoraires.SuspendLayout();
            this.grpboxCalcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxHoraires
            // 
            this.grpboxHoraires.Controls.Add(this.lblSens);
            this.grpboxHoraires.Controls.Add(this.cboSens);
            this.grpboxHoraires.Controls.Add(this.lblArret);
            this.grpboxHoraires.Controls.Add(this.lblLigne);
            this.grpboxHoraires.Controls.Add(this.cmdAfficher1);
            this.grpboxHoraires.Controls.Add(this.CBOLigne);
            this.grpboxHoraires.Controls.Add(this.CBOArret);
            this.grpboxHoraires.Location = new System.Drawing.Point(28, 69);
            this.grpboxHoraires.Name = "grpboxHoraires";
            this.grpboxHoraires.Size = new System.Drawing.Size(377, 212);
            this.grpboxHoraires.TabIndex = 4;
            this.grpboxHoraires.TabStop = false;
            this.grpboxHoraires.Text = "Afficher les horaires";
            // 
            // lblSens
            // 
            this.lblSens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSens.Location = new System.Drawing.Point(43, 122);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(69, 23);
            this.lblSens.TabIndex = 4;
            this.lblSens.Text = "Arrêt :";
            // 
            // cboSens
            // 
            this.cboSens.Enabled = false;
            this.cboSens.FormattingEnabled = true;
            this.cboSens.Location = new System.Drawing.Point(170, 122);
            this.cboSens.Name = "cboSens";
            this.cboSens.Size = new System.Drawing.Size(157, 23);
            this.cboSens.TabIndex = 3;
            // 
            // lblArret
            // 
            this.lblArret.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArret.Location = new System.Drawing.Point(43, 76);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(69, 23);
            this.lblArret.TabIndex = 2;
            this.lblArret.Text = "Arrêt :";
            // 
            // lblLigne
            // 
            this.lblLigne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLigne.Location = new System.Drawing.Point(43, 30);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(69, 23);
            this.lblLigne.TabIndex = 0;
            this.lblLigne.Text = "Ligne :";
            // 
            // cmdAfficher1
            // 
            this.cmdAfficher1.Enabled = false;
            this.cmdAfficher1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAfficher1.Location = new System.Drawing.Point(252, 166);
            this.cmdAfficher1.Name = "cmdAfficher1";
            this.cmdAfficher1.Size = new System.Drawing.Size(75, 30);
            this.cmdAfficher1.TabIndex = 0;
            this.cmdAfficher1.Text = "Afficher";
            this.cmdAfficher1.UseVisualStyleBackColor = true;
            // 
            // CBOLigne
            // 
            this.CBOLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOLigne.FormattingEnabled = true;
            this.CBOLigne.Location = new System.Drawing.Point(170, 30);
            this.CBOLigne.Name = "CBOLigne";
            this.CBOLigne.Size = new System.Drawing.Size(157, 23);
            this.CBOLigne.Sorted = true;
            this.CBOLigne.TabIndex = 0;
            this.CBOLigne.SelectedIndexChanged += new System.EventHandler(this.HoraireValidation);
            this.CBOLigne.SelectedValueChanged += new System.EventHandler(this.CBOLigne_SelectedValueChanged);
            this.CBOLigne.Enter += new System.EventHandler(this.CBOLigne_Enter);
            // 
            // CBOArret
            // 
            this.CBOArret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArret.Enabled = false;
            this.CBOArret.FormattingEnabled = true;
            this.CBOArret.Location = new System.Drawing.Point(170, 76);
            this.CBOArret.Name = "CBOArret";
            this.CBOArret.Size = new System.Drawing.Size(157, 23);
            this.CBOArret.TabIndex = 1;
            this.CBOArret.SelectedIndexChanged += new System.EventHandler(this.HoraireValidation);
            this.CBOArret.Enter += new System.EventHandler(this.CBOArret_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(453, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 383);
            this.panel1.TabIndex = 6;
            // 
            // cmdQuitterAccueil
            // 
            this.cmdQuitterAccueil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitterAccueil.Location = new System.Drawing.Point(839, 445);
            this.cmdQuitterAccueil.Name = "cmdQuitterAccueil";
            this.cmdQuitterAccueil.Size = new System.Drawing.Size(75, 30);
            this.cmdQuitterAccueil.TabIndex = 8;
            this.cmdQuitterAccueil.Text = "Quitter";
            this.cmdQuitterAccueil.UseVisualStyleBackColor = true;
            this.cmdQuitterAccueil.Click += new System.EventHandler(this.cmdQuitterAccueil_Click);
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAdmin.Location = new System.Drawing.Point(453, 445);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(245, 30);
            this.cmdAdmin.TabIndex = 9;
            this.cmdAdmin.Text = "Accéder à l\'interface administrateur";
            this.cmdAdmin.UseVisualStyleBackColor = true;
            this.cmdAdmin.Click += new System.EventHandler(this.cmdAdmin_Click);
            // 
            // txtAccueil
            // 
            this.txtAccueil.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccueil.Location = new System.Drawing.Point(28, 9);
            this.txtAccueil.Name = "txtAccueil";
            this.txtAccueil.Size = new System.Drawing.Size(380, 33);
            this.txtAccueil.TabIndex = 10;
            this.txtAccueil.Text = "Accueil";
            this.txtAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBOArretB
            // 
            this.CBOArretB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArretB.FormattingEnabled = true;
            this.CBOArretB.Location = new System.Drawing.Point(170, 76);
            this.CBOArretB.Name = "CBOArretB";
            this.CBOArretB.Size = new System.Drawing.Size(157, 23);
            this.CBOArretB.TabIndex = 1;
            this.CBOArretB.SelectedValueChanged += new System.EventHandler(this.ItineraireValidation);
            this.CBOArretB.Enter += new System.EventHandler(this.CBOArretB_Enter);
            // 
            // CBOArretA
            // 
            this.CBOArretA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArretA.FormattingEnabled = true;
            this.CBOArretA.Location = new System.Drawing.Point(170, 30);
            this.CBOArretA.Name = "CBOArretA";
            this.CBOArretA.Size = new System.Drawing.Size(157, 23);
            this.CBOArretA.TabIndex = 0;
            this.CBOArretA.SelectedValueChanged += new System.EventHandler(this.ItineraireValidation);
            this.CBOArretA.Enter += new System.EventHandler(this.CBOArretA_Enter);
            // 
            // cmdAfficher2
            // 
            this.cmdAfficher2.Enabled = false;
            this.cmdAfficher2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAfficher2.Location = new System.Drawing.Point(252, 116);
            this.cmdAfficher2.Name = "cmdAfficher2";
            this.cmdAfficher2.Size = new System.Drawing.Size(75, 30);
            this.cmdAfficher2.TabIndex = 0;
            this.cmdAfficher2.Text = "Afficher";
            this.cmdAfficher2.UseVisualStyleBackColor = true;
            this.cmdAfficher2.Leave += new System.EventHandler(this.ItineraireValidation);
            // 
            // lblArretA
            // 
            this.lblArretA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArretA.Location = new System.Drawing.Point(29, 30);
            this.lblArretA.Name = "lblArretA";
            this.lblArretA.Size = new System.Drawing.Size(115, 23);
            this.lblArretA.TabIndex = 0;
            this.lblArretA.Text = "Arrêt de départ :";
            // 
            // lblArretB
            // 
            this.lblArretB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArretB.Location = new System.Drawing.Point(29, 76);
            this.lblArretB.Name = "lblArretB";
            this.lblArretB.Size = new System.Drawing.Size(115, 23);
            this.lblArretB.TabIndex = 2;
            this.lblArretB.Text = "Arrêt d\'arrivé :";
            // 
            // grpboxCalcul
            // 
            this.grpboxCalcul.Controls.Add(this.lblArretB);
            this.grpboxCalcul.Controls.Add(this.lblArretA);
            this.grpboxCalcul.Controls.Add(this.cmdAfficher2);
            this.grpboxCalcul.Controls.Add(this.CBOArretA);
            this.grpboxCalcul.Controls.Add(this.CBOArretB);
            this.grpboxCalcul.Location = new System.Drawing.Point(28, 300);
            this.grpboxCalcul.Name = "grpboxCalcul";
            this.grpboxCalcul.Size = new System.Drawing.Size(380, 175);
            this.grpboxCalcul.TabIndex = 5;
            this.grpboxCalcul.TabStop = false;
            this.grpboxCalcul.Text = "Calcul d\'itinéraire";
            // 
            // frmFilibusAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.txtAccueil);
            this.Controls.Add(this.cmdAdmin);
            this.Controls.Add(this.cmdQuitterAccueil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpboxCalcul);
            this.Controls.Add(this.grpboxHoraires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilibusAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filibus - Réseau de transport urbain de Chartres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxHoraires.ResumeLayout(false);
            this.grpboxCalcul.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpboxHoraires;
        private Label lblArret;
        private Label lblLigne;
        private Button cmdAfficher1;
        private ComboBox CBOLigne;
        private ComboBox CBOArret;
        private Panel panel1;
        private Button cmdQuitterAccueil;
        private Button cmdAdmin;
        private Label txtAccueil;
        private Label lblSens;
        private ComboBox cboSens;
        private ComboBox CBOArretB;
        private ComboBox CBOArretA;
        private Button cmdAfficher2;
        private Label lblArretA;
        private Label lblArretB;
        private GroupBox grpboxCalcul;
    }
}