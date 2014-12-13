namespace JentrousMarketing.Forms.Users
{
    partial class UserForm
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
            this.RLUser = new Telerik.WinControls.UI.RadLabel();
            this.RLPass = new Telerik.WinControls.UI.RadLabel();
            this.RTBUser = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RTBPass = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.RBtnCancel = new Telerik.WinControls.UI.RadButton();
            this.RTBRetype = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RLRetype = new Telerik.WinControls.UI.RadLabel();
            this.RTBName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RLName = new Telerik.WinControls.UI.RadLabel();
            this.RLRole = new Telerik.WinControls.UI.RadLabel();
            this.RDDRole = new Telerik.WinControls.UI.RadDropDownList();
            this.RCBShowPassword = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RLUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBRetype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLRetype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDDRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCBShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RLUser
            // 
            this.RLUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLUser.Location = new System.Drawing.Point(85, 29);
            this.RLUser.Name = "RLUser";
            this.RLUser.Size = new System.Drawing.Size(108, 26);
            this.RLUser.TabIndex = 0;
            this.RLUser.Text = "UserName:";
            // 
            // RLPass
            // 
            this.RLPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLPass.Location = new System.Drawing.Point(93, 74);
            this.RLPass.Name = "RLPass";
            this.RLPass.Size = new System.Drawing.Size(100, 26);
            this.RLPass.TabIndex = 1;
            this.RLPass.Text = "Password:";
            // 
            // RTBUser
            // 
            this.RTBUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBUser.Enabled = false;
            this.RTBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBUser.Location = new System.Drawing.Point(199, 29);
            this.RTBUser.Name = "RTBUser";
            this.RTBUser.Size = new System.Drawing.Size(287, 26);
            this.RTBUser.TabIndex = 1;
            // 
            // RTBPass
            // 
            this.RTBPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBPass.Location = new System.Drawing.Point(199, 74);
            this.RTBPass.Name = "RTBPass";
            this.RTBPass.PasswordChar = '●';
            this.RTBPass.Size = new System.Drawing.Size(287, 26);
            this.RTBPass.TabIndex = 2;
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAdd.Location = new System.Drawing.Point(60, 282);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(167, 40);
            this.RBtnAdd.TabIndex = 7;
            this.RBtnAdd.Text = "Update";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // RBtnCancel
            // 
            this.RBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCancel.Location = new System.Drawing.Point(278, 282);
            this.RBtnCancel.Name = "RBtnCancel";
            this.RBtnCancel.Size = new System.Drawing.Size(191, 40);
            this.RBtnCancel.TabIndex = 8;
            this.RBtnCancel.Text = "Cancel";
            // 
            // RTBRetype
            // 
            this.RTBRetype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBRetype.Location = new System.Drawing.Point(199, 120);
            this.RTBRetype.Name = "RTBRetype";
            this.RTBRetype.PasswordChar = '●';
            this.RTBRetype.Size = new System.Drawing.Size(287, 26);
            this.RTBRetype.TabIndex = 3;
            // 
            // RLRetype
            // 
            this.RLRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLRetype.Location = new System.Drawing.Point(26, 120);
            this.RLRetype.Name = "RLRetype";
            this.RLRetype.Size = new System.Drawing.Size(167, 26);
            this.RLRetype.TabIndex = 6;
            this.RLRetype.Text = "Retype Password:";
            // 
            // RTBName
            // 
            this.RTBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBName.Location = new System.Drawing.Point(199, 187);
            this.RTBName.Name = "RTBName";
            this.RTBName.Size = new System.Drawing.Size(287, 26);
            this.RTBName.TabIndex = 5;
            // 
            // RLName
            // 
            this.RLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLName.Location = new System.Drawing.Point(127, 187);
            this.RLName.Name = "RLName";
            this.RLName.Size = new System.Drawing.Size(66, 26);
            this.RLName.TabIndex = 8;
            this.RLName.Text = "Name:";
            // 
            // RLRole
            // 
            this.RLRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLRole.Location = new System.Drawing.Point(138, 229);
            this.RLRole.Name = "RLRole";
            this.RLRole.Size = new System.Drawing.Size(55, 26);
            this.RLRole.TabIndex = 10;
            this.RLRole.Text = "Role:";
            // 
            // RDDRole
            // 
            this.RDDRole.AllowShowFocusCues = false;
            this.RDDRole.AutoCompleteDisplayMember = null;
            this.RDDRole.AutoCompleteValueMember = null;
            this.RDDRole.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.RDDRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDDRole.Location = new System.Drawing.Point(199, 229);
            this.RDDRole.Name = "RDDRole";
            this.RDDRole.Size = new System.Drawing.Size(287, 29);
            this.RDDRole.TabIndex = 6;
            // 
            // RCBShowPassword
            // 
            this.RCBShowPassword.Location = new System.Drawing.Point(199, 152);
            this.RCBShowPassword.Name = "RCBShowPassword";
            this.RCBShowPassword.Size = new System.Drawing.Size(101, 16);
            this.RCBShowPassword.TabIndex = 4;
            this.RCBShowPassword.Text = "Show Password";
            this.RCBShowPassword.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RCBShowPassword_ToggleStateChanged);
            // 
            // UserForm
            // 
            this.AcceptButton = this.RBtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RBtnCancel;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.RCBShowPassword);
            this.Controls.Add(this.RDDRole);
            this.Controls.Add(this.RLRole);
            this.Controls.Add(this.RTBName);
            this.Controls.Add(this.RLName);
            this.Controls.Add(this.RTBRetype);
            this.Controls.Add(this.RLRetype);
            this.Controls.Add(this.RBtnCancel);
            this.Controls.Add(this.RBtnAdd);
            this.Controls.Add(this.RTBPass);
            this.Controls.Add(this.RTBUser);
            this.Controls.Add(this.RLPass);
            this.Controls.Add(this.RLUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.RLUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBRetype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLRetype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDDRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCBShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel RLUser;
        private Telerik.WinControls.UI.RadLabel RLPass;
        private Telerik.WinControls.UI.RadTextBoxControl RTBUser;
        private Telerik.WinControls.UI.RadTextBoxControl RTBPass;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
        private Telerik.WinControls.UI.RadButton RBtnCancel;
        private Telerik.WinControls.UI.RadTextBoxControl RTBRetype;
        private Telerik.WinControls.UI.RadLabel RLRetype;
        private Telerik.WinControls.UI.RadTextBoxControl RTBName;
        private Telerik.WinControls.UI.RadLabel RLName;
        private Telerik.WinControls.UI.RadLabel RLRole;
        private Telerik.WinControls.UI.RadDropDownList RDDRole;
        private Telerik.WinControls.UI.RadCheckBox RCBShowPassword;
    }
}
