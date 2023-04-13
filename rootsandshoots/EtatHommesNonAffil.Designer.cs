namespace rootsandshoots
{
    partial class EtatHommesNonAffil
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
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(453, 50);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(184, 27);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Afficher le Rapport";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // EtatHommesNonAffil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button1);
            this.Name = "EtatHommesNonAffil";
            this.Size = new System.Drawing.Size(1046, 569);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
    }
}
