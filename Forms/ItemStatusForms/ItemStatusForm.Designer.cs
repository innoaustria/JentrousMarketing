namespace JentrousMarketing.Forms.ItemStatusForms
{
    partial class ItemStatusForm
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
            this.RLItemStatus = new Telerik.WinControls.UI.RadLabel();
            this.RLDescription = new Telerik.WinControls.UI.RadLabel();
            this.RTBItemStatus = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RTBDescription = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RBtnCancel = new Telerik.WinControls.UI.RadButton();
            this.RBtnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.RLItemStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBItemStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RLItemStatus
            // 
            this.RLItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLItemStatus.Location = new System.Drawing.Point(31, 46);
            this.RLItemStatus.Name = "RLItemStatus";
            this.RLItemStatus.Size = new System.Drawing.Size(113, 26);
            this.RLItemStatus.TabIndex = 1;
            this.RLItemStatus.Text = "Item Status:";
            // 
            // RLDescription
            // 
            this.RLDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLDescription.Location = new System.Drawing.Point(32, 105);
            this.RLDescription.Name = "RLDescription";
            this.RLDescription.Size = new System.Drawing.Size(112, 26);
            this.RLDescription.TabIndex = 2;
            this.RLDescription.Text = "Description:";
            // 
            // RTBItemStatus
            // 
            this.RTBItemStatus.Enabled = false;
            this.RTBItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBItemStatus.Location = new System.Drawing.Point(168, 46);
            this.RTBItemStatus.MaxLength = 6;
            this.RTBItemStatus.Name = "RTBItemStatus";
            this.RTBItemStatus.Size = new System.Drawing.Size(223, 26);
            this.RTBItemStatus.TabIndex = 1;
            // 
            // RTBDescription
            // 
            this.RTBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBDescription.Location = new System.Drawing.Point(168, 105);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.Size = new System.Drawing.Size(223, 26);
            this.RTBDescription.TabIndex = 2;
            // 
            // RBtnCancel
            // 
            this.RBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCancel.Location = new System.Drawing.Point(227, 173);
            this.RBtnCancel.Name = "RBtnCancel";
            this.RBtnCancel.Size = new System.Drawing.Size(130, 39);
            this.RBtnCancel.TabIndex = 4;
            this.RBtnCancel.Text = "Cancel";
            // 
            // RBtnAdd
            // 
            this.RBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAdd.Location = new System.Drawing.Point(66, 173);
            this.RBtnAdd.Name = "RBtnAdd";
            this.RBtnAdd.Size = new System.Drawing.Size(130, 39);
            this.RBtnAdd.TabIndex = 3;
            this.RBtnAdd.Text = "Update";
            this.RBtnAdd.Click += new System.EventHandler(this.RBtnAdd_Click);
            // 
            // ItemStatusForm
            // 
            this.AcceptButton = this.RBtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RBtnCancel;
            this.ClientSize = new System.Drawing.Size(436, 250);
            this.Controls.Add(this.RBtnCancel);
            this.Controls.Add(this.RBtnAdd);
            this.Controls.Add(this.RTBDescription);
            this.Controls.Add(this.RTBItemStatus);
            this.Controls.Add(this.RLDescription);
            this.Controls.Add(this.RLItemStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemStatusForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Item Status";
            this.ThemeName = "Desert";
            ((System.ComponentModel.ISupportInitialize)(this.RLItemStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBItemStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTBDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel RLItemStatus;
        private Telerik.WinControls.UI.RadLabel RLDescription;
        private Telerik.WinControls.UI.RadTextBoxControl RTBItemStatus;
        private Telerik.WinControls.UI.RadTextBoxControl RTBDescription;
        private Telerik.WinControls.UI.RadButton RBtnCancel;
        private Telerik.WinControls.UI.RadButton RBtnAdd;
    }
}
