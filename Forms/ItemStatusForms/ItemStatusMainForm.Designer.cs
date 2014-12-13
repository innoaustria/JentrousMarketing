namespace JentrousMarketing.Forms.ItemStatusForms
{
    partial class ItemStatusMainForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.ItemStatusTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RGVItemStatus = new Telerik.WinControls.UI.RadGridView();
            this.ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.RBtnCancel = new Telerik.WinControls.UI.RadButton();
            this.ItemStatusTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVItemStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVItemStatus.MasterTemplate)).BeginInit();
            this.ButtonsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemStatusTableLayout
            // 
            this.ItemStatusTableLayout.ColumnCount = 3;
            this.ItemStatusTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemStatusTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemStatusTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemStatusTableLayout.Controls.Add(this.RGVItemStatus, 1, 1);
            this.ItemStatusTableLayout.Controls.Add(this.ButtonsLayoutPanel, 1, 2);
            this.ItemStatusTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemStatusTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ItemStatusTableLayout.Name = "ItemStatusTableLayout";
            this.ItemStatusTableLayout.RowCount = 4;
            this.ItemStatusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemStatusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemStatusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.ItemStatusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemStatusTableLayout.Size = new System.Drawing.Size(224, 268);
            this.ItemStatusTableLayout.TabIndex = 0;
            // 
            // RGVItemStatus
            // 
            this.RGVItemStatus.BackColor = System.Drawing.Color.White;
            this.RGVItemStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGVItemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RGVItemStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(72)))), ((int)(((byte)(58)))));
            this.RGVItemStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RGVItemStatus.Location = new System.Drawing.Point(23, 23);
            // 
            // RGVItemStatus
            // 
            this.RGVItemStatus.MasterTemplate.AllowAddNewRow = false;
            this.RGVItemStatus.MasterTemplate.AllowColumnReorder = false;
            this.RGVItemStatus.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Item Status";
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "ItemStatus";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 151;
            gridViewCommandColumn1.AllowSort = false;
            gridViewCommandColumn1.DefaultText = "-";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.MaxWidth = 25;
            gridViewCommandColumn1.MinWidth = 25;
            gridViewCommandColumn1.Name = "-";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 25;
            this.RGVItemStatus.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1});
            this.RGVItemStatus.MasterTemplate.EnableGrouping = false;
            this.RGVItemStatus.MasterTemplate.ShowRowHeaderColumn = false;
            this.RGVItemStatus.Name = "RGVItemStatus";
            this.RGVItemStatus.Padding = new System.Windows.Forms.Padding(1);
            this.RGVItemStatus.ReadOnly = true;
            this.RGVItemStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGVItemStatus.ShowGroupPanel = false;
            this.RGVItemStatus.Size = new System.Drawing.Size(178, 152);
            this.RGVItemStatus.TabIndex = 0;
            this.RGVItemStatus.Text = "radGridView1";
            this.RGVItemStatus.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.RGVItemStatus_CommandCellClick);
            this.RGVItemStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RGVItemStatus_MouseDoubleClick);
            // 
            // ButtonsLayoutPanel
            // 
            this.ButtonsLayoutPanel.ColumnCount = 1;
            this.ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsLayoutPanel.Controls.Add(this.RBtnAdd, 0, 0);
            this.ButtonsLayoutPanel.Controls.Add(this.RBtnCancel, 0, 1);
            this.ButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayoutPanel.Location = new System.Drawing.Point(23, 181);
            this.ButtonsLayoutPanel.Name = "ButtonsLayoutPanel";
            this.ButtonsLayoutPanel.RowCount = 2;
            this.ButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayoutPanel.Size = new System.Drawing.Size(178, 64);
            this.ButtonsLayoutPanel.TabIndex = 1;
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtnAdd.Location = new System.Drawing.Point(3, 3);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(172, 26);
            this.RBtnAdd.TabIndex = 0;
            this.RBtnAdd.Text = "Add";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // RBtnCancel
            // 
            this.RBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RBtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtnCancel.Location = new System.Drawing.Point(3, 35);
            this.RBtnCancel.Name = "RBtnCancel";
            this.RBtnCancel.Size = new System.Drawing.Size(172, 26);
            this.RBtnCancel.TabIndex = 1;
            this.RBtnCancel.Text = "Close";
            // 
            // ItemStatusMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RBtnCancel;
            this.ClientSize = new System.Drawing.Size(224, 268);
            this.Controls.Add(this.ItemStatusTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ItemStatusMainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Status";
            this.ThemeName = "ControlDefault";
            this.ItemStatusTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVItemStatus.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVItemStatus)).EndInit();
            this.ButtonsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemStatusTableLayout;
        private Telerik.WinControls.UI.RadGridView RGVItemStatus;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayoutPanel;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
        private Telerik.WinControls.UI.RadButton RBtnCancel;
    }
}
