using JentrousMarketing.BusinessProcess;
using JentrousMarketing.DBObjects;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JentrousMarketing.Forms
{
    public partial class LoginForm : CustomForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RBtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(RTBUserName.Text);

            if (user.Password != null && user.Password.Trim() == RTBPassword.Text.Trim())
            {
                SecurityAccess.Role = user.Role;
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadMain));
                t.SetApartmentState(System.Threading.ApartmentState.STA);
                t.Start();
                this.Close();                
            }
            else
            {
                RadMessageBox.Show("Username and Password does not match!", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                RTBUserName.Clear();
                RTBPassword.Clear();
                this.ActiveControl = RTBUserName;
            }
        }

        public void ThreadMain()
        {
            Application.Run(new MainPage());
        }

        private void RBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
