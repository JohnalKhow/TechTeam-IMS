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
    public partial class frmAcSearch : Form
    {
        private string userType;
        private string user;

        public frmAcSearch()
        {
            InitializeComponent();
        }

        private void frmAcSearch_Load(object sender, EventArgs e)
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

        internal void set_userType(string v)
        {
            this.userType = v;
        }

        public void set_user(string s)
        {
            this.user = s;
        }

    }
}
