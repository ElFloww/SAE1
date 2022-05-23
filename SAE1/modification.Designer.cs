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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLigne = new System.Windows.Forms.Panel();
            this.cmdCreation = new System.Windows.Forms.Button();
            this.radLigne8 = new System.Windows.Forms.RadioButton();
            this.radLigne7 = new System.Windows.Forms.RadioButton();
            this.radLigne5 = new System.Windows.Forms.RadioButton();
            this.radLigne1 = new System.Windows.Forms.RadioButton();
            this.cmdSuppression = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdQuitterAccueil = new System.Windows.Forms.Button();
            this.pnlLigne.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création / Modification / Suppression d\'une ligne de bus";
            // 
            // pnlLigne
            // 
            this.pnlLigne.Controls.Add(this.cmdCreation);
            this.pnlLigne.Controls.Add(this.radLigne8);
            this.pnlLigne.Controls.Add(this.radLigne7);
            this.pnlLigne.Controls.Add(this.radLigne5);
            this.pnlLigne.Controls.Add(this.radLigne1);
            this.pnlLigne.Location = new System.Drawing.Point(47, 71);
            this.pnlLigne.Name = "pnlLigne";
            this.pnlLigne.Size = new System.Drawing.Size(861, 320);
            this.pnlLigne.TabIndex = 1;
            // 
            // cmdCreation
            // 
            this.cmdCreation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCreation.Location = new System.Drawing.Point(30, 20);
            this.cmdCreation.Name = "cmdCreation";
            this.cmdCreation.Size = new System.Drawing.Size(800, 40);
            this.cmdCreation.TabIndex = 8;
            this.cmdCreation.Text = "Créer une ligne de bus";
            this.cmdCreation.UseVisualStyleBackColor = true;
            this.cmdCreation.Click += new System.EventHandler(this.cmdCreation_Click);
            // 
            // radLigne8
            // 
            this.radLigne8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLigne8.Location = new System.Drawing.Point(30, 204);
            this.radLigne8.Name = "radLigne8";
            this.radLigne8.Size = new System.Drawing.Size(800, 40);
            this.radLigne8.TabIndex = 7;
            this.radLigne8.TabStop = true;
            this.radLigne8.Text = "ligne 4";
            this.radLigne8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLigne8.UseVisualStyleBackColor = true;
            // 
            // radLigne7
            // 
            this.radLigne7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLigne7.Location = new System.Drawing.Point(30, 158);
            this.radLigne7.Name = "radLigne7";
            this.radLigne7.Size = new System.Drawing.Size(800, 40);
            this.radLigne7.TabIndex = 6;
            this.radLigne7.TabStop = true;
            this.radLigne7.Text = "ligne 3";
            this.radLigne7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLigne7.UseVisualStyleBackColor = true;
            // 
            // radLigne5
            // 
            this.radLigne5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLigne5.Location = new System.Drawing.Point(30, 112);
            this.radLigne5.Name = "radLigne5";
            this.radLigne5.Size = new System.Drawing.Size(800, 40);
            this.radLigne5.TabIndex = 5;
            this.radLigne5.TabStop = true;
            this.radLigne5.Text = "ligne 2";
            this.radLigne5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLigne5.UseVisualStyleBackColor = true;
            // 
            // radLigne1
            // 
            this.radLigne1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLigne1.Location = new System.Drawing.Point(30, 66);
            this.radLigne1.Name = "radLigne1";
            this.radLigne1.Size = new System.Drawing.Size(800, 40);
            this.radLigne1.TabIndex = 4;
            this.radLigne1.TabStop = true;
            this.radLigne1.Text = "ligne 1";
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
            // 
            // cmdQuitterAccueil
            // 
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
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.cmdQuitterAccueil);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSuppression);
            this.Controls.Add(this.pnlLigne);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modification";
            this.Load += new System.EventHandler(this.modification_Load);
            this.pnlLigne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel pnlLigne;
        private RadioButton radLigne1;
        private RadioButton radLigne8;
        private RadioButton radLigne7;
        private RadioButton radLigne5;
        private Button cmdCreation;
        private Button cmdSuppression;
        private Button cmdModifier;
        private Button cmdQuitterAccueil;
    }
}