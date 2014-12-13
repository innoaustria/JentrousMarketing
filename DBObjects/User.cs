using JentrousMarketing.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JentrousMarketing.DBObjects
{
    public class User
    {
        private string userName;
        private string password;
        private string name;
        private string role;
        private int version;
        
        public User()
        {

        }

        public User(string userName)
        {
            UserDTO userDTO = new UserDTO();
            User user = userDTO.getUser(userName);

            if (user != null)
            {
                this.userName = user.UserName;
                this.password = user.Password;
                this.name = user.Name;
                this.role = user.Role;
                this.version = user.Version;
            }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
