using System;
using JentrousMarketing.BusinessProcess;
using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace JentrousMarketing.Forms.Users
{
    public partial class UserForm : CustomForm
    {
        private string action;
        private User user;

        public UserForm(User user, string action)
        {
            InitializeComponent();

            this.action = action;
            this.user = user;

            foreach (string item in Enum.GetNames(typeof(RolesEnum)))
            {
                RDDRole.Items.Add(item);
            }

            if (action == "add")
            {
                Text = "Add User";
                RBtnAdd.Text = "Add";
                RTBUser.Enabled = true;
                RDDRole.SelectedIndex = 0;
            }

            if (action == "update")
            {
                RTBUser.Text = user.UserName;
                RTBPass.Text = user.Password;
                RTBName.Text = user.Name;
                RDDRole.SelectedValue = user.Role;

                if (SecurityAccess.IsEmployee)
                {
                    RDDRole.Enabled = false;
                }
            }
        }

        private void RBtnAdd_Click(object sender, EventArgs e)
        {
            if (action == "update")
            {
                if (RTBPass.Text == RTBRetype.Text)
                {

                    UserDTO userDTO = new UserDTO();
                    User user = new User();
                    user.UserName = RTBUser.Text;
                    user.Password = RTBPass.Text;
                    user.Name = RTBName.Text;
                    user.Role = RDDRole.SelectedItem.Text;
                    user.Version = this.user.Version;

                    int stat = userDTO.updateUser(user);
                    if (stat > 0)
                    {
                        RadMessageBox.Show("User Updated!");
                        this.Close();
                    }

                    if (stat == -1)
                    {
                        RadMessageBox.Show("User Already Updated! Please close window and try again.");
                    }
                }
                else
                {
                    RadMessageBox.Show("Password doesn't match. Please Try Again.", "Warning");
                }
            }

            if (action == "add")
            {
                if (RTBPass.Text == RTBRetype.Text)
                {
                    UserDTO userDTO = new UserDTO();
                    User user = new User();
                    user.UserName = RTBUser.Text;
                    user.Password = RTBPass.Text;
                    user.Name = RTBName.Text;
                    user.Role = RDDRole.SelectedItem.Text;

                    if (userDTO.createUser(user) > 0)
                    {
                        RadMessageBox.Show("User Created!");
                        Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error saving to DB!");
                    }
                }
                else
                {
                    RadMessageBox.Show("Password doesn't match. Please Try Again.", "Warning");
                }
            }
        }

        private void RCBShowPassword_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            switch (RCBShowPassword.ToggleState)
            {
                case ToggleState.On:
                    RTBPass.PasswordChar = '\0';
                    RTBRetype.PasswordChar = '\0';
                    break;
                default:
                    RTBPass.PasswordChar = '\u25CF';
                    RTBRetype.PasswordChar = '\u25CF';
                    break;
            }
            RTBPass.Refresh();
            RTBRetype.Refresh();
        }
    }
}
