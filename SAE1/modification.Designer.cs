namespace SAE1
{
    partial class modification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modification));
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlLigne = new System.Windows.Forms.Panel();
            this.cmdCreation = new System.Windows.Forms.Button();
            this.radLigne1 = new System.Windows.Forms.RadioButton();
            this.cmdSuppression = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdQuitterAccueil = new System.Windows.Forms.Button();
            this.pnlLigne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(124, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(706, 48);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Interface administrateur";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLigne
            // 
            this.pnlLigne.AutoScroll = true;
            this.pnlLigne.BackColor = System.Drawing.Color.Transparent;
            this.pnlLigne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLigne.Controls.Add(this.cmdCreation);
            this.pnlLigne.Controls.Add(this.radLigne1);
            this.pnlLigne.Location = new System.Drawing.Point(47, 71);
            this.pnlLigne.Name = "pnlLigne";
            this.pnlLigne.Size = new System.Drawing.Size(861, 320);
            this.pnlLigne.TabIndex = 1;
            // 
            // cmdCreation
            // 
            this.cmdCreation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCreation.ForeColor = System.Drawing.Color.Black;
            this.cmdCreation.Location = new System.Drawing.Point(30, 20);
            this.cmdCreation.Name = "cmdCreation";
            this.cmdCreation.Size = new System.Drawing.Size(800, 40);
            this.cmdCreation.TabIndex = 8;
            this.cmdCreation.Text = "Créer une ligne de bus";
            this.cmdCreation.UseVisualStyleBackColor = true;
            this.cmdCreation.Click += new System.EventHandler(this.cmdCreation_Click);
            // 
            // radLigne1
            // 
            this.radLigne1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLigne1.Enabled = false;
            this.radLigne1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLigne1.Location = new System.Drawing.Point(30, 66);
            this.radLigne1.Name = "radLigne1";
            this.radLigne1.Size = new System.Drawing.Size(800, 40);
            this.radLigne1.TabIndex = 4;
            this.radLigne1.TabStop = true;
            this.radLigne1.Text = "Actualisez pour visualiser";
            this.radLigne1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLigne1.UseVisualStyleBackColor = true;
            // 
            // cmdSuppression
            // 
            this.cmdSuppression.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSuppression.Location = new System.Drawing.Point(215, 442);
            this.cmdSuppression.Name = "cmdSuppression";
            this.cmdSuppression.Size = new System.Drawing.Size(245, 30);
            this.cmdSuppression.TabIndex = 10;
            this.cmdSuppression.Text = "Supprimer la ligne de bus";
            this.cmdSuppression.UseVisualStyleBackColor = true;
            this.cmdSuppression.Click += new System.EventHandler(this.cmdSuppression_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdModifier.Location = new System.Drawing.Point(494, 442);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(245, 30);
            this.cmdModifier.TabIndex = 11;
            this.cmdModifier.Text = "Modifier la ligne de bus";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdQuitterAccueil
            // 
            this.cmdQuitterAccueil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitterAccueil.Location = new System.Drawing.Point(833, 442);
            this.cmdQuitterAccueil.Name = "cmdQuitterAccueil";
            this.cmdQuitterAccueil.Size = new System.Drawing.Size(75, 30);
            this.cmdQuitterAccueil.TabIndex = 12;
            this.cmdQuitterAccueil.Text = "Quitter";
            this.cmdQuitterAccueil.UseVisualStyleBackColor = true;
            this.cmdQuitterAccueil.Click += new System.EventHandler(this.cmdQuitterAccueil_Click);
            // 
            // modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.cmdQuitterAccueil);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSuppression);
            this.Controls.Add(this.pnlLigne);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "modification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filibus - Gestion des lignes de bus";
            this.Load += new System.EventHandler(this.ActualiserLigne);
            this.pnlLigne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitre;
        private Panel pnlLigne;
        private RadioButton radLigne1;
        private Button cmdCreation;
        private Button cmdSuppression;
        private Button cmdModifier;
        private Button cmdQuitterAccueil;
    }
}