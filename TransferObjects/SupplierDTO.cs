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
    class SupplierDTO
    {
        private Supplier supplier;
        private ArrayList suppliers;

        public SupplierDTO()
        {

        }

        public ArrayList getSuppliers()
        {
            suppliers = new ArrayList();
            Connection conn = new Connection();

            try
            {
                conn.openConnection();
                string sql = "SELECT SUPPLIER_ID, SUPPLIER, ADDRESS, CONTACT_NO, VERSION FROM SUPPLIERS;";
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, null);

                while (dr.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = (int)dr[0];
                    supplier.SupplierName = (string)dr[1];
                    supplier.Address = (string)dr[2];
                    supplier.ContactNo = (string)dr[3];
                    supplier.Version = (int)dr[4];
                    suppliers.Add(supplier);
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
            return suppliers;
        }

        public Supplier getSupplier(int SupplierId)
        {
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                String sql = "SELECT SUPPLIER_ID, SUPPLIER, ADDRESS, CONTACT_NO, VERSION FROM SUPPLIERS" +
                    " WHERE SUPPLIER_ID = @supplierId;";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("supplierId", SupplierId));
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, parmArray);

                while (dr.Read())
                {
                    supplier = new Supplier();
                    supplier.SupplierId = (int)dr[0];
                    supplier.SupplierName = (string)dr[1];
                    supplier.Address = (string)dr[2];
                    supplier.ContactNo = (string)dr[3];
                    supplier.Version = (int)dr[4];
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

            return supplier;
        }

        public Int32 updateSupplier(Supplier supplier)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();
                if (conn.getVersion("suppliers", "supplier_id", supplier.SupplierId.ToString()) == supplier.Version)
                {
                    String sql = " UPDATE SUPPLIERS SET SUPPLIER = @supplier, " +
                        "ADDRESS = @address, " +
                        "CONTACT_NO = @contact_no, " +
                        "VERSION = @version " +
                        "WHERE SUPPLIER_ID = @supplier_id;";
                    ArrayList parmArray = new ArrayList();
                    parmArray.Add(new NpgsqlParameter("supplier", supplier.SupplierName));
                    parmArray.Add(new NpgsqlParameter("address", supplier.Address));
                    parmArray.Add(new NpgsqlParameter("contact_no", supplier.ContactNo));
                    parmArray.Add(new NpgsqlParameter("version", ++supplier.Version));
                    parmArray.Add(new NpgsqlParameter("supplier_id", supplier.SupplierId));
                    rowsAffected = conn.executeUpdateSQL(sql, parmArray);
                }
                else
                {
                    return -1;
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

            return rowsAffected;
        }


        public Int32 createSupplier(Supplier supplier)
        {
            int rowsAffected = 0;
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                String sql = " INSERT INTO SUPPLIERS (SUPPLIER, ADDRESS, CONTACT_NO)  " +
                    "VALUES (@supplier, @address, @contact_no);";

                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("supplier", supplier.SupplierName));
                parmArray.Add(new NpgsqlParameter("address", supplier.Address));
                parmArray.Add(new NpgsqlParameter("contact_no", supplier.ContactNo));
                rowsAffected = conn.executeUpdateSQL(sql, parmArray);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn.closeConnection();
            }
            return rowsAffected;
        }

        public Int32 remove(Supplier supplier)
        {
            int rowsAffected = 0;
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                if (conn.getVersion("suppliers", "supplier_id", supplier.SupplierId.ToString()) == supplier.Version)
                {
                    String SQL = " DELETE FROM suppliers " +
                        " WHERE supplier_id = @supplierId";
                    ArrayList parmArray = new ArrayList();
                    //parmArray.Add(new NpgsqlParameter("supplierId", supplierId));
                    NpgsqlDataReader dr = conn.executeReaderSQL(SQL, parmArray);
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
    }
}