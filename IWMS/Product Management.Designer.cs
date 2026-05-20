namespace IWMS
{
    partial class Product_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProducts = new DataGridView();
            lblTitle = new Label();
            lblProduct = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            lblRole = new Label();
            lblUserName = new Label();
            btnRefresh = new Button();
            lblProductID = new Label();
            txtProductD = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            lblProductPrice = new Label();
            nudProductPrice = new NumericUpDown();
            btnClear = new Button();
            lblProductImage = new Label();
            pbProductImage = new PictureBox();
            pictureBox2 = new PictureBox();
            btnUpload = new Button();
            pictureBox3 = new PictureBox();
            lblCatID = new Label();
            txtCatID = new TextBox();
            lblCatName = new Label();
            txtCatName = new TextBox();
            txtDescription = new RichTextBox();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(301, 69);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Size = new Size(487, 352);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(180, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(314, 29);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(189, 24);
            lblProduct.TabIndex = 4;
            lblProduct.Text = "Product Management";
            lblProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(307, 442);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 45);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(432, 442);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 45);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(555, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 45);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(336, 505);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 45);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnCancel_Click;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(706, 29);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(85, 20);
            lblRole.TabIndex = 30;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(706, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 20);
            lblUserName.TabIndex = 31;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 192, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(679, 442);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 45);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Trebuchet MS", 11.25F);
            lblProductID.Location = new Point(149, 69);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(77, 20);
            lblProductID.TabIndex = 4;
            lblProductID.Text = "Product ID";
            lblProductID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductD
            // 
            txtProductD.AccessibleDescription = "Category ID is Read-Only";
            txtProductD.Cursor = Cursors.No;
            txtProductD.Font = new Font("Trebuchet MS", 11.25F);
            txtProductD.Location = new Point(149, 94);
            txtProductD.Name = "txtProductD";
            txtProductD.ReadOnly = true;
            txtProductD.Size = new Size(143, 25);
            txtProductD.TabIndex = 33;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Trebuchet MS", 11.25F);
            lblProductName.Location = new Point(149, 182);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Product Name";
            lblProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(152, 208);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(143, 23);
            txtProductName.TabIndex = 33;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Trebuchet MS", 11.25F);
            txtSearch.Location = new Point(12, 116);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 25);
            txtSearch.TabIndex = 36;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Trebuchet MS", 11.25F);
            lblSearch.Location = new Point(10, 91);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(114, 20);
            lblSearch.TabIndex = 35;
            lblSearch.Text = "Search Products";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 31);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Trebuchet MS", 11.25F);
            lblProductPrice.Location = new Point(153, 373);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(96, 20);
            lblProductPrice.TabIndex = 37;
            lblProductPrice.Text = "Product Price";
            lblProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudProductPrice
            // 
            nudProductPrice.Font = new Font("Trebuchet MS", 9.75F);
            nudProductPrice.Location = new Point(155, 396);
            nudProductPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudProductPrice.Name = "nudProductPrice";
            nudProductPrice.Size = new Size(143, 23);
            nudProductPrice.TabIndex = 38;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(86, 442);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 45);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblProductImage
            // 
            lblProductImage.AutoSize = true;
            lblProductImage.Font = new Font("Trebuchet MS", 11.25F);
            lblProductImage.Location = new Point(24, 337);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(105, 20);
            lblProductImage.TabIndex = 39;
            lblProductImage.Text = "Product Image";
            lblProductImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbProductImage
            // 
            pbProductImage.BorderStyle = BorderStyle.Fixed3D;
            pbProductImage.Location = new Point(12, 210);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(128, 124);
            pbProductImage.TabIndex = 40;
            pbProductImage.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-583, -62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 79);
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gray;
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(10, 360);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(135, 31);
            btnUpload.TabIndex = 24;
            btnUpload.Text = "Upload Image";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(-583, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 79);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // lblCatID
            // 
            lblCatID.AutoSize = true;
            lblCatID.Font = new Font("Trebuchet MS", 11.25F);
            lblCatID.Location = new Point(149, 122);
            lblCatID.Name = "lblCatID";
            lblCatID.Size = new Size(87, 20);
            lblCatID.TabIndex = 4;
            lblCatID.Text = "Category ID";
            lblCatID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCatID
            // 
            txtCatID.AccessibleDescription = "Category ID is Read-Only";
            txtCatID.Cursor = Cursors.No;
            txtCatID.Font = new Font("Trebuchet MS", 11.25F);
            txtCatID.Location = new Point(149, 147);
            txtCatID.Name = "txtCatID";
            txtCatID.ReadOnly = true;
            txtCatID.Size = new Size(143, 25);
            txtCatID.TabIndex = 33;
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Font = new Font("Trebuchet MS", 11.25F);
            lblCatName.Location = new Point(149, 236);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(113, 20);
            lblCatName.TabIndex = 4;
            lblCatName.Text = "Category Name";
            lblCatName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCatName
            // 
            txtCatName.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatName.Location = new Point(152, 260);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(143, 23);
            txtCatName.TabIndex = 33;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(153, 309);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(139, 61);
            txtDescription.TabIndex = 42;
            txtDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Trebuchet MS", 11.25F);
            lblDescription.Location = new Point(149, 286);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 20);
            lblDescription.TabIndex = 41;
            lblDescription.Text = "Description";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pbProductImage);
            Controls.Add(lblProductImage);
            Controls.Add(nudProductPrice);
            Controls.Add(lblProductPrice);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtCatName);
            Controls.Add(txtProductName);
            Controls.Add(txtCatID);
            Controls.Add(txtProductD);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(lblUserName);
            Controls.Add(lblRole);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpload);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lblCatID);
            Controls.Add(lblCatName);
            Controls.Add(lblProductName);
            Controls.Add(lblProductID);
            Controls.Add(lblProduct);
            Controls.Add(lblTitle);
            Controls.Add(dgvProducts);
            Name = "Product_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Product Management";
            Load += Product_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label lblTitle;
        private Label lblProduct;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private Label lblRole;
        private Label lblUserName;
        private Button btnRefresh;
        private Label lblProductID;
        private TextBox txtProductD;
        private Label lblProductName;
        private TextBox txtProductName;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Label lblProductPrice;
        private NumericUpDown nudProductPrice;
        private Button btnClear;
        private Label lblProductImage;
        private PictureBox pbProductImage;
        private PictureBox pictureBox2;
        private Button btnUpload;
        private PictureBox pictureBox3;
        private Label lblCatID;
        private TextBox txtCatID;
        private Label lblCatName;
        private TextBox txtCatName;
        private RichTextBox txtDescription;
        private Label lblDescription;
    }
}