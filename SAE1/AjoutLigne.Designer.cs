namespace SAE1
{
    partial class AjoutLigne
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.nudHeureDepart = new System.Windows.Forms.NumericUpDown();
            this.nudMinuteDepart = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNbArrets = new System.Windows.Forms.NumericUpDown();
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
            this.cmdValider = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.errorProviderNomLigne = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDepart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbArrets)).BeginInit();
            this.pnlArrets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création d\'une ligne";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la ligne :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'arrêts :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heure de départ :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(193, 90);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(114, 23);
            this.txtNomLigne.TabIndex = 4;
            this.txtNomLigne.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomLigne_Validating);
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
            this.nudHeureDepart.TabIndex = 6;
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
            this.nudMinuteDepart.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "L\'ordre d\'affichage des arrêts sur la \nfenêtre est dans l\'ordre croissant des \nho" +
    "raires permettant de former le trajet";
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
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(244, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "/";
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
            this.nudNbArrets.TabIndex = 10;
            this.nudNbArrets.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbArrets.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
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
            this.lblHoaire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoaire.Location = new System.Drawing.Point(232, 21);
            this.lblHoaire.Name = "lblHoaire";
            this.lblHoaire.Size = new System.Drawing.Size(116, 26);
            this.lblHoaire.TabIndex = 20;
            this.lblHoaire.Text = "Premier horaire :";
            this.lblHoaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArret
            // 
            this.lblArret.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArret.Location = new System.Drawing.Point(35, 21);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(121, 26);
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
            this.CBOArret2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CBOArret1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // 
            // cmdValider
            // 
            this.cmdValider.Enabled = false;
            this.cmdValider.Location = new System.Drawing.Point(603, 408);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(75, 30);
            this.cmdValider.TabIndex = 12;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.CausesValidation = false;
            this.cmdQuitter.Location = new System.Drawing.Point(713, 408);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 30);
            this.cmdQuitter.TabIndex = 13;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // errorProviderNomLigne
            // 
            this.errorProviderNomLigne.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNomLigne.ContainerControl = this;
            // 
            // AjoutLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutLigne";
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDepart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbArrets)).EndInit();
            this.pnlArrets.ResumeLayout(false);
            this.pnlArrets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMinuteDepart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeureDepart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNomLigne;
        private NumericUpDown nudHeureDepart;
        private NumericUpDown nudMinuteDepart;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label7;
        private NumericUpDown nudNbArrets;
        private Panel pnlArrets;
        private Label LBLSplit2;
        private ComboBox CBOArret2;
        private NumericUpDown NUDMinuteDepart2;
        private NumericUpDown NUDHeureDepart2;
        private Label LBLSplit1;
        private ComboBox CBOArret1;
        private NumericUpDown NUDMinuteDepart1;
        private NumericUpDown NUDHeureDepart1;
        private Label lblHoaire;
        private Label lblArret;
        private Button cmdValider;
        private Button cmdQuitter;
        private ErrorProvider errorProviderNomLigne;
    }
}