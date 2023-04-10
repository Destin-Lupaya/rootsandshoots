namespace rootsandshoots
{
    partial class FormImportToExcel
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CboSheet = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClassMembreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassMembreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location = new System.Drawing.Point(31, 23);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1063, 39);
            this.Panel1.TabIndex = 46;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(131, 6);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(825, 29);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "IMPORTER LES DONNEES DES MEMBRES APARTIR DE MS EXCEL";
            // 
            // BtnImport
            // 
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.Location = new System.Drawing.Point(387, 648);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(181, 37);
            this.BtnImport.TabIndex = 45;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(90, 657);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 24);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Sheet";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(788, 589);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(270, 34);
            this.btnBrowser.TabIndex = 42;
            this.btnBrowser.Text = ".... Browse (Parcourir)";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(217, 599);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(550, 20);
            this.txtFileName.TabIndex = 41;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(86, 599);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 24);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "File name";
            // 
            // CboSheet
            // 
            this.CboSheet.FormattingEnabled = true;
            this.CboSheet.Location = new System.Drawing.Point(217, 654);
            this.CboSheet.Name = "CboSheet";
            this.CboSheet.Size = new System.Drawing.Size(121, 21);
            this.CboSheet.TabIndex = 44;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.DataSource = this.ClassMembreBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(14, 82);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(1216, 490);
            this.DataGridView1.TabIndex = 39;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.Control;
            this.Label5.Location = new System.Drawing.Point(272, 713);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(396, 19);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "Le fichier Excel doit etre enregistrer au Format Excel 97-2003";
            // 
            // FormImportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 749);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CboSheet);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label5);
            this.Name = "FormImportToExcel";
            this.Text = "FormImportToExcel";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassMembreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button BtnImport;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnBrowser;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox CboSheet;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.BindingSource ClassMembreBindingSource;
        internal System.Windows.Forms.Label Label5;
    }
}