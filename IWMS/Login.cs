using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IWMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "")
            {
                lblUserEmpty.Hide();
                lblPassEmpty.Hide();

                if (txtUserPass.Text == "0202")
                {
                    MessageBox.Show("Welcome " + txtUserName.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }

            if (txtUserName.Text == "" || txtUserPass.Text == "")
            {
                if (txtUserName.Text == "")
                {
                    lblUserEmpty.Show();
                }
                else
                {
                    lblUserEmpty.Hide();
                }

                if (txtUserPass.Text == "")
                {
                    lblPassEmpty.Show();
                }
                else
                {
                    lblPassEmpty.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUserEmpty.Hide();
            lblPassEmpty.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}
