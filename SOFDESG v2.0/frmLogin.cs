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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "user" && txtPassword.Text == "user")
            {
                this.Hide();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.set_user(txtUser.Text);
                frmMainMenu.set_userType("user");
                frmMainMenu.Show();
            }
            else if(txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                frmAdminMain frmAdminMain = new frmAdminMain();
                frmAdminMain.set_user(txtUser.Text);
                frmAdminMain.set_userType("admin");
                frmAdminMain.Show();
            }
            else
            {
                txtAlert.Text = "Invalid User or Password";
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtAlert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
