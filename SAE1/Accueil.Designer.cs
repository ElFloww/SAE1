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
            this.tabHoraire = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
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
            this.lbl1h = new System.Windows.Forms.Label();
            this.lbl0h = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabHoraire.SuspendLayout();
            this.grpboxCalcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxHoraires
            // 
            this.grpboxHoraires.BackColor = System.Drawing.Color.Transparent;
            this.grpboxHoraires.Controls.Add(this.lblSens);
            this.grpboxHoraires.Controls.Add(this.CBOSens);
            this.grpboxHoraires.Controls.Add(this.lblArret);
            this.grpboxHoraires.Controls.Add(this.lblLigne);
            this.grpboxHoraires.Controls.Add(this.cmdAfficher1);
            this.grpboxHoraires.Controls.Add(this.CBOLigne);
            this.grpboxHoraires.Controls.Add(this.CBOArret);
            this.grpboxHoraires.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpboxHoraires.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.lblSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBOSens
            // 
            this.CBOSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOSens.Enabled = false;
            this.CBOSens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOSens.FormattingEnabled = true;
            this.CBOSens.Location = new System.Drawing.Point(118, 122);
            this.CBOSens.Name = "CBOSens";
            this.CBOSens.Size = new System.Drawing.Size(209, 25);
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
            this.lblArret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLigne
            // 
            this.lblLigne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLigne.Location = new System.Drawing.Point(43, 30);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(69, 23);
            this.lblLigne.TabIndex = 0;
            this.lblLigne.Text = "Ligne :";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdAfficher1
            // 
            this.cmdAfficher1.Enabled = false;
            this.cmdAfficher1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAfficher1.ForeColor = System.Drawing.Color.DarkOrange;
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
            this.CBOLigne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOLigne.FormattingEnabled = true;
            this.CBOLigne.Location = new System.Drawing.Point(170, 30);
            this.CBOLigne.Name = "CBOLigne";
            this.CBOLigne.Size = new System.Drawing.Size(157, 25);
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
            this.CBOArret.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOArret.FormattingEnabled = true;
            this.CBOArret.Location = new System.Drawing.Point(170, 76);
            this.CBOArret.Name = "CBOArret";
            this.CBOArret.Size = new System.Drawing.Size(157, 25);
            this.CBOArret.TabIndex = 1;
            this.CBOArret.SelectedIndexChanged += new System.EventHandler(this.HoraireValidation);
            this.CBOArret.Enter += new System.EventHandler(this.CBOArret_Enter);
            // 
            // tabHoraire
            // 
            this.tabHoraire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHoraire.AutoScroll = true;
            this.tabHoraire.BackColor = System.Drawing.Color.White;
            this.tabHoraire.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tabHoraire.ColumnCount = 24;
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
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabHoraire.Controls.Add(this.label13, 21, 0);
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
            this.tabHoraire.Controls.Add(this.lbl1h, 1, 0);
            this.tabHoraire.Controls.Add(this.lbl0h, 0, 0);
            this.tabHoraire.Controls.Add(this.label1, 10, 0);
            this.tabHoraire.Controls.Add(this.label2, 11, 0);
            this.tabHoraire.Controls.Add(this.label3, 12, 0);
            this.tabHoraire.Controls.Add(this.label10, 18, 0);
            this.tabHoraire.Controls.Add(this.label11, 19, 0);
            this.tabHoraire.Controls.Add(this.label12, 20, 0);
            this.tabHoraire.Controls.Add(this.label14, 22, 0);
            this.tabHoraire.Controls.Add(this.label15, 23, 0);
            this.tabHoraire.Location = new System.Drawing.Point(426, 25);
            this.tabHoraire.Name = "tabHoraire";
            this.tabHoraire.RowCount = 2;
            this.tabHoraire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabHoraire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabHoraire.Size = new System.Drawing.Size(516, 383);
            this.tabHoraire.TabIndex = 1;
            this.tabHoraire.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1119, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "21h";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(907, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "17h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "15h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(854, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "16h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "13h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "14h";
            // 
            // lbl13h
            // 
            this.lbl13h.AutoSize = true;
            this.lbl13h.Location = new System.Drawing.Point(430, 3);
            this.lbl13h.Name = "lbl13h";
            this.lbl13h.Size = new System.Drawing.Size(26, 15);
            this.lbl13h.TabIndex = 9;
            this.lbl13h.Text = "08h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "09h";
            // 
            // lbl11h
            // 
            this.lbl11h.AutoSize = true;
            this.lbl11h.Location = new System.Drawing.Point(324, 3);
            this.lbl11h.Name = "lbl11h";
            this.lbl11h.Size = new System.Drawing.Size(26, 15);
            this.lbl11h.TabIndex = 7;
            this.lbl11h.Text = "06h";
            // 
            // lbl12h
            // 
            this.lbl12h.AutoSize = true;
            this.lbl12h.Location = new System.Drawing.Point(377, 3);
            this.lbl12h.Name = "lbl12h";
            this.lbl12h.Size = new System.Drawing.Size(26, 15);
            this.lbl12h.TabIndex = 6;
            this.lbl12h.Text = "07h";
            // 
            // lbl9h
            // 
            this.lbl9h.AutoSize = true;
            this.lbl9h.Location = new System.Drawing.Point(218, 3);
            this.lbl9h.Name = "lbl9h";
            this.lbl9h.Size = new System.Drawing.Size(26, 15);
            this.lbl9h.TabIndex = 5;
            this.lbl9h.Text = "04h";
            // 
            // lbl10h
            // 
            this.lbl10h.AutoSize = true;
            this.lbl10h.Location = new System.Drawing.Point(271, 3);
            this.lbl10h.Name = "lbl10h";
            this.lbl10h.Size = new System.Drawing.Size(26, 15);
            this.lbl10h.TabIndex = 4;
            this.lbl10h.Text = "05h";
            // 
            // lbl7h
            // 
            this.lbl7h.AutoSize = true;
            this.lbl7h.Location = new System.Drawing.Point(112, 3);
            this.lbl7h.Name = "lbl7h";
            this.lbl7h.Size = new System.Drawing.Size(26, 15);
            this.lbl7h.TabIndex = 3;
            this.lbl7h.Text = "02h";
            // 
            // lbl8h
            // 
            this.lbl8h.AutoSize = true;
            this.lbl8h.Location = new System.Drawing.Point(165, 3);
            this.lbl8h.Name = "lbl8h";
            this.lbl8h.Size = new System.Drawing.Size(26, 15);
            this.lbl8h.TabIndex = 2;
            this.lbl8h.Text = "03h";
            // 
            // lbl1h
            // 
            this.lbl1h.AutoSize = true;
            this.lbl1h.Location = new System.Drawing.Point(59, 3);
            this.lbl1h.Name = "lbl1h";
            this.lbl1h.Size = new System.Drawing.Size(26, 15);
            this.lbl1h.TabIndex = 1;
            this.lbl1h.Text = "01h";
            // 
            // lbl0h
            // 
            this.lbl0h.AutoSize = true;
            this.lbl0h.Location = new System.Drawing.Point(6, 3);
            this.lbl0h.Name = "lbl0h";
            this.lbl0h.Size = new System.Drawing.Size(26, 15);
            this.lbl0h.TabIndex = 0;
            this.lbl0h.Text = "00h";
            this.lbl0h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "10h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "11h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "12h";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(960, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "18h";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1013, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "19h";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1066, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "20h";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1172, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "22h";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1225, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "23h";
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
            this.txtAccueil.BackColor = System.Drawing.Color.DarkOrange;
            this.txtAccueil.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccueil.Location = new System.Drawing.Point(28, 9);
            this.txtAccueil.Name = "txtAccueil";
            this.txtAccueil.Size = new System.Drawing.Size(380, 57);
            this.txtAccueil.TabIndex = 10;
            this.txtAccueil.Text = "Filibus - Accueil";
            this.txtAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBOArretB
            // 
            this.CBOArretB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArretB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOArretB.FormattingEnabled = true;
            this.CBOArretB.Location = new System.Drawing.Point(170, 86);
            this.CBOArretB.Name = "CBOArretB";
            this.CBOArretB.Size = new System.Drawing.Size(157, 25);
            this.CBOArretB.TabIndex = 1;
            this.CBOArretB.SelectedValueChanged += new System.EventHandler(this.ItineraireValidation);
            this.CBOArretB.Enter += new System.EventHandler(this.CBOArretB_Enter);
            // 
            // CBOArretA
            // 
            this.CBOArretA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOArretA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOArretA.FormattingEnabled = true;
            this.CBOArretA.Location = new System.Drawing.Point(170, 40);
            this.CBOArretA.Name = "CBOArretA";
            this.CBOArretA.Size = new System.Drawing.Size(157, 25);
            this.CBOArretA.TabIndex = 0;
            this.CBOArretA.SelectedValueChanged += new System.EventHandler(this.ItineraireValidation);
            this.CBOArretA.Enter += new System.EventHandler(this.CBOArretA_Enter);
            // 
            // cmdAfficher2
            // 
            this.cmdAfficher2.Enabled = false;
            this.cmdAfficher2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAfficher2.ForeColor = System.Drawing.Color.DarkOrange;
            this.cmdAfficher2.Location = new System.Drawing.Point(252, 128);
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
            this.lblArretA.Location = new System.Drawing.Point(29, 40);
            this.lblArretA.Name = "lblArretA";
            this.lblArretA.Size = new System.Drawing.Size(115, 23);
            this.lblArretA.TabIndex = 0;
            this.lblArretA.Text = "Arrêt de départ :";
            this.lblArretA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArretB
            // 
            this.lblArretB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArretB.Location = new System.Drawing.Point(29, 86);
            this.lblArretB.Name = "lblArretB";
            this.lblArretB.Size = new System.Drawing.Size(115, 23);
            this.lblArretB.TabIndex = 2;
            this.lblArretB.Text = "Arrêt d\'arrivé :";
            this.lblArretB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpboxCalcul
            // 
            this.grpboxCalcul.BackColor = System.Drawing.Color.Transparent;
            this.grpboxCalcul.Controls.Add(this.lblArretB);
            this.grpboxCalcul.Controls.Add(this.lblArretA);
            this.grpboxCalcul.Controls.Add(this.cmdAfficher2);
            this.grpboxCalcul.Controls.Add(this.CBOArretA);
            this.grpboxCalcul.Controls.Add(this.CBOArretB);
            this.grpboxCalcul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.Controls.Add(this.tabHoraire);
            this.Controls.Add(this.txtAccueil);
            this.Controls.Add(this.cmdAdmin);
            this.Controls.Add(this.cmdQuitterAccueil);
            this.Controls.Add(this.grpboxCalcul);
            this.Controls.Add(this.grpboxHoraires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilibusAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filibus - Réseau de transport urbain de Chartres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxHoraires.ResumeLayout(false);
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
        private Label lbl1h;
        private Label lbl0h;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private DateTimePicker dateTimePicker1;
    }
}