namespace JentrousMarketing.Forms.Suppliers
{
    partial class SupplierPage
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
            this.RPSupplier = new Telerik.WinControls.UI.RadPanel();
            this.SupplierTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RGVSupplier = new Telerik.WinControls.UI.RadGridView();
            this.RPSearchBar = new Telerik.WinControls.UI.RadPanel();
            this.RTBSearch = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RBtnSearch = new Telerik.WinControls.UI.RadButton();
            this.RLSearch = new Telerik.WinControls.UI.RadLabel();
            this.ButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.RBtnDelete = new Telerik.WinControls.UI.RadButton();
            this.RBtnRefresh = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.RPSupplier)).BeginInit();
            this.RPSupplier.SuspendLayout();
            this.SupplierTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVSupplier.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPSearchBar)).BeginInit();
            this.RPSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLSearch)).BeginInit();
            this.ButtonTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // RPSupplier
            // 
            this.RPSupplier.Controls.Add(this.SupplierTableLayout);
            this.RPSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPSupplier.Location = new System.Drawing.Point(0, 0);
            this.RPSupplier.Name = "RPSupplier";
            this.RPSupplier.Size = new System.Drawing.Size(790, 509);
            this.RPSupplier.TabIndex = 0;
            this.RPSupplier.Text = "radPanel1";
            // 
            // SupplierTableLayout
            // 
            this.SupplierTableLayout.ColumnCount = 1;
            this.SupplierTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SupplierTableLayout.Controls.Add(this.RGVSupplier, 0, 1);
            this.SupplierTableLayout.Controls.Add(this.RPSearchBar, 0, 0);
            this.SupplierTableLayout.Controls.Add(this.ButtonTableLayout, 0, 2);
            this.SupplierTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierTableLayout.Location = new System.Drawing.Point(0, 0);
            this.SupplierTableLayout.Name = "SupplierTableLayout";
            this.SupplierTableLayout.RowCount = 3;
            this.SupplierTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SupplierTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SupplierTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.SupplierTableLayout.Size = new System.Drawing.Size(790, 509);
            this.SupplierTableLayout.TabIndex = 0;
            // 
            // RGVSupplier
            // 
            this.RGVSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.RGVSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGVSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RGVSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(72)))), ((int)(((byte)(58)))));
            this.RGVSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RGVSupplier.Location = new System.Drawing.Point(3, 43);
            // 
            // RGVSupplier
            // 
            this.RGVSupplier.MasterTemplate.AllowAddNewRow = false;
            this.RGVSupplier.MasterTemplate.AutoGenerateColumns = false;
            this.RGVSupplier.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "SupplierId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.MaxWidth = 100;
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "SupplierId";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.MinWidth = 150;
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 243;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Address";
            gridViewTextBoxColumn3.MinWidth = 200;
            gridViewTextBoxColumn3.Name = "Address";
            gridViewTextBoxColumn3.Width = 440;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Contact Number";
            gridViewTextBoxColumn4.MaxWidth = 100;
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "ContactNumber";
            gridViewTextBoxColumn4.Width = 100;
            this.RGVSupplier.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.RGVSupplier.MasterTemplate.EnableGrouping = false;
            this.RGVSupplier.MasterTemplate.ShowRowHeaderColumn = false;
            this.RGVSupplier.Name = "RGVSupplier";
            this.RGVSupplier.Padding = new System.Windows.Forms.Padding(1);
            this.RGVSupplier.ReadOnly = true;
            this.RGVSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGVSupplier.Size = new System.Drawing.Size(784, 393);
            this.RGVSupplier.TabIndex = 2;
            this.RGVSupplier.Text = "radGridView1";
            this.RGVSupplier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RGVSupplier_MouseDoubleClick);
            // 
            // RPSearchBar
            // 
            this.RPSearchBar.Controls.Add(this.RTBSearch);
            this.RPSearchBar.Controls.Add(this.RBtnSearch);
            this.RPSearchBar.Controls.Add(this.RLSearch);
            this.RPSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPSearchBar.Location = new System.Drawing.Point(3, 3);
            this.RPSearchBar.Name = "RPSearchBar";
            this.RPSearchBar.Size = new System.Drawing.Size(784, 34);
            this.RPSearchBar.TabIndex = 1;
            // 
            // RTBSearch
            // 
            this.RTBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBSearch.Location = new System.Drawing.Point(85, 5);
            this.RTBSearch.Name = "RTBSearch";
            this.RTBSearch.Size = new System.Drawing.Size(645, 26);
            this.RTBSearch.TabIndex = 6;
            // 
            // RBtnSearch
            // 
            this.RBtnSearch.Location = new System.Drawing.Point(736, 5);
            this.RBtnSearch.Name = "RBtnSearch";
            this.RBtnSearch.Size = new System.Drawing.Size(45, 26);
            this.RBtnSearch.TabIndex = 1;
            this.RBtnSearch.Text = "Search";
            // 
            // RLSearch
            // 
            this.RLSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLSearch.Location = new System.Drawing.Point(3, 5);
            this.RLSearch.Name = "RLSearch";
            this.RLSearch.Size = new System.Drawing.Size(76, 26);
            this.RLSearch.TabIndex = 5;
            this.RLSearch.Text = "Search:";
            // 
            // ButtonTableLayout
            // 
            this.ButtonTableLayout.ColumnCount = 7;
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayout.Controls.Add(this.RBtnRefresh, 5, 1);
            this.ButtonTableLayout.Controls.Add(this.RBtnDelete, 3, 1);
            this.ButtonTableLayout.Controls.Add(this.RBtnAdd, 1, 1);
            this.ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTableLayout.Location = new System.Drawing.Point(3, 442);
            this.ButtonTableLayout.Name = "ButtonTableLayout";
            this.ButtonTableLayout.RowCount = 3;
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ButtonTableLayout.Size = new System.Drawing.Size(784, 64);
            this.ButtonTableLayout.TabIndex = 3;
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtnAdd.Location = new System.Drawing.Point(42, 12);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(150, 38);
            this.RBtnAdd.TabIndex = 0;
            this.RBtnAdd.Text = "Add";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // RBtnDelete
            // 
            this.RBtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtnDelete.Location = new System.Drawing.Point(237, 12);
            this.RBtnDelete.Name = "RBtnDelete";
            this.RBtnDelete.Size = new System.Drawing.Size(150, 38);
            this.RBtnDelete.TabIndex = 10;
            this.RBtnDelete.Text = "Delete";
            this.RBtnDelete.Click += new System.EventHandler(this.RBtnDelete_Click);
            // 
            // RBtnRefresh
            // 
            this.RBtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtnRefresh.Location = new System.Drawing.Point(432, 12);
            this.RBtnRefresh.Name = "RBtnRefresh";
            this.RBtnRefresh.Size = new System.Drawing.Size(150, 38);
            this.RBtnRefresh.TabIndex = 12;
            this.RBtnRefresh.Text = "Refresh";
            this.RBtnRefresh.Click += new System.EventHandler(this.RBtnRefresh_Click);
            // 
            // SupplierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RPSupplier);
            this.Name = "SupplierPage";
            this.Size = new System.Drawing.Size(790, 509);
            ((System.ComponentModel.ISupportInitialize)(this.RPSupplier)).EndInit();
            this.RPSupplier.ResumeLayout(false);
            this.SupplierTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVSupplier.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPSearchBar)).EndInit();
            this.RPSearchBar.ResumeLayout(false);
            this.RPSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLSearch)).EndInit();
            this.ButtonTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel RPSupplier;
        private System.Windows.Forms.TableLayoutPanel SupplierTableLayout;
        private Telerik.WinControls.UI.RadPanel RPSearchBar;
        private Telerik.WinControls.UI.RadTextBoxControl RTBSearch;
        private Telerik.WinControls.UI.RadButton RBtnSearch;
        private Telerik.WinControls.UI.RadLabel RLSearch;
        private Telerik.WinControls.UI.RadGridView RGVSupplier;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayout;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
        private Telerik.WinControls.UI.RadButton RBtnRefresh;
        private Telerik.WinControls.UI.RadButton RBtnDelete;
    }
}
