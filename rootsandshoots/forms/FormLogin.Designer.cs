namespace rootsandshoots
{
    partial class FormLogin
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
            System.Windows.Forms.GroupBox GroupBox1;
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.CmbUserType = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Txtpass = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Enabled = false;
            GroupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GroupBox1.Location = new System.Drawing.Point(587, 126);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            GroupBox1.Size = new System.Drawing.Size(132, 133);
            GroupBox1.TabIndex = 19;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Authentification";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(GroupBox1);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.CmbUserType);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Txtpass);
            this.Panel1.Controls.Add(this.TxtUser);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.BtnLogin);
            this.Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.Panel1.Location = new System.Drawing.Point(91, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(786, 557);
            this.Panel1.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Label5.Location = new System.Drawing.Point(137, 27);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(467, 33);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Roots and Shoots Account Login";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(591, 448);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(119, 33);
            this.Button2.TabIndex = 21;
            this.Button2.Text = "Cliquez ICI !!!";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(391, 455);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(185, 16);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Si vous n\'etes pas Administrateur";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.IndianRed;
            this.Button1.Location = new System.Drawing.Point(25, 325);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(168, 45);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "DECONNEXION";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // CmbUserType
            // 
            this.CmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUserType.FormattingEnabled = true;
            this.CmbUserType.Items.AddRange(new object[] {
            "admin"});
            this.CmbUserType.Location = new System.Drawing.Point(295, 225);
            this.CmbUserType.Name = "CmbUserType";
            this.CmbUserType.Size = new System.Drawing.Size(224, 32);
            this.CmbUserType.TabIndex = 17;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Label3.Location = new System.Drawing.Point(25, 227);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(169, 24);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Type d\'utilisateur";
            // 
            // Txtpass
            // 
            this.Txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpass.Location = new System.Drawing.Point(295, 177);
            this.Txtpass.Name = "Txtpass";
            this.Txtpass.Size = new System.Drawing.Size(224, 29);
            this.Txtpass.TabIndex = 15;
            this.Txtpass.UseSystemPasswordChar = true;
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.Location = new System.Drawing.Point(295, 132);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(224, 29);
            this.TxtUser.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Label2.Location = new System.Drawing.Point(25, 181);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 24);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Mot de Pass";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Label1.Location = new System.Drawing.Point(25, 133);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(151, 24);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Nom Utilisateur";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLogin.Location = new System.Drawing.Point(555, 323);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(164, 45);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "Sign in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 651);
            this.Controls.Add(this.Panel1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox CmbUserType;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Txtpass;
        internal System.Windows.Forms.TextBox TxtUser;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnLogin;
    }
}