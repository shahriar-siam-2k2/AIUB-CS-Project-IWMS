using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IWMS
{
    public partial class Admin_Dashboard : Form
    {
        private string userName;
        private string fullName;
        private string role;

        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        
        public Admin_Dashboard(string userName, string fullName, string role)
        {
            InitializeComponent();

            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
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

                string queryUsers = "SELECT COUNT(*) FROM Users";
                string queryProducts = "SELECT COUNT(*) FROM Products";
                string queryCategories = "SELECT COUNT(*) FROM Categories";
                string queryTransactions = "SELECT COUNT(*) FROM Transactions";

                SqlCommand cmdUsers = new SqlCommand(queryUsers, con);
                lblRegisteredUsers.Text = cmdUsers.ExecuteScalar().ToString();

                SqlCommand cmdProducts = new SqlCommand(queryProducts, con);
                lblTotalProducts.Text = cmdProducts.ExecuteScalar().ToString();

                SqlCommand cmdCategories = new SqlCommand(queryCategories, con);
                lblCategories.Text = cmdCategories.ExecuteScalar().ToString();

                SqlCommand cmdTransactions = new SqlCommand(queryTransactions, con);
                lblTotalStock.Text = cmdTransactions.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading database summaries: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            User_Management um = new User_Management(userName, fullName, role);
            um.Show();
            this.Hide();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            Product_Management pm = new Product_Management(userName, fullName, role);
            pm.Show();
            this.Hide();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            Catagory_Management cm = new Catagory_Management(userName, fullName, role);
            cm.Show();
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

        private void serverTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
