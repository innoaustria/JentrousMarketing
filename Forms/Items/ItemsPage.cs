using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;

namespace JentrousMarketing.Forms.Items
{
    public partial class ItemsPage : UserControl
    {
        public ItemsPage()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            var itemDTO = new ItemDTO();
            var items = itemDTO.getItems();
            foreach (Item item in items)
            {
                //ListViewItem lvItem = new ListViewItem(new string[] { user.UserName, user.Password, user.Name, user.Role });
                //RGVUserList.Rows.Add(lvItem);
                var rowItem = RGVItems.Rows.AddNew();
                rowItem.Cells["Description"].Value = item.Description;
                rowItem.Cells["Brand"].Value = item.Brand;
                rowItem.Cells["Model"].Value = item.Model;
                rowItem.Cells["UOM"].Value = item.Uom;
                rowItem.Cells["RetailPrice"].Value = item.Cost;
                rowItem.Cells["Cost"].Value = item.Cost;
                rowItem.Cells["Quantity"].Value = item.Stock_qty;
                //RGVUserList.Rows.Add(rowItem);
            }
        }

        private void RGVItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void RBtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void RBtnDelete_Click(object sender, EventArgs e)
        {
            if (RGVItems.SelectedRows.Count>0 && RadMessageBox.Show("Are you sure you want to delete this item?", "Delete item", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation) == DialogResult.Yes)
            {
                RGVItems.SelectedRows[0].Delete(); // -- delete from gridview
                //Dito lagay delete item sa db
            }
        }

        private void RBtnRefresh_Click(object sender, EventArgs e)
        {
            RGVItems.Rows.Clear();
            PopulateGridView();
        }
    }
}
