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
    public partial class frmStockCard : Form
    {
        private string user_type;
        public frmStockCard()
        {
            InitializeComponent();
        }

        private void frmStockCard_Load(object sender, EventArgs e)
        {
            if (user_type == "admin")
            {
                
            }
            else if(user_type == "user")
            {
                
            }
        }

        public void setUserType (string text)
        {
            this.user_type = text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (user_type == "admin")
            {
                this.Hide();
                frmAdminMain frmAdminMain = new frmAdminMain();
                frmAdminMain.set_userType("admin");
                frmAdminMain.Show();
            }
            else if (user_type == "user")
            {
                this.Hide();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.set_userType("user");
                frmMainMenu.Show();
            }
        }
    }
}
