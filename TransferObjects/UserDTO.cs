using JentrousMarketing.DBObjects;
using JentrousMarketing.UtilityDB;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JentrousMarketing.TransferObjects
{
    class UserDTO
    {
        private User user;
        private ArrayList users;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public ArrayList getUsers()
        {
            users = new ArrayList();
            Connection conn = new Connection();

            try
            {
                conn.openConnection();
                string sql = "SELECT USERNAME, PASSWORD, NAME, ROLE, VERSION FROM USERS;";
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, null);
                
                while (dr.Read())
                {
                    user = new User();
                    user.UserName = (string)dr[0];
                    user.Password = (string)dr[1];
                    user.Name = (string)dr[2];
                    user.Role = (string)dr[3];
                    user.Version = (int)dr[4];
                    users.Add(user);
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
            return users;
        }
        
        public User getUser(string username)
        {
            Connection conn = new Connection();
            try
            {
                conn.openConnection();
                string sql = "SELECT USERNAME, PASSWORD, NAME, ROLE, VERSION FROM USERS " + 
                            "WHERE username = @userName";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("userName", username));
                NpgsqlDataReader dr = conn.executeReaderSQL(sql, parmArray);
                
                while (dr.Read())
                {
                    user = new User();
                    user.UserName = (string)dr[0];
                    user.Password = (string)dr[1];
                    user.Name = (string)dr[2];
                    user.Role = (string)dr[3];
                    user.Version = (int)dr[4];
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
            return user;
        }

        public Int32 updateUser(User user)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();
                if (conn.getVersion("USERS", "USERNAME", user.UserName) == user.Version)
                {
                    string sql = "UPDATE USERS SET PASSWORD = @password, NAME = @name, ROLE = @role , VERSION = @version " +
                                "WHERE USERNAME = @username";
                    ArrayList parmArray = new ArrayList();
                    parmArray.Add(new NpgsqlParameter("password", user.Password));
                    parmArray.Add(new NpgsqlParameter("name", user.Name));
                    parmArray.Add(new NpgsqlParameter("role", user.Role));
                    parmArray.Add(new NpgsqlParameter("username", user.UserName));
                    parmArray.Add(new NpgsqlParameter("version", ++user.Version));
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

        public Int32 createUser(User user)
        {
            Connection conn = new Connection();
            int rowsAffected = 0;
            try
            {
                conn.openConnection();
                string sql = "INSERT INTO USERS (USERNAME, PASSWORD, NAME, ROLE) " +
                            "VALUES (@username, @password, @name, @role);";
                ArrayList parmArray = new ArrayList();
                parmArray.Add(new NpgsqlParameter("username", user.UserName));
                parmArray.Add(new NpgsqlParameter("password", user.Password));
                parmArray.Add(new NpgsqlParameter("name", user.Name));
                parmArray.Add(new NpgsqlParameter("role", user.Role));
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
    }
}
