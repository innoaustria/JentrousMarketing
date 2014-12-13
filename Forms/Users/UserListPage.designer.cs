namespace JentrousMarketing.Forms.Users
{
    partial class UserListPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.RPUserPage = new Telerik.WinControls.UI.RadPanel();
            this.UserPageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RPButtonLayout = new Telerik.WinControls.UI.RadPanel();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.RbtnRefresh = new Telerik.WinControls.UI.RadButton();
            this.RGVUserList = new Telerik.WinControls.UI.RadGridView();
            this.radGridView1 = new Telerik.WinControls.UI.MasterGridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.RPUserPage)).BeginInit();
            this.RPUserPage.SuspendLayout();
            this.UserPageTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPButtonLayout)).BeginInit();
            this.RPButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RPUserPage
            // 
            this.RPUserPage.Controls.Add(this.UserPageTableLayout);
            this.RPUserPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPUserPage.Location = new System.Drawing.Point(0, 0);
            this.RPUserPage.Name = "RPUserPage";
            this.RPUserPage.Size = new System.Drawing.Size(790, 509);
            this.RPUserPage.TabIndex = 0;
            this.RPUserPage.Text = "UserPage";
            this.RPUserPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPageTableLayout
            // 
            this.UserPageTableLayout.ColumnCount = 1;
            this.UserPageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserPageTableLayout.Controls.Add(this.RPButtonLayout, 0, 1);
            this.UserPageTableLayout.Controls.Add(this.RGVUserList, 0, 0);
            this.UserPageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPageTableLayout.Location = new System.Drawing.Point(0, 0);
            this.UserPageTableLayout.Name = "UserPageTableLayout";
            this.UserPageTableLayout.RowCount = 2;
            this.UserPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.UserPageTableLayout.Size = new System.Drawing.Size(790, 509);
            this.UserPageTableLayout.TabIndex = 4;
            // 
            // RPButtonLayout
            // 
            this.RPButtonLayout.Controls.Add(this.RBtnAdd);
            this.RPButtonLayout.Controls.Add(this.RbtnRefresh);
            this.RPButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPButtonLayout.Location = new System.Drawing.Point(3, 442);
            this.RPButtonLayout.Name = "RPButtonLayout";
            this.RPButtonLayout.Size = new System.Drawing.Size(784, 64);
            this.RPButtonLayout.TabIndex = 0;
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAdd.Location = new System.Drawing.Point(16, 13);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(125, 37);
            this.RBtnAdd.TabIndex = 1;
            this.RBtnAdd.Text = "Add";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // RbtnRefresh
            // 
            this.RbtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnRefresh.Location = new System.Drawing.Point(163, 13);
            this.RbtnRefresh.Name = "RbtnRefresh";
            this.RbtnRefresh.Size = new System.Drawing.Size(142, 39);
            this.RbtnRefresh.TabIndex = 2;
            this.RbtnRefresh.Text = "Refresh";
            this.RbtnRefresh.Click += new System.EventHandler(this.RbtnRefresh_Click);
            // 
            // RGVUserList
            // 
            this.RGVUserList.BackColor = System.Drawing.SystemColors.Control;
            this.RGVUserList.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGVUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGVUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(72)))), ((int)(((byte)(58)))));
            this.RGVUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RGVUserList.Location = new System.Drawing.Point(3, 3);
            // 
            // RGVUserList
            // 
            this.RGVUserList.MasterTemplate.AllowAddNewRow = false;
            this.RGVUserList.MasterTemplate.AllowColumnReorder = false;
            this.RGVUserList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Username";
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "Username";
            gridViewTextBoxColumn1.Width = 197;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Password";
            gridViewTextBoxColumn2.MinWidth = 100;
            gridViewTextBoxColumn2.Name = "Password";
            gridViewTextBoxColumn2.Width = 197;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn3.Width = 197;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Role";
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "Role";
            gridViewTextBoxColumn4.Width = 193;
            this.RGVUserList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.RGVUserList.MasterTemplate.ShowRowHeaderColumn = false;
            this.RGVUserList.Name = "RGVUserList";
            this.RGVUserList.Padding = new System.Windows.Forms.Padding(1);
            this.RGVUserList.ReadOnly = true;
            this.RGVUserList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGVUserList.Size = new System.Drawing.Size(784, 433);
            this.RGVUserList.TabIndex = 3;
            this.RGVUserList.Text = "radGridView2";
            this.RGVUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RGVUserList_MouseDoubleClick);
            // 
            // radGridView1
            // 
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Username";
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "Username";
            gridViewTextBoxColumn5.Width = 132;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Password";
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "Password";
            gridViewTextBoxColumn6.Width = 132;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "Name";
            gridViewTextBoxColumn7.MinWidth = 100;
            gridViewTextBoxColumn7.Name = "Name";
            gridViewTextBoxColumn7.Width = 132;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "Role";
            gridViewTextBoxColumn8.MinWidth = 100;
            gridViewTextBoxColumn8.Name = "Role";
            gridViewTextBoxColumn8.Width = 337;
            this.radGridView1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            // 
            // UserListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RPUserPage);
            this.Name = "UserListPage";
            this.Size = new System.Drawing.Size(790, 509);
            ((System.ComponentModel.ISupportInitialize)(this.RPUserPage)).EndInit();
            this.RPUserPage.ResumeLayout(false);
            this.UserPageTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RPButtonLayout)).EndInit();
            this.RPButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel RPUserPage;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
        private Telerik.WinControls.UI.RadButton RbtnRefresh;
        private Telerik.WinControls.UI.MasterGridViewTemplate radGridView1;
        private System.Windows.Forms.TableLayoutPanel UserPageTableLayout;
        private Telerik.WinControls.UI.RadPanel RPButtonLayout;
        private Telerik.WinControls.UI.RadGridView RGVUserList;
    }
}
