using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JentrousMarketing.TransferObjects;

namespace JentrousMarketing.DBObjects
{
    public class Supplier
    {
        private int supplierId;
        private string supplierName;
        private string address;
        private string contactNo;
        private int version;

        public Supplier()
        {
            
        }

        public Supplier(int supplierId)
        {
            SupplierDTO supplierDTO = new SupplierDTO();
            Supplier supplier = supplierDTO.getSupplier(supplierId);

            this.supplierId = supplier.SupplierId;
            this.supplierName = supplier.SupplierName;
            this.address = supplier.Address;
            this.contactNo = supplier.ContactNo;
            this.version = supplier.Version;
        }

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
