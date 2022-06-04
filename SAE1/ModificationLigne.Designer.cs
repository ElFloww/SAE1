namespace SAE1
{
    partial class ModificationLigne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.pnlArrets = new System.Windows.Forms.Panel();
            this.lblHoaire = new System.Windows.Forms.Label();
            this.lblArret = new System.Windows.Forms.Label();
            this.LBLSplit2 = new System.Windows.Forms.Label();
            this.CBOArret2 = new System.Windows.Forms.ComboBox();
            this.NUDMinuteDepart2 = new System.Windows.Forms.NumericUpDown();
            this.NUDHeureDepart2 = new System.Windows.Forms.NumericUpDown();
            this.LBLSplit1 = new System.Windows.Forms.Label();
            this.CBOArret1 = new System.Windows.Forms.ComboBox();
            this.NUDMinuteDepart1 = new System.Windows.Forms.NumericUpDown();
            this.NUDHeureDepart1 = new System.Windows.Forms.NumericUpDown();
            this.nudNbArrets = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMinuteDepart = new System.Windows.Forms.NumericUpDown();
            this.nudHeureDepart = new System.Windows.Forms.NumericUpDown();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNbArret = new System.Windows.Forms.Label();
            this.lblLigne = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.errorProviderNomLigne = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlArrets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbArrets)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.CausesValidation = false;
            this.cmdQuitter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitter.Location = new System.Drawing.Point(713, 408);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 30);
            this.cmdQuitter.TabIndex = 26;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdValider.ForeColor = System.Drawing.Color.DarkOrange;
            this.cmdValider.Location = new System.Drawing.Point(603, 408);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(75, 30);
            this.cmdValider.TabIndex = 25;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // pnlArrets
            // 
            this.pnlArrets.AutoScroll = true;
            this.pnlArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArrets.Controls.Add(this.lblHoaire);
            this.pnlArrets.Controls.Add(this.lblArret);
            this.pnlArrets.Controls.Add(this.LBLSplit2);
            this.pnlArrets.Controls.Add(this.CBOArret2);
            this.pnlArrets.Controls.Add(this.NUDMinuteDepart2);
            this.pnlArrets.Controls.Add(this.NUDHeureDepart2);
            this.pnlArrets.Controls.Add(this.LBLSplit1);
            this.pnlArrets.Controls.Add(this.CBOArret1);
            this.pnlArrets.Controls.Add(this.NUDMinuteDepart1);
            this.pnlArrets.Controls.Add(this.NUDHeureDepart1);
            this.pnlArrets.Location = new System.Drawing.Point(370, 65);
            this.pnlArrets.Name = "pnlArrets";
            this.pnlArrets.Size = new System.Drawing.Size(375, 312);
            this.pnlArrets.TabIndex = 11;
            // 
            // lblHoaire
            // 
            this.lblHoaire.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHoaire.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoaire.Location = new System.Drawing.Point(215, 21);
            this.lblHoaire.Name = "lblHoaire";
            this.lblHoaire.Size = new System.Drawing.Size(140, 26);
            this.lblHoaire.TabIndex = 20;
            this.lblHoaire.Text = "Premieres horaires :";
            this.lblHoaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArret
            // 
            this.lblArret.BackColor = System.Drawing.Color.DarkOrange;
            this.lblArret.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArret.Location = new System.Drawing.Point(25, 21);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(142, 26);
            this.lblArret.TabIndex = 19;
            this.lblArret.Text = "Arrêts de la ligne :";
            this.lblArret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLSplit2
            // 
            this.LBLSplit2.AutoSize = true;
            this.LBLSplit2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLSplit2.Location = new System.Drawing.Point(276, 94);
            this.LBLSplit2.Name = "LBLSplit2";
            this.LBLSplit2.Size = new System.Drawing.Size(20, 28);
            this.LBLSplit2.TabIndex = 18;
            this.LBLSplit2.Text = "/";
            // 
            // CBOArret2
            // 
            this.CBOArret2.FormattingEnabled = true;
            this.CBOArret2.Location = new System.Drawing.Point(35, 98);
            this.CBOArret2.Name = "CBOArret2";
            this.CBOArret2.Size = new System.Drawing.Size(121, 23);
            this.CBOArret2.TabIndex = 15;
            this.CBOArret2.Enter += new System.EventHandler(this.CBOArret_Enter);
            // 
            // NUDMinuteDepart2
            // 
            this.NUDMinuteDepart2.Location = new System.Drawing.Point(296, 99);
            this.NUDMinuteDepart2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDMinuteDepart2.Name = "NUDMinuteDepart2";
            this.NUDMinuteDepart2.Size = new System.Drawing.Size(41, 23);
            this.NUDMinuteDepart2.TabIndex = 17;
            // 
            // NUDHeureDepart2
            // 
            this.NUDHeureDepart2.Location = new System.Drawing.Point(232, 99);
            this.NUDHeureDepart2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUDHeureDepart2.Name = "NUDHeureDepart2";
            this.NUDHeureDepart2.Size = new System.Drawing.Size(44, 23);
            this.NUDHeureDepart2.TabIndex = 16;
            // 
            // LBLSplit1
            // 
            this.LBLSplit1.AutoSize = true;
            this.LBLSplit1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLSplit1.Location = new System.Drawing.Point(276, 54);
            this.LBLSplit1.Name = "LBLSplit1";
            this.LBLSplit1.Size = new System.Drawing.Size(20, 28);
            this.LBLSplit1.TabIndex = 14;
            this.LBLSplit1.Text = "/";
            // 
            // CBOArret1
            // 
            this.CBOArret1.FormattingEnabled = true;
            this.CBOArret1.Location = new System.Drawing.Point(35, 58);
            this.CBOArret1.Name = "CBOArret1";
            this.CBOArret1.Size = new System.Drawing.Size(121, 23);
            this.CBOArret1.TabIndex = 2;
            this.CBOArret1.Enter += new System.EventHandler(this.CBOArret_Enter);
            // 
            // NUDMinuteDepart1
            // 
            this.NUDMinuteDepart1.Location = new System.Drawing.Point(296, 59);
            this.NUDMinuteDepart1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDMinuteDepart1.Name = "NUDMinuteDepart1";
            this.NUDMinuteDepart1.Size = new System.Drawing.Size(41, 23);
            this.NUDMinuteDepart1.TabIndex = 13;
            this.NUDMinuteDepart1.ValueChanged += new System.EventHandler(this.NUDMinuteDepart1_ValueChanged);
            // 
            // NUDHeureDepart1
            // 
            this.NUDHeureDepart1.Location = new System.Drawing.Point(232, 59);
            this.NUDHeureDepart1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUDHeureDepart1.Name = "NUDHeureDepart1";
            this.NUDHeureDepart1.Size = new System.Drawing.Size(44, 23);
            this.NUDHeureDepart1.TabIndex = 12;
            this.NUDHeureDepart1.ValueChanged += new System.EventHandler(this.NUDHeureDepart1_ValueChanged);
            // 
            // nudNbArrets
            // 
            this.nudNbArrets.Location = new System.Drawing.Point(193, 128);
            this.nudNbArrets.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbArrets.Name = "nudNbArrets";
            this.nudNbArrets.Size = new System.Drawing.Size(112, 23);
            this.nudNbArrets.TabIndex = 23;
            this.nudNbArrets.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbArrets.ValueChanged += new System.EventHandler(this.nudNbArrets_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(244, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 140);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "L\'ordre d\'affichage des arrêts dans la \nfenêtre de droite est dans l\'ordre croiss" +
    "ant des \nhoraires permettant de former le trajet.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Informations complémentaire : ";
            // 
            // nudMinuteDepart
            // 
            this.nudMinuteDepart.Location = new System.Drawing.Point(264, 174);
            this.nudMinuteDepart.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteDepart.Name = "nudMinuteDepart";
            this.nudMinuteDepart.Size = new System.Drawing.Size(41, 23);
            this.nudMinuteDepart.TabIndex = 20;
            this.nudMinuteDepart.ValueChanged += new System.EventHandler(this.nudMinuteDepart_ValueChanged);
            // 
            // nudHeureDepart
            // 
            this.nudHeureDepart.Location = new System.Drawing.Point(200, 174);
            this.nudHeureDepart.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureDepart.Name = "nudHeureDepart";
            this.nudHeureDepart.Size = new System.Drawing.Size(44, 23);
            this.nudHeureDepart.TabIndex = 19;
            this.nudHeureDepart.ValueChanged += new System.EventHandler(this.nudHeureDepart_ValueChanged);
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(193, 90);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(114, 23);
            this.txtNomLigne.TabIndex = 18;
            this.txtNomLigne.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomLigne_Validating);
            // 
            // lblHeure
            // 
            this.lblHeure.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeure.Location = new System.Drawing.Point(36, 170);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(137, 25);
            this.lblHeure.TabIndex = 17;
            this.lblHeure.Text = "Heure de départ :";
            this.lblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNbArret
            // 
            this.lblNbArret.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbArret.Location = new System.Drawing.Point(36, 129);
            this.lblNbArret.Name = "lblNbArret";
            this.lblNbArret.Size = new System.Drawing.Size(137, 23);
            this.lblNbArret.TabIndex = 16;
            this.lblNbArret.Text = "Nombre d\'arrêts :";
            this.lblNbArret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLigne
            // 
            this.lblLigne.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLigne.Location = new System.Drawing.Point(36, 90);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(137, 23);
            this.lblLigne.TabIndex = 15;
            this.lblLigne.Text = "Nom de la ligne :";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(24, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(314, 45);
            this.lblTitre.TabIndex = 14;
            this.lblTitre.Text = "Modification d\'une ligne";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderNomLigne
            // 
            this.errorProviderNomLigne.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNomLigne.ContainerControl = this;
            // 
            // ModificationLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.pnlArrets);
            this.Controls.Add(this.nudNbArrets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudMinuteDepart);
            this.Controls.Add(this.nudHeureDepart);
            this.Controls.Add(this.txtNomLigne);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblNbArret);
            this.Controls.Add(this.lblLigne);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificationLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filibus - Modification de ligne de bus";
            this.Load += new System.EventHandler(this.ModificationLigne_Load);
            this.pnlArrets.ResumeLayout(false);
            this.pnlArrets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbArrets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdQuitter;
        private Button cmdValider;
        private Panel pnlArrets;
        private Label lblHoaire;
        private Label lblArret;
        private Label LBLSplit2;
        private ComboBox CBOArret2;
        private NumericUpDown NUDMinuteDepart2;
        private NumericUpDown NUDHeureDepart2;
        private Label LBLSplit1;
        private ComboBox CBOArret1;
        private NumericUpDown NUDMinuteDepart1;
        private NumericUpDown NUDHeureDepart1;
        private NumericUpDown nudNbArrets;
        private Label label7;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private NumericUpDown nudMinuteDepart;
        private NumericUpDown nudHeureDepart;
        private TextBox txtNomLigne;
        private Label lblHeure;
        private Label lblNbArret;
        private Label lblLigne;
        private Label lblTitre;
        private ErrorProvider errorProviderNomLigne;
    }
}