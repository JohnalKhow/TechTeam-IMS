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
    public partial class frmAdminMain : Form
    {
        string user;
        string userType;
        public frmAdminMain()
        {
            InitializeComponent();
        }


        private void btnStockCard_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.set_userType("admin");
            frmSearch.set_user(user);
            this.Hide();
            frmSearch.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Close();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = user+"!";
        }

        public void set_user(string s)
        {
            this.user = s;
        }

        public void set_userType(string s)
        {
            this.userType = s;
        }

        private void btnCustomerLedger_Click(object sender, EventArgs e)
        {
            frmCustomerLedger frmCustomerLedger = new frmCustomerLedger();
            frmCustomerLedger.set_userType("admin");
            frmCustomerLedger.set_user(user);
            this.Hide();
            frmCustomerLedger.Show();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            frmViewInventory frmViewInventory = new frmViewInventory();
            frmViewInventory.set_userType("admin");
            frmViewInventory.set_user(user);
            this.Hide();
            frmViewInventory.Show();
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            frmChangeStock frmChangeStock = new frmChangeStock();
            frmChangeStock.set_userType("admin");
            frmChangeStock.set_user(user);
            this.Hide();
            frmChangeStock.Show();
        }

        private void btnAdminControl_Click(object sender, EventArgs e)
        {
            frmAdminControls frmAdminControls = new frmAdminControls();
            frmAdminControls.set_userType("admin");
            frmAdminControls.set_user(user);
            this.Hide();
            frmAdminControls.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }
    }
}
