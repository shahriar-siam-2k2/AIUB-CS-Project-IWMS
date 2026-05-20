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

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();

                    string query = "SELECT U_FullName, U_Role FROM Users WHERE U_Name = '" + txtUserName.Text + "' AND U_Pass = '" + txtUserPass.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["U_FullName"].ToString();
                                string role = reader["U_Role"].ToString();

                                if (role == "Admin")
                                {
                                    Admin_Dashboard ad = new Admin_Dashboard(txtUserName.Text, fullName);
                                    ad.Show();
                                    this.Hide();
                                }
                                else if (role == "Staff")
                                {
                                    // You will do the exact same thing for your Staff_Dashboard constructor later
                                    // Staff_Dashboard sd = new Staff_Dashboard(txtLoginUsername.Text, dbFullName);
                                    // sd.Show();
                                    // this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: \n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
            txtUserPass.UseSystemPasswordChar = true;
            lblShowHidePass.Text = "Show";
            lblUserEmpty.Hide();
            lblPassEmpty.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }

        private void lblShowHidePass_Click(object sender, EventArgs e)
        {
            if (txtUserPass.UseSystemPasswordChar == true)
            {
                txtUserPass.UseSystemPasswordChar = false;
                lblShowHidePass.Text = "Hide";
            }
            else
            {
                txtUserPass.UseSystemPasswordChar = true;
                lblShowHidePass.Text = "Show";
            }
        }

        private void lblShowHidePass_MouseEnter(object sender, EventArgs e)
        {
            lblShowHidePass.Font = new Font(lblShowHidePass.Font, FontStyle.Underline);
        }

        private void lblShowHidePass_MouseLeave(object sender, EventArgs e)
        {
            lblShowHidePass.Font = new Font(lblShowHidePass.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
