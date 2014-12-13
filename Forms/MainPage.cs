using System;
using System.Windows.Forms;
using JentrousMarketing.Forms.AdminForms;
using JentrousMarketing.Forms.Items;
using JentrousMarketing.Forms.Suppliers;
using JentrousMarketing.Forms.Users;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using JentrousMarketing.BusinessProcess;

namespace JentrousMarketing.Forms
{
    public partial class MainPage : CustomForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SetMainMenuUserToggle(object sender)
        {
            var controlSender = sender as RadToggleButton;
            if (controlSender != null && !controlSender.IsChecked)
            {
//                controlSender.IsChecked = true;
//                if (controlSender != ItemMainButton) ItemMainButton.IsChecked = false;
//                if (controlSender != UserMainButton) UserMainButton.IsChecked = false;
//                if (controlSender != SupplierMainButton) SupplierMainButton.IsChecked = false;
//                if (controlSender != SalesMainButton) SalesMainButton.IsChecked = false;
//                if (controlSender != TransHistoryMainButton) TransHistoryMainButton.IsChecked = false;
//                if (controlSender != AdminMainButton) AdminMainButton.IsChecked = false;
//                if (controlSender != LogOutMainButton) LogOutMainButton.IsChecked = false;

                if (controlSender != ItemMainButton) ItemMainButton.ToggleState = ToggleState.Off;
                if (controlSender != UserMainButton) UserMainButton.ToggleState = ToggleState.Off;
                if (controlSender != SupplierMainButton) SupplierMainButton.ToggleState = ToggleState.Off;
                if (controlSender != SalesMainButton) SalesMainButton.ToggleState = ToggleState.Off;
                if (controlSender != TransHistoryMainButton) TransHistoryMainButton.ToggleState = ToggleState.Off;
                if (controlSender != AdminMainButton) AdminMainButton.ToggleState = ToggleState.Off;
                if (controlSender != LogOutMainButton) LogOutMainButton.ToggleState = ToggleState.Off;

                //Remove Existing Panel
                if (RPMainWindow.Controls.Count > 0) RPMainWindow.Controls.RemoveAt(0);
            }
        }

        private void ItemMainButton_Click(object sender, EventArgs e)
        {
            var itemPage = new ItemsPage { Dock = DockStyle.Fill };
            SetMainMenuUserToggle(sender);
            RPMainWindow.Controls.Add(itemPage);
        }

        private void UserMainButton_Click(object sender, EventArgs e)
        {
            var userListPage = new UserListPage {Dock = DockStyle.Fill};
            SetMainMenuUserToggle(sender);
            RPMainWindow.Controls.Add(userListPage);
        }

        private void SupplierMainButton_Click(object sender, EventArgs e)
        {
            var supplierPage = new SupplierPage {Dock = DockStyle.Fill};
            SetMainMenuUserToggle(sender);
            RPMainWindow.Controls.Add(supplierPage);
        }

        private void SalesMainButton_Click(object sender, EventArgs e)
        {
            SetMainMenuUserToggle(sender);
        }

        private void TransHistoryMainButton_Click(object sender, EventArgs e)
        {
            SetMainMenuUserToggle(sender);
        }

        private void AdminMainButton_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage { Dock = DockStyle.Fill };
            SetMainMenuUserToggle(sender);
            RPMainWindow.Controls.Add(adminPage);
        }

        private void LogOutMainButton_Click(object sender, EventArgs e)
        {
            SetMainMenuUserToggle(sender);
            SecurityAccess.Role = null;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadMain));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
        }

        public void ThreadMain()
        {
            Application.Run(new LoginForm());
        }
    }
}
