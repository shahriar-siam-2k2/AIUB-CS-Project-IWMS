using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
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

                if (ValidateUser(txtUserName.Text, txtUserPass.Text) > 0)
                {
                    MessageBox.Show("Welcome " + txtUserName.Text, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private int ValidateUser(string userName, string userPass)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            try
            {
                string query = "SELECT COUNT(1) FROM User_Registration WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", userPass);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: \n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return -1;
            }
        }
    }
}
