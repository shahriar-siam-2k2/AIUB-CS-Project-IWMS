using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class Account_Settings : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string userName, fullName, role;

        public Account_Settings(string userName, string fullName, string role)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
            InitializeComponent();

            this.Load += Account_Settings_Load;
        }

        private void Account_Settings_Load(object sender, EventArgs e)
        {
            comboRole.Enabled = false;
            lblPassEmpty.Text = "";
            lblConfPassEmpty.Text = "";
            lblConfPassError.Text = "";

            LoadUserData();
        }

        private void LoadUserData()
        {

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("STOP: The username is blank! This means your Dashboard did NOT pass the variable correctly when opening this form.", "Root Cause Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string query = "SELECT * FROM Users WHERE U_FullName = '" + userName + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUserID.Text = reader["U_ID"].ToString();
                    txtFullName.Text = reader["U_FullName"].ToString();
                    txtUserName.Text = reader["U_Name"].ToString();
                    txtPass.Text = reader["U_Pass"].ToString();
                    txtConfirmPass.Text = reader["U_Pass"].ToString();
                    txtEmail.Text = reader["U_Email"].ToString();
                    txtPhone.Text = reader["U_Phone"].ToString();
                    rTxtAddress.Text = reader["U_Address"].ToString();
                    txtDOB.Text = reader["U_DOB"].ToString();
                    txtGender.Text = reader["U_Gender"].ToString();
                    comboRole.Text = reader["U_Role"].ToString();
                }
                else
                {
                    MessageBox.Show("STOP: The database searched for '" + userName + "' but found ZERO matches in the Users table.\n\nCheck your database to ensure this exact username exists, and check if you have accidental spaces in your SQL database.", "Root Cause Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pulling profile data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblPassEmpty.Text = "";
            lblConfPassEmpty.Text = "";
            lblConfPassError.Text = "";

            if (txtPass.Text == "")
            {
                lblPassEmpty.Text = "Required!";
                return;
            }
            if (txtConfirmPass.Text == "")
            {
                lblConfPassEmpty.Text = "Required!";
                return;
            }
            if (txtPass.Text != txtConfirmPass.Text)
            {
                lblConfPassError.Text = "Passwords do not match!";
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string query = "UPDATE Users SET U_FullName='" + txtFullName.Text + "', U_Pass='" + txtPass.Text + "', U_Email='" + txtEmail.Text + "', U_Phone='" + txtPhone.Text + "', U_Address='" + rTxtAddress.Text + "', U_DOB='" + txtDOB.Text + "', U_Gender='" + txtGender.Text + "' WHERE U_Name='" + userName + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                fullName = txtFullName.Text;

                MessageBox.Show("Account settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile settings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                Admin_Dashboard ad = new Admin_Dashboard(userName, fullName, role);
                ad.Show();
            }
            else
            {
                Staff_Dashboard sd = new Staff_Dashboard(userName, fullName, role);
                sd.Show();
            }
            this.Close();
        }

        private void lblShowHidePass1_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                lblShowHidePass1.Text = "Hide";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                lblShowHidePass1.Text = "Show";
            }
        }

        private void lblShowHidePass2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.UseSystemPasswordChar)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                lblShowHidePass2.Text = "Hide";
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
                lblShowHidePass2.Text = "Show";
            }
        }
    }
}