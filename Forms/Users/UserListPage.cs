using System.Windows.Forms;
using JentrousMarketing.DBObjects;
using JentrousMarketing.TransferObjects;

namespace JentrousMarketing.Forms.Users
{
    public partial class UserListPage : UserControl
    {
        public UserListPage()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            var userDto = new UserDTO();
            var users = userDto.getUsers();
            foreach (User user in users)
            {
                //ListViewItem lvItem = new ListViewItem(new string[] { user.UserName, user.Password, user.Name, user.Role });
                //RGVUserList.Rows.Add(lvItem);
                var rowItem = RGVUserList.Rows.AddNew();
                rowItem.Cells["Username"].Value = user.UserName;
                rowItem.Cells["Password"].Value = user.Password;
                rowItem.Cells["Name"].Value = user.Name;
                rowItem.Cells["Role"].Value = user.Role;
            }
        }
        private void RGVUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                var item = RGVUserList.SelectedRows[0];
                if (item != null)
                {
                    var user = new User(item.Cells["Username"].Value.ToString());

                    var uForm = new UserForm(user, "update");
                    uForm.ShowDialog();
                    //Form3 form = new Form3(user, "update");
                    //form.ShowDialog();
                }
            }
        }

        private void RBtnAdd_Click(object sender, System.EventArgs e)
        {
            var uForm = new UserForm(null, "add");
            uForm.ShowDialog();
        }

        private void RbtnRefresh_Click(object sender, System.EventArgs e)
        {
            RGVUserList.Rows.Clear();
            PopulateGridView();
        }
    }
}
