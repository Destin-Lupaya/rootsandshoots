namespace rootsandshoots
{
    partial class FormAproposdeRS
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Maroon;
            this.Button1.Location = new System.Drawing.Point(548, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(352, 31);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Afficher leSiteweb de Roots-Shoot";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(-20, 98);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(964, 39);
            this.Panel1.TabIndex = 30;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Label1.Location = new System.Drawing.Point(30, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(414, 19);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Cliquez pour tout savoir apropos Roots-Shoots. Visitez le Siteweb!";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.Control;
            this.Label5.Location = new System.Drawing.Point(335, 247);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(229, 19);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "Vous devez etre connecté à Internet";
            // 
            // FormAproposdeRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label5);
            this.Name = "FormAproposdeRS";
            this.Size = new System.Drawing.Size(924, 364);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
    }
}
