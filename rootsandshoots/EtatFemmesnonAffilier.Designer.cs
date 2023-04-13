namespace rootsandshoots
{
    partial class EtatFemmesnonAffilier
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
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(684, 71);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(176, 26);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Afficher le rapport";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // EtatFemmesnonAffilier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button1);
            this.Name = "EtatFemmesnonAffilier";
            this.Size = new System.Drawing.Size(1089, 609);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Button1;
    }
}
