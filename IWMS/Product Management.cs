using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class Product_Management : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string id = "";
        string userName, fullName, role;

        public Product_Management(string userName, string fullName, string role)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.role = role;
            InitializeComponent();
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            lblRole.Text = role;
            ShowData();
        }

        private void ClearData()
        {
            txtProductD.Text = txtProductName.Text = txtSearch.Text = "";
            txtCatID.Text = txtCatName.Text = txtDescription.Text = "";
            nudProductPrice.Value = 0;
            pbProductImage.Image = null;
            id = "";
        }

        private void ShowData()
        {
            ClearData();

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "SELECT P.P_ID, P.P_Name, P.P_Price, P.P_Image, P.Cat_ID, C.Cat_Name, C.Cat_Desc " +
                           "FROM Products P LEFT JOIN Categories C ON P.Cat_ID = C.Cat_ID;";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvProducts.DataSource = dt;
            dgvProducts.AutoGenerateColumns = true;

            if (dgvProducts.Columns["P_Image"] != null)
            {
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvProducts.Columns["P_Image"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            con.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbProductImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private byte[] GetImageBytes()
        {
            if (pbProductImage.Image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(pbProductImage.Image);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || nudProductPrice.Value <= 0 || txtCatName.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please ensure Product Name, Category Name are filled, and Price is greater than 0.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetCatID;

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string checkCatQuery = "SELECT Cat_ID FROM Categories WHERE Cat_Name = '" + txtCatName.Text + "'";
            SqlCommand checkCmd = new SqlCommand(checkCatQuery, con);
            object result = checkCmd.ExecuteScalar();

            if (result != null)
            {
                targetCatID = Convert.ToInt32(result);
            }
            else
            {
                string catQuery = "INSERT INTO Categories (Cat_Name, Cat_Desc) OUTPUT INSERTED.Cat_ID VALUES ('" + txtCatName.Text + "', '" + txtDescription.Text + "')";
                SqlCommand catCmd = new SqlCommand(catQuery, con);
                targetCatID = (int)catCmd.ExecuteScalar();
            }

            string query = "INSERT INTO Products (P_Name, P_Price, P_Image, Cat_ID) VALUES ('" + txtProductName.Text + "', " + nudProductPrice.Value + ", @Image, " + targetCatID + ")";

            SqlCommand cmd = new SqlCommand(query, con);

            byte[] imgBytes = GetImageBytes();
            if (imgBytes != null)
                cmd.Parameters.AddWithValue("@Image", imgBytes);
            else
                cmd.Parameters.AddWithValue("@Image", DBNull.Value);

            cmd.ExecuteNonQuery();
            con.Close();

            ShowData();

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a product to update.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtProductName.Text == "" || nudProductPrice.Value <= 0 || txtCatName.Text == "")
            {
                MessageBox.Show("Please ensure Product Name, Category Name are filled, and Price is greater than 0.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                int targetCatID;

                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string checkCatQuery = "SELECT Cat_ID FROM Categories WHERE Cat_Name = '" + txtCatName.Text + "'";
                SqlCommand checkCmd = new SqlCommand(checkCatQuery, con);
                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    targetCatID = Convert.ToInt32(result);
                    string updateCatDesc = "UPDATE Categories SET Cat_Desc='" + txtDescription.Text + "' WHERE Cat_ID=" + targetCatID;
                    SqlCommand updateCatCmd = new SqlCommand(updateCatDesc, con);
                    updateCatCmd.ExecuteNonQuery();
                }
                else
                {
                    string catQuery = "INSERT INTO Categories (Cat_Name, Cat_Desc) OUTPUT INSERTED.Cat_ID VALUES ('" + txtCatName.Text + "', '" + txtDescription.Text + "')";
                    SqlCommand catCmd = new SqlCommand(catQuery, con);
                    targetCatID = (int)catCmd.ExecuteScalar();
                }

                string query = "UPDATE Products SET P_Name='" + txtProductName.Text + "', P_Price=" + nudProductPrice.Value + ", P_Image=@Image, Cat_ID=" + targetCatID + " WHERE P_ID=" + id;

                SqlCommand cmd = new SqlCommand(query, con);

                byte[] imgBytes = GetImageBytes();
                if (imgBytes != null)
                    cmd.Parameters.AddWithValue("@Image", imgBytes);
                else
                    cmd.Parameters.AddWithValue("@Image", DBNull.Value);

                cmd.ExecuteNonQuery();

                string cleanupQuery = "DELETE FROM Categories WHERE Cat_ID NOT IN (SELECT DISTINCT Cat_ID FROM Products WHERE Cat_ID IS NOT NULL)";
                SqlCommand cleanupCmd = new SqlCommand(cleanupQuery, con);
                cleanupCmd.ExecuteNonQuery();

                con.Close();

                ShowData();

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a product to delete.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                string query = "DELETE FROM Products WHERE P_ID=" + id;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                string cleanupQuery = "DELETE FROM Categories WHERE Cat_ID NOT IN (SELECT DISTINCT Cat_ID FROM Products WHERE Cat_ID IS NOT NULL)";
                SqlCommand cleanupCmd = new SqlCommand(cleanupQuery, con);
                cleanupCmd.ExecuteNonQuery();

                con.Close();

                ShowData();

                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtProductD.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (dgvProducts.Rows[e.RowIndex].Cells[2].Value != DBNull.Value)
                {
                    nudProductPrice.Value = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells[2].Value);
                }

                if (dgvProducts.Rows[e.RowIndex].Cells[3].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])dgvProducts.Rows[e.RowIndex].Cells[3].Value;
                    MemoryStream ms = new MemoryStream(imgData);

                    pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pbProductImage.Image = Image.FromStream(ms);
                }
                else
                {
                    pbProductImage.Image = null;
                }

                if (dgvProducts.Rows[e.RowIndex].Cells[4].Value != DBNull.Value) 
                {
                    txtCatID.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                }   
                else
                { 
                    txtCatID.Text = "";
                }

                if (dgvProducts.Rows[e.RowIndex].Cells[5].Value != DBNull.Value)
                {
                    txtCatName.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    txtCatName.Text = "";
                }

                if (dgvProducts.Rows[e.RowIndex].Cells[6].Value != DBNull.Value)
                { 
                    txtDescription.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
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

            string query = "SELECT P.P_ID, P.P_Name, P.P_Price, P.P_Image, P.Cat_ID, C.Cat_Name, C.Cat_Desc FROM Products P LEFT JOIN Categories C ON P.Cat_ID = C.Cat_ID WHERE P.P_Name LIKE '%" + txtSearch.Text + "%' OR P.P_ID LIKE '%" + txtSearch.Text + "%' OR P.P_Price LIKE '%" + txtSearch.Text + "%' OR C.Cat_ID LIKE '%" + txtSearch.Text + "%' OR C.Cat_Name LIKE '%" + txtSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dgvProducts.DataSource = dt;
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