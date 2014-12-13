using System;
using System.Windows.Forms;
using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;
using Telerik.WinControls.UI;

namespace JentrousMarketing.Forms.ItemStatusForms
{
    public partial class ItemStatusMainForm : Telerik.WinControls.UI.RadForm
    {
        public ItemStatusMainForm()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            var itemStatusDto = new ItemStatusDTO();
            var itemStatusList = itemStatusDto.getItemStatusList();
            foreach (ItemStatus itemStatus in itemStatusList)
            {
                var rowItem = RGVItemStatus.Rows.AddNew();
                rowItem.Cells["ItemStatus"].Value = itemStatus.ItemStatusId;
            }
        }

        private void RGVItemStatus_CommandCellClick(object sender, EventArgs e)
        {
            var cell = sender as GridCommandCellElement;
            if (cell == null) return;
            var cellIsMinus = cell.CommandButton.TextElement.Text.Equals("-");
            if (cellIsMinus)
            {
                cell.RowInfo.Delete();
                //Delete Item Status Here
            }
        }
        private void RGVItemStatus_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                var item = RGVItemStatus.SelectedRows[0];
                if (item != null)
                {
                    var itemStatus = new DBObjects.ItemStatus(item.Cells["ItemStatus"].Value.ToString());

                    var itemStatusForm = new ItemStatusForm(itemStatus, "update");
                    itemStatusForm.ShowDialog();
                }
            }
        }

        private void RBtnAdd_Click(object sender, EventArgs e)
        {
            var itemStatusForm = new ItemStatusForm(null, "add");
            itemStatusForm.ShowDialog();
            RGVItemStatus.Rows.Clear();
            PopulateGridView();
        }

    }
}
