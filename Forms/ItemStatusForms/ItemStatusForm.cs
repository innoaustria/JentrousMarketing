using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;
using Telerik.WinControls;
using System;

namespace JentrousMarketing.Forms.ItemStatusForms
{
    public partial class ItemStatusForm : Telerik.WinControls.UI.RadForm
    {
        private string action;
        private ItemStatus itemStatus;

        public ItemStatusForm(ItemStatus itemStatus, string action)
        {
            InitializeComponent();

            this.action = action;
            this.itemStatus = itemStatus;

            if (action == "add")
            {
                Text = "Add Item Status";
                RBtnAdd.Text = "Add";
                RTBItemStatus.Enabled = true;
            }

            if (action == "update")
            {
                RTBItemStatus.Text = itemStatus.ItemStatusId.ToString();
                RTBDescription.Text = itemStatus.ItemStatusDesc;
            }
        }

        private void RBtnAdd_Click(object sender, System.EventArgs e)
        {
            if (action == "update")
            {

                ItemStatusDTO itemStatusDto = new ItemStatusDTO();
                ItemStatus itemStatus = new ItemStatus();

                itemStatus.ItemStatusId = Int32.Parse(RTBItemStatus.Text);
                itemStatus.ItemStatusDesc = RTBDescription.Text;
                itemStatus.Version = this.itemStatus.Version;

                int stat = itemStatusDto.updateItemStatus(itemStatus);
                if (stat > 0)
                {
                    RadMessageBox.Show("Item Status Updated!");
                    this.Close();
                }

                if (stat == -1)
                {
                    RadMessageBox.Show("Item Status Already Updated! Please close window and try again.");
                }
            }

            if (action == "add")
            {
                ItemStatusDTO itemStatusDto = new ItemStatusDTO();
                ItemStatus itemStatus = new ItemStatus();

                itemStatus.ItemStatusId = Int32.Parse(RTBItemStatus.Text);
                itemStatus.ItemStatusDesc = RTBDescription.Text;

                if (itemStatusDto.createItemStatus(itemStatus) > 0)
                {
                    RadMessageBox.Show("Item Status Created!");
                    Close();
                }
                else
                {
                    RadMessageBox.Show("Error saving to DB!");
                }
            }
        }
    }
}
