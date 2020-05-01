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
    public partial class frmAdminControls : Form
    {
        string user;
        string userType;

        public frmAdminControls()
        {
            InitializeComponent();
        }

        private void frmAdminControls_Load(object sender, EventArgs e)
        {

        }
        public void set_user(string s)
        {
            this.user = s;
        }

        public void set_userType(string s)
        {
            this.userType = s;
        }

       

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmAcNewUser frmAcNewUser = new frmAcNewUser();
            frmAcNewUser.set_user(user);
            this.Hide();
            frmAcNewUser.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmAcSearch frmAcSearch = new frmAcSearch();
            frmAcSearch.set_user(user);
            this.Hide();
            frmAcSearch.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmAcSearch frmAcSearch = new frmAcSearch();
            frmAcSearch.set_user(user);
            this.Hide();
            frmAcSearch.Show();
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            frmAcChangeLog frmAcChangeLog = new frmAcChangeLog();
            frmAcChangeLog.set_user(user);
            this.Hide();
            frmAcChangeLog.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmAdminMain frmAdminMain = new frmAdminMain();
            frmAdminMain.set_user(user);
            this.Hide();
            frmAdminMain.Show();
        }
    }
}
