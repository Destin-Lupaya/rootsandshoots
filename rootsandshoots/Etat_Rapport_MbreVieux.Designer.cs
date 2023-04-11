namespace rootsandshoots
{
    partial class Etat_Rapport_MbreVieux
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbooption = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.cbooption);
            this.Panel1.Location = new System.Drawing.Point(14, 32);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(923, 37);
            this.Panel1.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(665, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(176, 26);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Afficher le rapport";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(35, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(201, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Cliquez pour voir les membres ages";
            // 
            // cbooption
            // 
            this.cbooption.FormattingEnabled = true;
            this.cbooption.Location = new System.Drawing.Point(348, 11);
            this.cbooption.Name = "cbooption";
            this.cbooption.Size = new System.Drawing.Size(258, 21);
            this.cbooption.TabIndex = 4;
            // 
            // Etat_Rapport_MbreVieux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "Etat_Rapport_MbreVieux";
            this.Size = new System.Drawing.Size(1057, 585);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbooption;
    }
}
