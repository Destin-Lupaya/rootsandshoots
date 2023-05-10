namespace rootsandshoots
{
    partial class Etat_Rapport_Elem_Seco_Hommes
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
            this.CboElementaire = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(673, 5);
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
            this.Label1.Size = new System.Drawing.Size(376, 15);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Derouler pour voir les Garçons du Degres Elementaires au Secondaire";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.CboElementaire);
            this.Panel1.Location = new System.Drawing.Point(3, 13);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(964, 39);
            this.Panel1.TabIndex = 22;
            // 
            // CboElementaire
            // 
            this.CboElementaire.FormattingEnabled = true;
            this.CboElementaire.Location = new System.Drawing.Point(435, 7);
            this.CboElementaire.Name = "CboElementaire";
            this.CboElementaire.Size = new System.Drawing.Size(181, 21);
            this.CboElementaire.TabIndex = 2;
            // 
            // Etat_Rapport_Elem_Seco_Hommes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "Etat_Rapport_Elem_Seco_Hommes";
            this.Size = new System.Drawing.Size(1068, 599);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox CboElementaire;
    }
}
