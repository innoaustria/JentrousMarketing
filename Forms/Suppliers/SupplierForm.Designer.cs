namespace JentrousMarketing.Forms.Suppliers
{
    partial class SupplierForm
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
            this.RLSupplier = new Telerik.WinControls.UI.RadLabel();
            this.RLAddress = new Telerik.WinControls.UI.RadLabel();
            this.RLContact = new Telerik.WinControls.UI.RadLabel();
            this.RTBSupplier = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RTBAddress = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RTBContact = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.RBtnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.RLSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RLSupplier
            // 
            this.RLSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLSupplier.Location = new System.Drawing.Point(38, 12);
            this.RLSupplier.Name = "RLSupplier";
            this.RLSupplier.Size = new System.Drawing.Size(86, 26);
            this.RLSupplier.TabIndex = 0;
            this.RLSupplier.Text = "Supplier:";
            // 
            // RLAddress
            // 
            this.RLAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLAddress.Location = new System.Drawing.Point(38, 62);
            this.RLAddress.Name = "RLAddress";
            this.RLAddress.Size = new System.Drawing.Size(86, 26);
            this.RLAddress.TabIndex = 1;
            this.RLAddress.Text = "Address:";
            // 
            // RLContact
            // 
            this.RLContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLContact.Location = new System.Drawing.Point(12, 151);
            this.RLContact.Name = "RLContact";
            this.RLContact.Size = new System.Drawing.Size(112, 26);
            this.RLContact.TabIndex = 2;
            this.RLContact.Text = "Contact No:";
            // 
            // RTBSupplier
            // 
            this.RTBSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBSupplier.Enabled = false;
            this.RTBSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBSupplier.Location = new System.Drawing.Point(130, 12);
            this.RTBSupplier.Name = "RTBSupplier";
            this.RTBSupplier.Size = new System.Drawing.Size(353, 26);
            this.RTBSupplier.TabIndex = 3;
            // 
            // RTBAddress
            // 
            this.RTBAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBAddress.Location = new System.Drawing.Point(130, 62);
            this.RTBAddress.Multiline = true;
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(353, 65);
            this.RTBAddress.TabIndex = 4;
            // 
            // RTBContact
            // 
            this.RTBContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBContact.Location = new System.Drawing.Point(130, 151);
            this.RTBContact.Name = "RTBContact";
            this.RTBContact.Size = new System.Drawing.Size(353, 26);
            this.RTBContact.TabIndex = 5;
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAdd.Location = new System.Drawing.Point(12, 199);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(232, 47);
            this.RBtnAdd.TabIndex = 6;
            this.RBtnAdd.Text = "Add/ Update";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // RBtnCancel
            // 
            this.RBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCancel.Location = new System.Drawing.Point(250, 199);
            this.RBtnCancel.Name = "RBtnCancel";
            this.RBtnCancel.Size = new System.Drawing.Size(232, 47);
            this.RBtnCancel.TabIndex = 7;
            this.RBtnCancel.Text = "Cancel";
            // 
            // SupplierForm
            // 
            this.AcceptButton = this.RBtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RBtnCancel;
            this.ClientSize = new System.Drawing.Size(495, 262);
            this.Controls.Add(this.RBtnCancel);
            this.Controls.Add(this.RBtnAdd);
            this.Controls.Add(this.RTBContact);
            this.Controls.Add(this.RTBAddress);
            this.Controls.Add(this.RTBSupplier);
            this.Controls.Add(this.RLContact);
            this.Controls.Add(this.RLAddress);
            this.Controls.Add(this.RLSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.RLSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel RLSupplier;
        private Telerik.WinControls.UI.RadLabel RLAddress;
        private Telerik.WinControls.UI.RadLabel RLContact;
        private Telerik.WinControls.UI.RadTextBoxControl RTBSupplier;
        private Telerik.WinControls.UI.RadTextBoxControl RTBAddress;
        private Telerik.WinControls.UI.RadTextBoxControl RTBContact;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
        private Telerik.WinControls.UI.RadButton RBtnCancel;
    }
}
