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
    public partial class frmAcNewUser : Form
    {
        string user;
        string userType;

        public frmAcNewUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminControls frmAdminControls = new frmAdminControls();
            frmAdminControls.set_user(user);
            frmAdminControls.set_userType(userType);
            this.Hide();
            frmAdminControls.Show();
        }

        public void set_user(string s)
        {
            this.user = s;
        }

        public void set_userType(string s)
        {
            this.userType = s;
        }
    }
}
