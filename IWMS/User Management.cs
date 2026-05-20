using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class User_Management : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        string id = "";
        string userName, fullName;

        public User_Management(string userName, string fullName)
        {
            this.userName = userName;
            this.fullName = fullName;
            InitializeComponent();
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            //if (comboRole.Items.Count == 0)
            //{
            //    comboRole.Items.Add("Admin");
            //    comboRole.Items.Add("Staff");
            //}
            //if (comboGender.Items.Count == 0)
            //{
            //    comboGender.Items.Add("Male");
            //    comboGender.Items.Add("Female");
            //    comboGender.Items.Add("Others");
            //}

            lblUserName.Text = userName;

            ShowData();
        }

        private void ClearData()
        {
            txtUserID.Clear();
            txtFullName.Clear();
            txtUserName.Clear();
            txtPass.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rTxtAddress.Clear();

            if (dtpDOB.MaxDate < DateTime.Today)
            {
                dtpDOB.MaxDate = DateTime.Today;
            }

            dtpDOB.Value = DateTime.Today;

            txtSearch.Clear();
            comboGender.SelectedIndex = -1;
            comboRole.SelectedIndex = -1;
        }

        private void ShowData()
        {
            ClearData();

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "SELECT * FROM Users;";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvUsers.DataSource = dt;
            dgvUsers.AutoGenerateColumns = true;

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtUserName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Enter Full Name, Username, and Password to Add!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "INSERT INTO Users (U_FullName, U_Name, U_Pass, U_Email, U_Phone, U_Address, U_DOB, U_Gender, U_Role) VALUES ('" + txtFullName.Text + "', '" + txtUserName.Text + "', '" + txtPass.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + rTxtAddress.Text + "', '" + dtpDOB.Value.ToString("yyyy-MM-dd") + "', '" + comboGender.Text + "', '" + comboRole.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            ShowData();

            MessageBox.Show("User added successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a user to update.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this user information(s)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string query = "UPDATE Users SET U_FullName='" + txtFullName.Text + "', U_Name='" + txtUserName.Text + "', U_Pass='" + txtPass.Text + "', U_Email='" + txtEmail.Text + "', U_Phone='" + txtPhone.Text + "', U_Address='" + rTxtAddress.Text + "', U_DOB='" + dtpDOB.Value.ToString("yyyy-MM-dd") + "', U_Gender='" + comboGender.Text + "', U_Role='" + comboRole.Text + "' WHERE U_ID=" + id;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                                
                ShowData();

                MessageBox.Show("User updated successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a user to delete.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string query = "DELETE FROM Users WHERE U_ID=" + id;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                                
                ShowData();

                MessageBox.Show("User deleted successfully!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void dgvCatagories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtUserID.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFullName.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPass.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                rTxtAddress.Text = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (dgvUsers.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                {
                    dtpDOB.Value = Convert.ToDateTime(dgvUsers.Rows[e.RowIndex].Cells[7].Value);
                }

                comboGender.Text = dgvUsers.Rows[e.RowIndex].Cells[8].Value.ToString();
                comboRole.Text = dgvUsers.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter values into the search field.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "SELECT * FROM Users WHERE U_FullName LIKE '%" + txtSearch.Text + "%' OR U_Name LIKE '%" + txtSearch.Text + "%' OR U_ID LIKE '%" + txtSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvUsers.DataSource = dt;
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard(userName, fullName);
            ad.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}