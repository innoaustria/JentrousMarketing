using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JentrousMarketing.TransferObjects;

namespace JentrousMarketing.DBObjects
{
    public class Item
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        private string uom;

        public string Uom
        {
            get { return uom; }
            set { uom = value; }
        }
        private decimal cost;

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private Int64 stock_qty;

        public Int64 Stock_qty
        {
            get { return stock_qty; }
            set { stock_qty = value; }
        }
        private string curr_loc;

        public string Curr_loc
        {
            get { return curr_loc; }
            set { curr_loc = value; }
        }
   
        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
        private int supplier_id;

        public int Supplier_id
        {
            get { return supplier_id; }
            set { supplier_id = value; }
        }
        
        public Item()
        {

        }

        public Item(string description, string brand, string model)
        {
            ItemDTO itemDTO = new ItemDTO();
            itemDTO.getItem(description, brand, model);

            this.description = itemDTO.Description;
            this.brand = itemDTO.Brand;
            this.model = itemDTO.Model;
            this.tag = itemDTO.Tag;
            this.uom = itemDTO.Uom;
            this.cost = itemDTO.Cost;
            this.stock_qty = itemDTO.Stock_qty;
            this.curr_loc = itemDTO.Curr_loc;
            this.supplier_id = itemDTO.Supplier_id;
            this.version = itemDTO.Version; 
            // 
        }

        public Supplier getSupplier(){
            return new Supplier(supplier_id);
        }

    }
}
