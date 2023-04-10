namespace rootsandshoots
{
    partial class Etat_Rapport_G2
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CboUniversiteG2 = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(588, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(215, 31);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Afficher le rapport";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(30, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(227, 15);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Derouler pour voir les Universitaire de G2";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.CboUniversiteG2);
            this.Panel1.Location = new System.Drawing.Point(3, 14);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(964, 39);
            this.Panel1.TabIndex = 20;
            // 
            // CboUniversiteG2
            // 
            this.CboUniversiteG2.FormattingEnabled = true;
            this.CboUniversiteG2.Location = new System.Drawing.Point(325, 6);
            this.CboUniversiteG2.Name = "CboUniversiteG2";
            this.CboUniversiteG2.Size = new System.Drawing.Size(181, 21);
            this.CboUniversiteG2.TabIndex = 2;
            // 
            // Etat_Rapport_G2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "Etat_Rapport_G2";
            this.Size = new System.Drawing.Size(1074, 600);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox CboUniversiteG2;
    }
}
