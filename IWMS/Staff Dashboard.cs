using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class Staff_Dashboard : Form
    {
        private string userName;
        private string fullName;
        private string role;

        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Staff_Dashboard(string userName, string fullName, string role)
        {
            InitializeComponent();

            this.userName = userName;
            this.fullName = fullName;
            this.role = role;

            this.Load += Staff_Dashboard_Load;
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            serverTimer.Start();
            LoadSummaries();
        }

        private void LoadSummaries()
        {
            lblUserName.Text = userName;
            lblFullName.Text = "Welcome " + fullName;

            try
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string queryProducts = "SELECT COUNT(*) FROM Products";
                SqlCommand cmdProducts = new SqlCommand(queryProducts, con);
                lblTotalProducts.Text = cmdProducts.ExecuteScalar().ToString();

                string todayDate = DateTime.Now.ToString("yyyy-MM-dd");

                string queryReceived = "SELECT ISNULL(SUM(T_Qty), 0) FROM Transactions WHERE T_Type LIKE 'Stock%In' AND CAST(T_Date AS DATE) = '" + todayDate + "'";
                SqlCommand cmdReceived = new SqlCommand(queryReceived, con);
                lblReceived.Text = cmdReceived.ExecuteScalar().ToString();

                string queryDispatched = "SELECT ISNULL(SUM(T_Qty), 0) FROM Transactions WHERE T_Type LIKE 'Stock%Out' AND CAST(T_Date AS DATE) = '" + todayDate + "'";
                SqlCommand cmdDispatched = new SqlCommand(queryDispatched, con);
                lblDispatched.Text = cmdDispatched.ExecuteScalar().ToString();

                if (Convert.ToInt32(lblTotalProducts.Text) > 0)
                {
                    lblStatus.Text = "OK";
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblStatus.Text = "Empty";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard summaries: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serverTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            Product_Management pm = new Product_Management(userName, fullName, role);
            pm.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction(userName, fullName, role);
            t.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Account_Settings accs = new Account_Settings(fullName, userName, role);
            accs.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}