using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class Catagory_Management : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string id = "";
        string userName, fullName, role;

        public Catagory_Management(string userName, string fullName, string role)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
            InitializeComponent();

            // ADD THIS SINGLE LINE TO FORCE THE CONNECTION:
            this.Load += Catagory_Management_Load;
        }

        private void Catagory_Management_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            lblRole.Text = role;

            ShowData();
        }

        private void ClearData()
        {
            txtCatID.Text = txtCatName.Text = txtDescription.Text = txtSearch.Text = "";
            id = "";
        }

        private void ShowData()
        {
            ClearData();

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "SELECT * FROM Categories;";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvCategories.DataSource = dt;
            dgvCategories.AutoGenerateColumns = true;

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Please enter a Category Name.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string checkQuery = "SELECT COUNT(*) FROM Categories WHERE Cat_Name = '" + txtCatName.Text + "'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("A category with this name already exists. Please choose a different name.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }

            string query = "INSERT INTO Categories (Cat_Name, Cat_Desc) VALUES ('" + txtCatName.Text + "', '" + txtDescription.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            ShowData();

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a category to update.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCatName.Text == "")
            {
                MessageBox.Show("Category Name cannot be empty.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string checkQuery = "SELECT COUNT(*) FROM Categories WHERE Cat_Name = '" + txtCatName.Text + "' AND Cat_ID != " + id;
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Another category with this name already exists. Please choose a different name.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this category?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "UPDATE Categories SET Cat_Name='" + txtCatName.Text + "', Cat_Desc='" + txtDescription.Text + "' WHERE Cat_ID=" + id;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                ShowData();

                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a category to delete.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?\n\nNOTE: You cannot delete a category if there are products currently assigned to it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connString);
                    con.Open();

                    string query = "DELETE FROM Categories WHERE Cat_ID=" + id;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ShowData();

                    MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Cannot delete this category because it is currently being used by one or more products. Please reassign or delete those products first.", "Foreign Key Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvCatagories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtCatID.Text = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCatName.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (dgvCategories.Rows[e.RowIndex].Cells[2].Value != DBNull.Value)
                {
                    txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    txtDescription.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a value to search.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "SELECT * FROM Categories WHERE Cat_Name LIKE '%" + txtSearch.Text + "%' OR Cat_ID LIKE '%" + txtSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvCategories.DataSource = dt;
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard(userName, fullName, role);
            ad.Show();
            this.Close();
        }
    }
}