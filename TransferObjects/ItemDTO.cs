using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JentrousMarketing.DBObjects;
using System.Collections;
using Npgsql;
using JentrousMarketing.UtilityDB;

namespace JentrousMarketing.TransferObjects
{
    public class ItemDTO
    {
        private Item item;
        private string description;
        private ArrayList items;

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


        public ArrayList getItems()
        {
            items = new ArrayList();
            Connection conn = new Connection();

            try
            {
                conn.openConnection();
                string sql = "SELECT description, brand, model, tag, uom, cost, stock_qty, curr_loc, supplier_id, version FROM items;";
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, null);

                while (dr.Read())
                {
                    Item item = new Item();
                    item.Description = (string)dr[0];
                    item.Brand = (string)dr[1];
                    item.Model = (string)dr[2];
                    item.Tag = (string)dr[3];
                    item.Uom = (string)dr[4];
                    item.Cost = (decimal)dr[5];
                    item.Stock_qty = (Int64)dr[6];
                    item.Curr_loc = (string)dr[7];
                    item.Supplier_id = (int)dr[8];
                    item.Version = (int)dr[9];

                    items.Add(item);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn.closeConnection();
            }
            return items;
        }

        public Item getItem(string description, string brand, string model)
        {

            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                String sql = "SELECT description, brand, model, tag, uom, cost, stock_qty, curr_loc, supplier_id, version FROM items" +
                    " WHERE description = @description " +
                        " AND brand = @brand " +
                        " AND model = @model ;";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("description", description));
                parmArray.Add(new NpgsqlParameter("brand", brand));
                parmArray.Add(new NpgsqlParameter("model", model));
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, parmArray);

                while (dr.Read())
                {
                    item = new Item();
                    item.Description = (string)dr[0];
                    item.Brand = (string)dr[1];
                    item.Model = (string)dr[2];
                    item.Tag = (string)dr[3];
                    item.Uom = (string)dr[4];
                    item.Cost = (decimal)dr[5];
                    item.Stock_qty = (Int64)dr[6]; 
                    item.Curr_loc = (string)dr[7];
                    item.Supplier_id = (int)dr[8];
                    item.Version = (int)dr[9];
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn.closeConnection();
            }

            return item;
        }

        public Int32 updateItem(Item item)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();
                if (conn.getVersionOfItems(item.Description, item.Brand, item.Model) == item.Version)
                {
                    string sql = "UPDATE items SET tag = @tag, " +
                                " uom = @uom, cost = @cost, stock_qty = @stock_qty , curr_loc = @curr_loc, " +
                                " supplier_id = @supplier_id, version = @version " +
                                "WHERE description = @description AND brand = @brand AND model = @model ";
                    ArrayList parmArray = new ArrayList();
                    parmArray.Add(new NpgsqlParameter("tag", item.Tag));
                    parmArray.Add(new NpgsqlParameter("uom", item.Uom));
                    parmArray.Add(new NpgsqlParameter("cost", item.Cost));
                    parmArray.Add(new NpgsqlParameter("stock_qty", item.Stock_qty));
                    parmArray.Add(new NpgsqlParameter("curr_loc", item.Curr_loc));
                    parmArray.Add(new NpgsqlParameter("supplier_id", item.Supplier_id));
                    parmArray.Add(new NpgsqlParameter("version", ++item.Version));
                    parmArray.Add(new NpgsqlParameter("description", item.Description));
                    parmArray.Add(new NpgsqlParameter("brand", item.Brand));
                    parmArray.Add(new NpgsqlParameter("model", item.Model));
                    rowsAffected = conn.executeUpdateSQL(sql, parmArray);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                conn.closeConnection();
            }
            return rowsAffected;
        }



        public Int32 createItem(Item item)
        {
            int rowsAffected = 0;
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                String sql = " INSERT INTO items (description, brand, model, tag, uom, cost, stock_qty, curr_loc, supplier_id)  " +
                    "VALUES (@description, @brand, @model, @tag, @uom, @cost, @stock_qty, @curr_loc, @supplier_id);";

                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("description", item.Description));
                parmArray.Add(new NpgsqlParameter("brand", item.Brand));
                parmArray.Add(new NpgsqlParameter("model", item.Model));
                parmArray.Add(new NpgsqlParameter("tag", item.Tag));
                parmArray.Add(new NpgsqlParameter("uom", item.Uom));
                parmArray.Add(new NpgsqlParameter("cost", item.Cost));
                parmArray.Add(new NpgsqlParameter("stock_qty", item.Stock_qty));
                parmArray.Add(new NpgsqlParameter("curr_loc", item.Curr_loc));
                parmArray.Add(new NpgsqlParameter("supplier_id", item.Supplier_id));

                rowsAffected = conn.executeUpdateSQL(sql, parmArray);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                conn.closeConnection();
            }
            return rowsAffected;
        }

    }
}
