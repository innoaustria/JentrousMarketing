using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;
using Telerik.WinControls;

namespace JentrousMarketing.Forms.Suppliers
{
    public partial class SupplierForm : Telerik.WinControls.UI.RadForm
    {
        private string action;
        private Supplier supplier;

        public SupplierForm(Supplier supplier, string action)
        {
            InitializeComponent();

            this.action = action;
            this.supplier = supplier;

            if (action == "add")
            {
                Text = "Add Supplier";
                RBtnAdd.Text = "Add";
                RTBSupplier.Enabled = true;
            }

            if (action == "update")
            {
                RTBSupplier.Text = supplier.SupplierName;
                RTBAddress.Text = supplier.Address;
                RTBContact.Text = supplier.ContactNo;
            }
        }

        private void RBtnAdd_Click(object sender, System.EventArgs e)
        {
            if (action == "update")
            {
                SupplierDTO supplierDto = new SupplierDTO();
                Supplier supplier = new Supplier();

                supplier.SupplierId = this.supplier.SupplierId;
                supplier.SupplierName = RTBSupplier.Text;
                supplier.Address = RTBAddress.Text;
                supplier.ContactNo = RTBContact.Text;
                supplier.Version = this.supplier.Version;

                int stat = supplierDto.updateSupplier(supplier);
                if (stat > 0)
                {
                    RadMessageBox.Show("Supplier Updated!");
                    this.Close();
                }

                if (stat == -1)
                {
                    RadMessageBox.Show("Supplier Already Updated! Please close window and try again.");
                }
            }

            if (action == "add")
            {
                SupplierDTO supplierDto = new SupplierDTO();
                Supplier supplier = new Supplier();

                //SUPPLIER ID!!
                supplier.SupplierId = supplierDto.getSuppliers().Count+1;
                //SUPPLIER ID!!

                supplier.SupplierName = RTBSupplier.Text;
                supplier.Address = RTBAddress.Text;
                supplier.ContactNo = RTBContact.Text;

                if (supplierDto.createSupplier(supplier) > 0)
                {
                    RadMessageBox.Show("Supplier Created!");
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
