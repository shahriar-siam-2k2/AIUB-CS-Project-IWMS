namespace IWMS
{
    partial class Admin_Dashboard
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            btnManageProducts = new Button();
            btnStock = new Button();
            btnAccount = new Button();
            btnLogout = new Button();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblUserName = new Label();
            pnlRegisteredUsers = new Panel();
            iconRegisteredUsers = new PictureBox();
            lblRegisteredUsers = new Label();
            lblRegisteredUsersTitle = new Label();
            label6 = new Label();
            pnlTotalProducts = new Panel();
            iconTotalProducts = new PictureBox();
            lblTotalProducts = new Label();
            lblTotalProductsTitle = new Label();
            label7 = new Label();
            pnlCategories = new Panel();
            iconCategories = new PictureBox();
            lblCategories = new Label();
            lblCategoriesTitle = new Label();
            label12 = new Label();
            pnlTotalStock = new Panel();
            iconTotalStock = new PictureBox();
            lblTotalStock = new Label();
            lblTotalStockTitle = new Label();
            btnManageUsers = new Button();
            btnManageCategories = new Button();
            pnlRegisteredUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRegisteredUsers).BeginInit();
            pnlTotalProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalProducts).BeginInit();
            pnlCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCategories).BeginInit();
            pnlTotalStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(171, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(320, 36);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(158, 24);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Admin Dashboard";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top;
            lblFullName.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(221, 84);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(352, 24);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Welcome Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = Color.FromArgb(192, 255, 255);
            btnManageProducts.Cursor = Cursors.Hand;
            btnManageProducts.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            btnManageProducts.Location = new Point(220, 316);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(169, 45);
            btnManageProducts.TabIndex = 25;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(255, 224, 192);
            btnStock.Cursor = Cursors.Hand;
            btnStock.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            btnStock.Location = new Point(609, 316);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(169, 45);
            btnStock.TabIndex = 25;
            btnStock.Text = "Stock In/Out";
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(128, 128, 255);
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(305, 381);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(195, 45);
            btnAccount.TabIndex = 25;
            btnAccount.Text = "Account Settings";
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top;
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(305, 436);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(195, 45);
            btnLogout.TabIndex = 30;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(686, 86);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(97, 22);
            lblTime.TabIndex = 5;
            lblTime.Text = "Server Time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(19, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 22);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRegisteredUsers
            // 
            pnlRegisteredUsers.BackColor = Color.FromArgb(255, 255, 192);
            pnlRegisteredUsers.Controls.Add(iconRegisteredUsers);
            pnlRegisteredUsers.Controls.Add(lblRegisteredUsers);
            pnlRegisteredUsers.Controls.Add(lblRegisteredUsersTitle);
            pnlRegisteredUsers.Location = new Point(22, 127);
            pnlRegisteredUsers.Name = "pnlRegisteredUsers";
            pnlRegisteredUsers.Size = new Size(169, 162);
            pnlRegisteredUsers.TabIndex = 31;
            // 
            // iconRegisteredUsers
            // 
            iconRegisteredUsers.Image = Properties.Resources.users;
            iconRegisteredUsers.Location = new Point(32, 9);
            iconRegisteredUsers.Name = "iconRegisteredUsers";
            iconRegisteredUsers.Size = new Size(100, 50);
            iconRegisteredUsers.SizeMode = PictureBoxSizeMode.Zoom;
            iconRegisteredUsers.TabIndex = 6;
            iconRegisteredUsers.TabStop = false;
            // 
            // lblRegisteredUsers
            // 
            lblRegisteredUsers.Anchor = AnchorStyles.Top;
            lblRegisteredUsers.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisteredUsers.Location = new Point(12, 93);
            lblRegisteredUsers.Name = "lblRegisteredUsers";
            lblRegisteredUsers.Size = new Size(142, 60);
            lblRegisteredUsers.TabIndex = 5;
            lblRegisteredUsers.Text = "1000";
            lblRegisteredUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegisteredUsersTitle
            // 
            lblRegisteredUsersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRegisteredUsersTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            lblRegisteredUsersTitle.Location = new Point(0, 69);
            lblRegisteredUsersTitle.Name = "lblRegisteredUsersTitle";
            lblRegisteredUsersTitle.Size = new Size(169, 24);
            lblRegisteredUsersTitle.TabIndex = 5;
            lblRegisteredUsersTitle.Text = "Registered Users";
            lblRegisteredUsersTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 173);
            label6.Name = "label6";
            label6.Size = new Size(139, 24);
            label6.TabIndex = 5;
            label6.Text = "Total Products";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = Color.FromArgb(192, 255, 255);
            pnlTotalProducts.Controls.Add(iconTotalProducts);
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Controls.Add(lblTotalProductsTitle);
            pnlTotalProducts.Location = new Point(220, 127);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(169, 162);
            pnlTotalProducts.TabIndex = 31;
            // 
            // iconTotalProducts
            // 
            iconTotalProducts.Image = Properties.Resources.product;
            iconTotalProducts.Location = new Point(32, 8);
            iconTotalProducts.Name = "iconTotalProducts";
            iconTotalProducts.Size = new Size(100, 50);
            iconTotalProducts.SizeMode = PictureBoxSizeMode.Zoom;
            iconTotalProducts.TabIndex = 6;
            iconTotalProducts.TabStop = false;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Anchor = AnchorStyles.Top;
            lblTotalProducts.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(13, 92);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(142, 60);
            lblTotalProducts.TabIndex = 5;
            lblTotalProducts.Text = "1300";
            lblTotalProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTotalProductsTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            lblTotalProductsTitle.Location = new Point(0, 67);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(169, 24);
            lblTotalProductsTitle.TabIndex = 5;
            lblTotalProductsTitle.Text = "Total Products";
            lblTotalProductsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(427, 173);
            label7.Name = "label7";
            label7.Size = new Size(139, 24);
            label7.TabIndex = 5;
            label7.Text = "Total Products";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCategories
            // 
            pnlCategories.BackColor = Color.FromArgb(192, 255, 192);
            pnlCategories.Controls.Add(iconCategories);
            pnlCategories.Controls.Add(lblCategories);
            pnlCategories.Controls.Add(lblCategoriesTitle);
            pnlCategories.Location = new Point(415, 127);
            pnlCategories.Name = "pnlCategories";
            pnlCategories.Size = new Size(169, 162);
            pnlCategories.TabIndex = 31;
            // 
            // iconCategories
            // 
            iconCategories.Image = Properties.Resources.categories;
            iconCategories.Location = new Point(32, 8);
            iconCategories.Name = "iconCategories";
            iconCategories.Size = new Size(100, 50);
            iconCategories.SizeMode = PictureBoxSizeMode.Zoom;
            iconCategories.TabIndex = 6;
            iconCategories.TabStop = false;
            // 
            // lblCategories
            // 
            lblCategories.Anchor = AnchorStyles.Top;
            lblCategories.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategories.Location = new Point(12, 89);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(142, 60);
            lblCategories.TabIndex = 5;
            lblCategories.Text = "130";
            lblCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategoriesTitle
            // 
            lblCategoriesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCategoriesTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            lblCategoriesTitle.Location = new Point(0, 66);
            lblCategoriesTitle.Name = "lblCategoriesTitle";
            lblCategoriesTitle.Size = new Size(169, 24);
            lblCategoriesTitle.TabIndex = 5;
            lblCategoriesTitle.Text = "Categories";
            lblCategoriesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(621, 173);
            label12.Name = "label12";
            label12.Size = new Size(139, 24);
            label12.TabIndex = 5;
            label12.Text = "Total Products";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalStock
            // 
            pnlTotalStock.BackColor = Color.FromArgb(255, 224, 192);
            pnlTotalStock.Controls.Add(iconTotalStock);
            pnlTotalStock.Controls.Add(lblTotalStock);
            pnlTotalStock.Controls.Add(lblTotalStockTitle);
            pnlTotalStock.Location = new Point(609, 127);
            pnlTotalStock.Name = "pnlTotalStock";
            pnlTotalStock.Size = new Size(169, 162);
            pnlTotalStock.TabIndex = 31;
            // 
            // iconTotalStock
            // 
            iconTotalStock.Image = Properties.Resources.stock_and_truck;
            iconTotalStock.Location = new Point(32, 9);
            iconTotalStock.Name = "iconTotalStock";
            iconTotalStock.Size = new Size(100, 50);
            iconTotalStock.SizeMode = PictureBoxSizeMode.Zoom;
            iconTotalStock.TabIndex = 6;
            iconTotalStock.TabStop = false;
            // 
            // lblTotalStock
            // 
            lblTotalStock.Anchor = AnchorStyles.Top;
            lblTotalStock.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(12, 89);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(142, 60);
            lblTotalStock.TabIndex = 5;
            lblTotalStock.Text = "40";
            lblTotalStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalStockTitle
            // 
            lblTotalStockTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTotalStockTitle.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            lblTotalStockTitle.Location = new Point(2, 67);
            lblTotalStockTitle.Name = "lblTotalStockTitle";
            lblTotalStockTitle.Size = new Size(166, 24);
            lblTotalStockTitle.TabIndex = 5;
            lblTotalStockTitle.Text = "Total Stock In/Out";
            lblTotalStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.FromArgb(255, 255, 192);
            btnManageUsers.Cursor = Cursors.Hand;
            btnManageUsers.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            btnManageUsers.Location = new Point(22, 316);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(169, 45);
            btnManageUsers.TabIndex = 25;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            // 
            // btnManageCategories
            // 
            btnManageCategories.BackColor = Color.FromArgb(192, 255, 192);
            btnManageCategories.Cursor = Cursors.Hand;
            btnManageCategories.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            btnManageCategories.Location = new Point(415, 316);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(169, 45);
            btnManageCategories.TabIndex = 25;
            btnManageCategories.Text = "Manage Categories";
            btnManageCategories.UseVisualStyleBackColor = false;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(pnlTotalStock);
            Controls.Add(pnlCategories);
            Controls.Add(label12);
            Controls.Add(pnlTotalProducts);
            Controls.Add(label7);
            Controls.Add(pnlRegisteredUsers);
            Controls.Add(label6);
            Controls.Add(btnLogout);
            Controls.Add(btnAccount);
            Controls.Add(btnStock);
            Controls.Add(btnManageCategories);
            Controls.Add(btnManageUsers);
            Controls.Add(btnManageProducts);
            Controls.Add(lblUserName);
            Controls.Add(lblTime);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Admin Dashboard";
            Load += Admin_Dashboard_Load;
            pnlRegisteredUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconRegisteredUsers).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTotalProducts).EndInit();
            pnlCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCategories).EndInit();
            pnlTotalStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTotalStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private Button btnManageProducts;
        private Button btnStock;
        private Button btnAccount;
        private Button btnLogout;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Label lblUserName;
        private Panel pnlRegisteredUsers;
        private Label lblRegisteredUsersTitle;
        private Label lblRegisteredUsers;
        private Label label6;
        private Panel pnlTotalProducts;
        private Label lblTotalProducts;
        private Label lblTotalProductsTitle;
        private Label label7;
        private Panel pnlCategories;
        private Label lblCategories;
        private Label lblCategoriesTitle;
        private Label label12;
        private Panel pnlTotalStock;
        private Label lblTotalStock;
        private Label lblTotalStockTitle;
        private PictureBox iconRegisteredUsers;
        private PictureBox iconTotalProducts;
        private PictureBox iconCategories;
        private PictureBox iconTotalStock;
        private Button btnManageUsers;
        private Button btnManageCategories;
    }
}