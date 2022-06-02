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
            this.CBOSens = new System.Windows.Forms.ComboBox();
            this.lblArret = new System.Windows.Forms.Label();
            this.lblLigne = new System.Windows.Forms.Label();
            this.cmdAfficher1 = new System.Windows.Forms.Button();
            this.CBOLigne = new System.Windows.Forms.ComboBox();
            this.CBOArret = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabHoraire = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl13h = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl11h = new System.Windows.Forms.Label();
            this.lbl12h = new System.Windows.Forms.Label();
            this.lbl9h = new System.Windows.Forms.Label();
            this.lbl10h = new System.Windows.Forms.Label();
            this.lbl7h = new System.Windows.Forms.Label();
            this.lbl8h = new System.Windows.Forms.Label();
            this.lbl6h = new System.Windows.Forms.Label();
            this.lbl5h = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.tabHoraire.SuspendLayout();
            this.grpboxCalcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxHoraires
            // 
            this.grpboxHoraires.Controls.Add(this.lblSens);
            this.grpboxHoraires.Controls.Add(this.CBOSens);
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
            this.lblSens.Text = "Sens :";
            // 
            // CBOSens
            // 
            this.CBOSens.Enabled = false;
            this.CBOSens.FormattingEnabled = true;
            this.CBOSens.Location = new System.Drawing.Point(118, 122);
            this.CBOSens.Name = "CBOSens";
            this.CBOSens.Size = new System.Drawing.Size(209, 23);
            this.CBOSens.TabIndex = 3;
            this.CBOSens.SelectedIndexChanged += new System.EventHandler(this.HoraireValidation);
            this.CBOSens.Enter += new System.EventHandler(this.CBOSens_Enter);
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
            this.cmdAfficher1.Click += new System.EventHandler(this.cmdAfficher1_Click);
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
            this.panel1.Controls.Add(this.tabHoraire);
            this.panel1.Location = new System.Drawing.Point(453, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 383);
            this.panel1.TabIndex = 6;
            // 
            // tabHoraire
            // 
            this.tabHoraire.AutoScroll = true;
            this.tabHoraire.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabHoraire.ColumnCount = 18;
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.Controls.Add(this.label9, 17, 0);
            this.tabHoraire.Controls.Add(this.label6, 15, 0);
            this.tabHoraire.Controls.Add(this.label7, 16, 0);
            this.tabHoraire.Controls.Add(this.label4, 13, 0);
            this.tabHoraire.Controls.Add(this.label5, 14, 0);
            this.tabHoraire.Controls.Add(this.lbl13h, 8, 0);
            this.tabHoraire.Controls.Add(this.label8, 9, 0);
            this.tabHoraire.Controls.Add(this.lbl11h, 6, 0);
            this.tabHoraire.Controls.Add(this.lbl12h, 7, 0);
            this.tabHoraire.Controls.Add(this.lbl9h, 4, 0);
            this.tabHoraire.Controls.Add(this.lbl10h, 5, 0);
            this.tabHoraire.Controls.Add(this.lbl7h, 2, 0);
            this.tabHoraire.Controls.Add(this.lbl8h, 3, 0);
            this.tabHoraire.Controls.Add(this.lbl6h, 1, 0);
            this.tabHoraire.Controls.Add(this.lbl5h, 0, 0);
            this.tabHoraire.Controls.Add(this.label1, 10, 0);
            this.tabHoraire.Controls.Add(this.label2, 11, 0);
            this.tabHoraire.Controls.Add(this.label3, 12, 0);
            this.tabHoraire.Location = new System.Drawing.Point(0, 0);
            this.tabHoraire.Name = "tabHoraire";
            this.tabHoraire.RowCount = 2;
            this.tabHoraire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabHoraire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabHoraire.Size = new System.Drawing.Size(461, 383);
            this.tabHoraire.TabIndex = 1;
            this.tabHoraire.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(871, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "22h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "20h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "21h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "18h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "19h";
            // 
            // lbl13h
            // 
            this.lbl13h.AutoSize = true;
            this.lbl13h.Location = new System.Drawing.Point(412, 1);
            this.lbl13h.Name = "lbl13h";
            this.lbl13h.Size = new System.Drawing.Size(26, 15);
            this.lbl13h.TabIndex = 9;
            this.lbl13h.Text = "13h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "14h";
            // 
            // lbl11h
            // 
            this.lbl11h.AutoSize = true;
            this.lbl11h.Location = new System.Drawing.Point(310, 1);
            this.lbl11h.Name = "lbl11h";
            this.lbl11h.Size = new System.Drawing.Size(26, 15);
            this.lbl11h.TabIndex = 7;
            this.lbl11h.Text = "11h";
            // 
            // lbl12h
            // 
            this.lbl12h.AutoSize = true;
            this.lbl12h.Location = new System.Drawing.Point(361, 1);
            this.lbl12h.Name = "lbl12h";
            this.lbl12h.Size = new System.Drawing.Size(26, 15);
            this.lbl12h.TabIndex = 6;
            this.lbl12h.Text = "12h";
            // 
            // lbl9h
            // 
            this.lbl9h.AutoSize = true;
            this.lbl9h.Location = new System.Drawing.Point(208, 1);
            this.lbl9h.Name = "lbl9h";
            this.lbl9h.Size = new System.Drawing.Size(26, 15);
            this.lbl9h.TabIndex = 5;
            this.lbl9h.Text = "09h";
            // 
            // lbl10h
            // 
            this.lbl10h.AutoSize = true;
            this.lbl10h.Location = new System.Drawing.Point(259, 1);
            this.lbl10h.Name = "lbl10h";
            this.lbl10h.Size = new System.Drawing.Size(26, 15);
            this.lbl10h.TabIndex = 4;
            this.lbl10h.Text = "10h";
            // 
            // lbl7h
            // 
            this.lbl7h.AutoSize = true;
            this.lbl7h.Location = new System.Drawing.Point(106, 1);
            this.lbl7h.Name = "lbl7h";
            this.lbl7h.Size = new System.Drawing.Size(26, 15);
            this.lbl7h.TabIndex = 3;
            this.lbl7h.Text = "07h";
            // 
            // lbl8h
            // 
            this.lbl8h.AutoSize = true;
            this.lbl8h.Location = new System.Drawing.Point(157, 1);
            this.lbl8h.Name = "lbl8h";
            this.lbl8h.Size = new System.Drawing.Size(26, 15);
            this.lbl8h.TabIndex = 2;
            this.lbl8h.Text = "08h";
            // 
            // lbl6h
            // 
            this.lbl6h.AutoSize = true;
            this.lbl6h.Location = new System.Drawing.Point(55, 1);
            this.lbl6h.Name = "lbl6h";
            this.lbl6h.Size = new System.Drawing.Size(26, 15);
            this.lbl6h.TabIndex = 1;
            this.lbl6h.Text = "06h";
            // 
            // lbl5h
            // 
            this.lbl5h.AutoSize = true;
            this.lbl5h.Location = new System.Drawing.Point(4, 1);
            this.lbl5h.Name = "lbl5h";
            this.lbl5h.Size = new System.Drawing.Size(26, 15);
            this.lbl5h.TabIndex = 0;
            this.lbl5h.Text = "05h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "15h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "16h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "17h";
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
            this.panel1.ResumeLayout(false);
            this.tabHoraire.ResumeLayout(false);
            this.tabHoraire.PerformLayout();
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
        private ComboBox CBOSens;
        private ComboBox CBOArretB;
        private ComboBox CBOArretA;
        private Button cmdAfficher2;
        private Label lblArretA;
        private Label lblArretB;
        private GroupBox grpboxCalcul;
        private TableLayoutPanel tabHoraire;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label lbl13h;
        private Label label8;
        private Label lbl11h;
        private Label lbl12h;
        private Label lbl9h;
        private Label lbl10h;
        private Label lbl7h;
        private Label lbl8h;
        private Label lbl6h;
        private Label lbl5h;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}