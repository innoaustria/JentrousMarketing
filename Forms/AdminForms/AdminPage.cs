using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JentrousMarketing.Forms.ItemStatusForms;

namespace JentrousMarketing.Forms.AdminForms
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void RBtnItemStatus_Click(object sender, EventArgs e)
        {
            var itemStatusMain = new ItemStatusMainForm();
            itemStatusMain.ShowDialog();
        }
    }
}
