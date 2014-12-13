using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JentrousMarketing.DBObjects;
using JentrousMarketing.UtilityDB;
using Npgsql;

namespace JentrousMarketing.TransferObjects
{
    class ItemStatusDTO
    {
        private ItemStatus itemStatus;
        private ArrayList itemStatusList;

        public ItemStatus ItemStatus
        {
            get { return itemStatus; }
            set { itemStatus = value; }
        }

        public ArrayList getItemStatusList()
        {
            itemStatusList = new ArrayList();
            Connection conn = new Connection();

            try
            {
                conn.openConnection();
                string sql = "SELECT ITEM_STATUS_ID, ITEM_STATUS, VERSION FROM ITEM_STATUS;";
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, null);

                while (dr.Read())
                {
                    itemStatus = new ItemStatus();
                    itemStatus.ItemStatusId = (Int32)dr[0];
                    itemStatus.ItemStatusDesc = (string)dr[1];
                    itemStatus.Version = (int)dr[2];
                    itemStatusList.Add(itemStatus);
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
            return itemStatusList;
        }

        public ItemStatus getItemStatus(string itemStatusId)
        {
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                string sql = "SELECT ITEM_STATUS_ID, ITEM_STATUS, VERSION FROM ITEM_STATUS " +
                            "WHERE ITEM_STATUS_ID = @itemStatusId;";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("itemStatusId", itemStatusId));
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, parmArray);

                while (dr.Read())
                {
                    itemStatus = new ItemStatus();
                    itemStatus.ItemStatusId = (Int32)dr[0];
                    itemStatus.ItemStatusDesc = (string)dr[1];
                    itemStatus.Version = (int)dr[2];
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
            return itemStatus;
        }

        public Int32 updateItemStatus(ItemStatus itemStatus)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();

                if (conn.getVersion("ITEM_STATUS", "ITEM_STATUS_ID", itemStatus.ItemStatusId.ToString()) == itemStatus.Version)
                {

                    string sql = "UPDATE ITEM_STATUS SET ITEM_STATUS = @itemStatusDesc , VERSION = @version " +
                                "WHERE ITEM_STATUS_ID = @itemStatusId;";
                    ArrayList parmArray = new ArrayList();
                    parmArray.Add(new NpgsqlParameter("itemStatusDesc", itemStatus.ItemStatusDesc));
                    parmArray.Add(new NpgsqlParameter("version", ++itemStatus.Version));
                    parmArray.Add(new NpgsqlParameter("itemStatusId", itemStatus.ItemStatusId));
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

        public Int32 createItemStatus(ItemStatus itemStatus)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();
                string sql = "INSERT INTO ITEM_STATUS (ITEM_STATUS_ID, ITEM_STATUS) " +
                            "VALUES (@itemStatusId, @itemStatusDesc);";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("itemStatusId", itemStatus.ItemStatusId));
                parmArray.Add(new NpgsqlParameter("itemStatusDesc", itemStatus.ItemStatusDesc));
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
