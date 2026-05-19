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
            dgvCatagories = new DataGridView();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            lblRole = new Label();
            lblUserName = new Label();
            btnRefresh = new Button();
            lblCatID = new Label();
            txtCatID = new TextBox();
            lblCatName = new Label();
            txtCatName = new TextBox();
            lblDescription = new Label();
            txtDescription = new RichTextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatagories).BeginInit();
            SuspendLayout();
            // 
            // dgvCatagories
            // 
            dgvCatagories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatagories.Location = new Point(195, 69);
            dgvCatagories.Name = "dgvCatagories";
            dgvCatagories.Size = new Size(593, 352);
            dgvCatagories.TabIndex = 0;
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
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(314, 29);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(199, 24);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Catagory Management";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(162, 442);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 45);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(287, 442);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 45);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(410, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 45);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(328, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
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
            btnRefresh.Location = new Point(615, 462);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 45);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblCatID
            // 
            lblCatID.AutoSize = true;
            lblCatID.Font = new Font("Trebuchet MS", 11.25F);
            lblCatID.Location = new Point(8, 162);
            lblCatID.Name = "lblCatID";
            lblCatID.Size = new Size(87, 20);
            lblCatID.TabIndex = 4;
            lblCatID.Text = "Catagory ID";
            lblCatID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCatID
            // 
            txtCatID.AccessibleDescription = "Category ID is Read-Only";
            txtCatID.Cursor = Cursors.No;
            txtCatID.Font = new Font("Trebuchet MS", 11.25F);
            txtCatID.Location = new Point(12, 187);
            txtCatID.Name = "txtCatID";
            txtCatID.ReadOnly = true;
            txtCatID.Size = new Size(165, 25);
            txtCatID.TabIndex = 33;
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Font = new Font("Trebuchet MS", 11.25F);
            lblCatName.Location = new Point(8, 220);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(113, 20);
            lblCatName.TabIndex = 4;
            lblCatName.Text = "Catagory Name";
            lblCatName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCatName
            // 
            txtCatName.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatName.Location = new Point(12, 246);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(165, 23);
            txtCatName.TabIndex = 33;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Trebuchet MS", 11.25F);
            lblDescription.Location = new Point(8, 274);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(12, 297);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(165, 126);
            txtDescription.TabIndex = 34;
            txtDescription.Text = "";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Trebuchet MS", 11.25F);
            txtSearch.Location = new Point(12, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 25);
            txtSearch.TabIndex = 36;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Trebuchet MS", 11.25F);
            lblSearch.Location = new Point(10, 44);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(129, 20);
            lblSearch.TabIndex = 35;
            lblSearch.Text = "Search Catagories";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 31);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtCatName);
            Controls.Add(txtCatID);
            Controls.Add(btnRefresh);
            Controls.Add(lblUserName);
            Controls.Add(lblRole);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lblDescription);
            Controls.Add(lblCatName);
            Controls.Add(lblCatID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(dgvCatagories);
            Name = "Product_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Product Management";
            ((System.ComponentModel.ISupportInitialize)dgvCatagories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCatagories;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblRole;
        private Label lblUserName;
        private Button btnRefresh;
        private Label lblCatID;
        private TextBox txtCatID;
        private Label lblCatName;
        private TextBox txtCatName;
        private Label lblDescription;
        private RichTextBox txtDescription;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
    }
}