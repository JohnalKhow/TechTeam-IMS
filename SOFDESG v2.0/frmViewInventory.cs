﻿using System;
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
    public partial class frmViewInventory : Form
    {
        string user;
        string userType;

        public frmViewInventory()
        {
            InitializeComponent();
        }

        private void frmViewInventory_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (userType == "admin")
            {
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
