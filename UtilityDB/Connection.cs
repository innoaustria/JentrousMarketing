using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Collections;

namespace JentrousMarketing.UtilityDB
{
    class Connection
    {
        private NpgsqlConnection conn;

        public Connection()
        {
            try
            {
                ConfigReader.readFile();
                string connstring = "Server=" + ConfigReader.Host + "; "
                                    + "Port=" + ConfigReader.Port + "; "
                                    + "User Id=" + ConfigReader.User + "; "
                                    + "Password=" + ConfigReader.Password + "; "
                                    + "Database=" + ConfigReader.Database + ";";
                conn = new NpgsqlConnection(connstring);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }

        public NpgsqlDataReader executeReaderSQL(string SQL, ArrayList parmArray)
        {
            NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
            if (parmArray != null)
            {
                foreach (Object parm in parmArray)
                {
                    command.Parameters.Add(parm);
                }
            }

            return command.ExecuteReader();
        }

        public Int32 executeUpdateSQL(string SQL, ArrayList parmArray)
        {
            NpgsqlCommand command = new NpgsqlCommand(SQL, conn);

            if (parmArray != null)
            {
                foreach (NpgsqlParameter parm in parmArray)
                {
                    command.Parameters.Add(parm);
                }
            }

            return command.ExecuteNonQuery();
        }

        public Int32 getVersion(string tableName, string columnName, string id)
        {
            string SQL = "SELECT VERSION FROM " + tableName + " WHERE " + columnName + " = @id;";
            NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
            command.Parameters.Add(new NpgsqlParameter("id", id));

            return (Int32)command.ExecuteScalar();
        }

        public Int32 getVersionOfItems(string description, string brand, string model)
        {
            string SQL = "SELECT VERSION FROM items WHERE description = @description AND brand = @brand AND model = @model;";
            NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
            command.Parameters.Add(new NpgsqlParameter("description", description));
            command.Parameters.Add(new NpgsqlParameter("brand", brand));
            command.Parameters.Add(new NpgsqlParameter("model", model));

            return (Int32)command.ExecuteScalar();
        }

        public void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }

        public void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }
    }
}
