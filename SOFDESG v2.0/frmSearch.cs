using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFDESG_v2._0
{
    public partial class frmSearch : Form
    {
        private string userType;
        private string user;
        public frmSearch()
        {
            InitializeComponent();
        }

        internal void set_userType(string v)
        {
            this.userType = v;
        }

        public void set_user(string s)
        {
            this.user = s;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (userType == "admin") {
                frmAdminMain frmAdminMain = new frmAdminMain();
                frmAdminMain.set_user(user);
                this.Hide();
                frmAdminMain.Show();
            }
            else
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.set_user(user);
                this.Hide();
                frmMainMenu.Show();
            }
        }


    }
}
