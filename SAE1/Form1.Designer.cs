using BDs;
using MySql.Data;
using MySql.Data.MySqlClient;
using SAE1;
namespace SAE1
{
    partial class Form1
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpboxCalcul = new System.Windows.Forms.GroupBox();
            this.lblArretB = new System.Windows.Forms.Label();
            this.lblArretA = new System.Windows.Forms.Label();
            this.cmdAfficher2 = new System.Windows.Forms.Button();
            this.CBOArretA = new System.Windows.Forms.ComboBox();
            this.CBOArretB = new System.Windows.Forms.ComboBox();
            this.grpboxHoraires = new System.Windows.Forms.GroupBox();
            this.lblArret = new System.Windows.Forms.Label();
            this.lblLigne = new System.Windows.Forms.Label();
            this.cmdAfficher1 = new System.Windows.Forms.Button();
            this.CBOLigne = new System.Windows.Forms.ComboBox();
            this.CBOArret = new System.Windows.Forms.ComboBox();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdAdmin = new System.Windows.Forms.Button();
            this.grpboxAffichage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpboxCalcul.SuspendLayout();
            this.grpboxHoraires.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpboxCalcul);
            this.splitContainer1.Panel1.Controls.Add(this.grpboxHoraires);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmdQuitter);
            this.splitContainer1.Panel2.Controls.Add(this.cmdAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.grpboxAffichage);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 540);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 4;
            // 
            // grpboxCalcul
            // 
            this.grpboxCalcul.Controls.Add(this.lblArretB);
            this.grpboxCalcul.Controls.Add(this.lblArretA);
            this.grpboxCalcul.Controls.Add(this.cmdAfficher2);
            this.grpboxCalcul.Controls.Add(this.CBOArretA);
            this.grpboxCalcul.Controls.Add(this.CBOArretB);
            this.grpboxCalcul.Location = new System.Drawing.Point(24, 303);
            this.grpboxCalcul.Name = "grpboxCalcul";
            this.grpboxCalcul.Size = new System.Drawing.Size(305, 177);
            this.grpboxCalcul.TabIndex = 3;
            this.grpboxCalcul.TabStop = false;
            this.grpboxCalcul.Text = "Calcul d\'itinéraire";
            // 
            // lblArretB
            // 
            this.lblArretB.AutoSize = true;
            this.lblArretB.Location = new System.Drawing.Point(29, 79);
            this.lblArretB.Name = "lblArretB";
            this.lblArretB.Size = new System.Drawing.Size(75, 15);
            this.lblArretB.TabIndex = 2;
            this.lblArretB.Text = "Arrêt d\'arrivé";
            // 
            // lblArretA
            // 
            this.lblArretA.AutoSize = true;
            this.lblArretA.Location = new System.Drawing.Point(29, 33);
            this.lblArretA.Name = "lblArretA";
            this.lblArretA.Size = new System.Drawing.Size(86, 15);
            this.lblArretA.TabIndex = 0;
            this.lblArretA.Text = "Arrêt de départ";
            // 
            // cmdAfficher2
            // 
            this.cmdAfficher2.Location = new System.Drawing.Point(216, 136);
            this.cmdAfficher2.Name = "cmdAfficher2";
            this.cmdAfficher2.Size = new System.Drawing.Size(75, 23);
            this.cmdAfficher2.TabIndex = 0;
            this.cmdAfficher2.Text = "Afficher";
            this.cmdAfficher2.UseVisualStyleBackColor = true;
            // 
            // CBOArretA
            // 
            this.CBOArretA.FormattingEnabled = true;
            this.CBOArretA.Location = new System.Drawing.Point(170, 30);
            this.CBOArretA.Name = "CBOArretA";
            this.CBOArretA.Size = new System.Drawing.Size(121, 23);
            this.CBOArretA.TabIndex = 0;
            this.CBOArretA.Enter += new System.EventHandler(this.CBOArretA_Enter);
            // 
            // CBOArretB
            // 
            this.CBOArretB.FormattingEnabled = true;
            this.CBOArretB.Location = new System.Drawing.Point(170, 76);
            this.CBOArretB.Name = "CBOArretB";
            this.CBOArretB.Size = new System.Drawing.Size(121, 23);
            this.CBOArretB.TabIndex = 1;
            this.CBOArretB.Enter += new System.EventHandler(this.CBOArretB_Enter);
            // 
            // grpboxHoraires
            // 
            this.grpboxHoraires.Controls.Add(this.lblArret);
            this.grpboxHoraires.Controls.Add(this.lblLigne);
            this.grpboxHoraires.Controls.Add(this.cmdAfficher1);
            this.grpboxHoraires.Controls.Add(this.CBOLigne);
            this.grpboxHoraires.Controls.Add(this.CBOArret);
            this.grpboxHoraires.Location = new System.Drawing.Point(24, 102);
            this.grpboxHoraires.Name = "grpboxHoraires";
            this.grpboxHoraires.Size = new System.Drawing.Size(305, 169);
            this.grpboxHoraires.TabIndex = 0;
            this.grpboxHoraires.TabStop = false;
            this.grpboxHoraires.Text = "Afficher les horaires";
            // 
            // lblArret
            // 
            this.lblArret.AutoSize = true;
            this.lblArret.Location = new System.Drawing.Point(40, 76);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(33, 15);
            this.lblArret.TabIndex = 2;
            this.lblArret.Text = "Arrêt";
            // 
            // lblLigne
            // 
            this.lblLigne.AutoSize = true;
            this.lblLigne.Location = new System.Drawing.Point(37, 30);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(36, 15);
            this.lblLigne.TabIndex = 0;
            this.lblLigne.Text = "Ligne";
            // 
            // cmdAfficher1
            // 
            this.cmdAfficher1.Enabled = false;
            this.cmdAfficher1.Location = new System.Drawing.Point(216, 136);
            this.cmdAfficher1.Name = "cmdAfficher1";
            this.cmdAfficher1.Size = new System.Drawing.Size(75, 23);
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
            this.CBOLigne.Size = new System.Drawing.Size(121, 23);
            this.CBOLigne.Sorted = true;
            this.CBOLigne.TabIndex = 0;
            this.CBOLigne.Enter += new System.EventHandler(this.CBOLigne_Enter);
            // 
            // CBOArret
            // 
            this.CBOArret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArret.FormattingEnabled = true;
            this.CBOArret.Location = new System.Drawing.Point(170, 76);
            this.CBOArret.Name = "CBOArret";
            this.CBOArret.Size = new System.Drawing.Size(121, 23);
            this.CBOArret.TabIndex = 1;
            this.CBOArret.Enter += new System.EventHandler(this.CBOArret_Enter);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(554, 496);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 2;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.Location = new System.Drawing.Point(39, 496);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(209, 23);
            this.cmdAdmin.TabIndex = 1;
            this.cmdAdmin.Text = "Accéder à l\'interface administrateur";
            this.cmdAdmin.UseVisualStyleBackColor = true;
            // 
            // grpboxAffichage
            // 
            this.grpboxAffichage.Location = new System.Drawing.Point(22, 33);
            this.grpboxAffichage.Name = "grpboxAffichage";
            this.grpboxAffichage.Size = new System.Drawing.Size(625, 447);
            this.grpboxAffichage.TabIndex = 0;
            this.grpboxAffichage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 540);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpboxCalcul.ResumeLayout(false);
            this.grpboxCalcul.PerformLayout();
            this.grpboxHoraires.ResumeLayout(false);
            this.grpboxHoraires.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Splitter splitter1;
        private SplitContainer splitContainer1;
        private GroupBox grpboxHoraires;
        private GroupBox grpboxCalcul;
        private Label lblArretB;
        private Label lblArretA;
        private Button cmdAfficher2;
        private ComboBox CBOArretA;
        private ComboBox CBOArretB;
        private Label lblArret;
        private Label lblLigne;
        private Button cmdAfficher1;
        private ComboBox CBOArret;
        private Button cmdQuitter;
        private Button cmdAdmin;
        private GroupBox grpboxAffichage;
        private ComboBox CBOLigne;
    }
}