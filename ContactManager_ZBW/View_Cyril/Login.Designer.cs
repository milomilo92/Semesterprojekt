namespace ContactManager_ZBW.View_Cyril
{
    partial class Login
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(20, 49);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(118, 20);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Benutzername:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(54, 102);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(80, 20);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Kennwort:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtUsername.Location = new System.Drawing.Point(147, 49);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(216, 26);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(146, 91);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(216, 26);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // CmdLogin
            // 
            this.CmdLogin.Location = new System.Drawing.Point(392, 49);
            this.CmdLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(112, 72);
            this.CmdLogin.TabIndex = 3;
            this.CmdLogin.Text = "Login";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 171);
            this.ControlBox = false;
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button CmdLogin;
    }
}