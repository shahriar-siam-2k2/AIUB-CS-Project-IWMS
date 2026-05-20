using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class Transaction : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string userName, fullName, role;

        public Transaction(string userName, string fullName, string role)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
            InitializeComponent();

            this.Load += Transaction_Load;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            lblRole.Text = role;

            ShowData();
        }

        private void ClearData()
        {
            txtTrID.Text = txtPrID.Text = txtPrName.Text = txtSearch.Text = "";
            nudPQuantity.Value = 0;
            comboTrType.SelectedIndex = -1;

            if (dtpTrDate.MaxDate < DateTime.Today)
            {
                dtpTrDate.MaxDate = DateTime.Today;
            }
            dtpTrDate.Value = DateTime.Today;
        }

        private void ShowData()
        {
            ClearData();

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string prodQuery = "SELECT P_ID, P_Name, P_Price FROM Products;";
            SqlCommand prodCmd = new SqlCommand(prodQuery, con);
            SqlDataAdapter prodAdp = new SqlDataAdapter(prodCmd);
            DataSet prodDs = new DataSet();
            prodAdp.Fill(prodDs);
            dgvProducts.DataSource = prodDs.Tables[0];
            dgvProducts.AutoGenerateColumns = true;

            string trQuery = "SELECT T.T_ID, P.P_Name, T.T_Qty, T.T_Date, T.T_Type " +
                             "FROM Transactions T INNER JOIN Products P ON T.P_ID = P.P_ID ORDER BY T.T_Date DESC;";
            SqlCommand trCmd = new SqlCommand(trQuery, con);
            SqlDataAdapter trAdp = new SqlDataAdapter(trCmd);
            DataSet trDs = new DataSet();
            trAdp.Fill(trDs);
            dgvTransactions.DataSource = trDs.Tables[0];
            dgvTransactions.AutoGenerateColumns = true;

            con.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPrID.Text == "" || nudPQuantity.Value <= 0 || string.IsNullOrWhiteSpace(comboTrType.Text))
            {
                MessageBox.Show("Please select a Product from the list, enter a Quantity greater than 0, and select a Transaction Type.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "INSERT INTO Transactions (P_ID, T_Qty, T_Date, T_Type) VALUES (" + txtPrID.Text + ", " + nudPQuantity.Value + ", '" + dtpTrDate.Value.ToString("yyyy-MM-dd") + "', '" + comboTrType.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            ShowData();

            MessageBox.Show("Transaction submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTrID.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(connString);
                    con.Open();

                    string query = "DELETE FROM Transactions WHERE T_ID=" + txtTrID.Text;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ShowData();
                    MessageBox.Show("Transaction deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtPrID.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?\n\nNOTE: You cannot delete a product if it still has transactions linked to it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(connString);
                        con.Open();

                        string query = "DELETE FROM Products WHERE P_ID=" + txtPrID.Text;

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        ShowData();
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete this product because it has transaction history. Please delete its transactions from the right table first.", "Foreign Key Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Product from the left or a Transaction from the right to delete.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string query = "SELECT P_ID, P_Name, P_Price FROM Products WHERE P_Name LIKE '%" + txtSearch.Text + "%' OR P_ID LIKE '%" + txtSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvProducts.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard(userName, fullName, role);
            ad.Show();
            this.Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPrID.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtTrID.Text = "";
                nudPQuantity.Value = 0;
                comboTrType.SelectedIndex = -1;
            }
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvTransactions.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    return;
                }

                txtPrID.Text = "";

                txtTrID.Text = dgvTransactions.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrName.Text = dgvTransactions.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (dgvTransactions.Rows[e.RowIndex].Cells[2].Value != DBNull.Value)
                {
                    nudPQuantity.Value = Convert.ToDecimal(dgvTransactions.Rows[e.RowIndex].Cells[2].Value);
                }

                if (dgvTransactions.Rows[e.RowIndex].Cells[3].Value != DBNull.Value)
                {
                    dtpTrDate.Value = Convert.ToDateTime(dgvTransactions.Rows[e.RowIndex].Cells[3].Value);
                }

                if (dgvTransactions.Rows[e.RowIndex].Cells[4].Value != DBNull.Value)
                {
                    comboTrType.Text = dgvTransactions.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }
    }
}