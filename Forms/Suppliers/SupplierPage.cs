using System;
using System.Windows.Forms;
using JentrousMarketing.TransferObjects;
using Telerik.WinControls;

namespace JentrousMarketing.Forms.Suppliers
{
    public partial class SupplierPage : UserControl
    {
        public SupplierPage()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            var supplierDto = new SupplierDTO();
            var suppliers = supplierDto.getSuppliers();
            foreach (DBObjects.Supplier supplier in suppliers)
            {
                var rowItem = RGVSupplier.Rows.AddNew();
                rowItem.Cells["SupplierId"].Value = supplier.SupplierId;
                rowItem.Cells["Name"].Value = supplier.SupplierName;
                rowItem.Cells["Address"].Value = supplier.Address;
                rowItem.Cells["ContactNumber"].Value = supplier.ContactNo;
            }
        }

        private void RGVSupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                var item = RGVSupplier.SelectedRows[0];
                if (item != null)
                {
                    var supplierId = int.Parse(item.Cells["SupplierId"].Value.ToString());
                    var supplier = new DBObjects.Supplier(supplierId);

                    var supForm = new SupplierForm(supplier,"update");
                    supForm.ShowDialog();

//                    var uForm = new UserForm(user, "update");
//                    uForm.ShowDialog();
                    //Form3 form = new Form3(user, "update");
                    //form.ShowDialog();
                }
            }
        }

        private void RBtnAdd_Click(object sender, EventArgs e)
        {
            var supForm = new SupplierForm(null, "add");
            supForm.ShowDialog();
        }


        private void RBtnDelete_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("Are you sure you want to delete this supplier?","Delete Supplier",MessageBoxButtons.YesNo,RadMessageIcon.Exclamation)==DialogResult.Yes)
            {
                RGVSupplier.SelectedRows[0].Delete(); // -- delete from gridview
                //Dito lagay delete item sa db
            }
        }

        private void RBtnRefresh_Click(object sender, EventArgs e)
        {
            RGVSupplier.Rows.Clear();
            PopulateGridView();
        }

    }
}
