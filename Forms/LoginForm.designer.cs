namespace JentrousMarketing.Forms
{
    partial class LoginForm
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
            this.RLUserName = new Telerik.WinControls.UI.RadLabel();
            this.RLPassword = new Telerik.WinControls.UI.RadLabel();
            this.RTBUserName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RTBPassword = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RBtnLogin = new Telerik.WinControls.UI.RadButton();
            this.customShape1 = new Telerik.WinControls.CustomShape(this.components);
            this.DesertTheme = new Telerik.WinControls.Themes.DesertTheme();
            this.RBtnExit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.RLUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RLUserName
            // 
            this.RLUserName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RLUserName.Location = new System.Drawing.Point(57, 48);
            this.RLUserName.Name = "RLUserName";
            this.RLUserName.Size = new System.Drawing.Size(102, 29);
            this.RLUserName.TabIndex = 1;
            this.RLUserName.Text = "UserName:";
            // 
            // RLPassword
            // 
            this.RLPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RLPassword.Location = new System.Drawing.Point(66, 95);
            this.RLPassword.Name = "RLPassword";
            this.RLPassword.Size = new System.Drawing.Size(93, 29);
            this.RLPassword.TabIndex = 2;
            this.RLPassword.Text = "Password:";
            // 
            // RTBUserName
            // 
            this.RTBUserName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RTBUserName.Location = new System.Drawing.Point(174, 48);
            this.RTBUserName.Name = "RTBUserName";
            this.RTBUserName.Size = new System.Drawing.Size(191, 29);
            this.RTBUserName.TabIndex = 3;
            // 
            // RTBPassword
            // 
            this.RTBPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RTBPassword.Location = new System.Drawing.Point(174, 95);
            this.RTBPassword.Name = "RTBPassword";
            this.RTBPassword.Size = new System.Drawing.Size(191, 29);
            this.RTBPassword.TabIndex = 4;
            this.RTBPassword.PasswordChar = '\u25CF';
            // 
            // RBtnLogin
            // 
            this.RBtnLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RBtnLogin.Location = new System.Drawing.Point(57, 162);
            this.RBtnLogin.Name = "RBtnLogin";
            this.RBtnLogin.Size = new System.Drawing.Size(135, 40);
            this.RBtnLogin.TabIndex = 5;
            this.RBtnLogin.Text = "Login";
            this.RBtnLogin.Click += new System.EventHandler(this.RBtnLogin_Click);
            // 
            // customShape1
            // 
            this.customShape1.AsString = "20,20,200,100:20,20,False,0,0,0,0,0:220,20,False,0,0,0,0,0:220,120,False,0,0,0,0," +
    "0:20,120,False,0,0,0,0,0:";
            // 
            // RBtnExit
            // 
            this.RBtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RBtnExit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RBtnExit.Location = new System.Drawing.Point(230, 162);
            this.RBtnExit.Name = "RBtnExit";
            this.RBtnExit.Size = new System.Drawing.Size(135, 40);
            this.RBtnExit.TabIndex = 6;
            this.RBtnExit.Text = "Exit";
            this.RBtnExit.Click += new System.EventHandler(this.RBtnExit_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.RBtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RBtnExit;
            this.ClientSize = new System.Drawing.Size(436, 241);
            this.Controls.Add(this.RBtnExit);
            this.Controls.Add(this.RTBPassword);
            this.Controls.Add(this.RBtnLogin);
            this.Controls.Add(this.RTBUserName);
            this.Controls.Add(this.RLPassword);
            this.Controls.Add(this.RLUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.RLUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel RLUserName;
        private Telerik.WinControls.UI.RadLabel RLPassword;
        private Telerik.WinControls.UI.RadTextBoxControl RTBUserName;
        private Telerik.WinControls.UI.RadTextBoxControl RTBPassword;
        private Telerik.WinControls.UI.RadButton RBtnLogin;
        private Telerik.WinControls.CustomShape customShape1;
        private Telerik.WinControls.Themes.DesertTheme DesertTheme;
        private Telerik.WinControls.UI.RadButton RBtnExit;
    }
}
