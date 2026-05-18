namespace IWMS
{
    partial class Staff_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Dashboard));
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            btnViewProducts = new Button();
            btnStock = new Button();
            btnAccount = new Button();
            btnLogout = new Button();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblUserName = new Label();
            pnlTotalProduct = new Panel();
            iconTotalProducts = new PictureBox();
            lblTotalProducts = new Label();
            lblTotalProductsTitle = new Label();
            label6 = new Label();
            pnlStatus = new Panel();
            iconStatus = new PictureBox();
            lblStatus = new Label();
            lblStatusTitle = new Label();
            label7 = new Label();
            pnlReceived = new Panel();
            iconReceived = new PictureBox();
            lblReceived = new Label();
            lblReceivedTitle = new Label();
            label12 = new Label();
            pnlDispatched = new Panel();
            iconDispatched = new PictureBox();
            lblDispatched = new Label();
            lblDispatchedTitle = new Label();
            pnlTotalProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalProducts).BeginInit();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatus).BeginInit();
            pnlReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconReceived).BeginInit();
            pnlDispatched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDispatched).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(174, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(324, 36);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(147, 24);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Staff Dashboard";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(315, 84);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(178, 24);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Welcome Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViewProducts
            // 
            btnViewProducts.BackColor = Color.Yellow;
            btnViewProducts.Cursor = Cursors.Hand;
            btnViewProducts.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProducts.Location = new Point(68, 316);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(195, 45);
            btnViewProducts.TabIndex = 25;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(255, 192, 128);
            btnStock.Cursor = Cursors.Hand;
            btnStock.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.Location = new Point(305, 316);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(195, 45);
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
            btnAccount.Location = new Point(548, 316);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(195, 45);
            btnAccount.TabIndex = 25;
            btnAccount.Text = "Account Settings";
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(305, 382);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(195, 45);
            btnLogout.TabIndex = 30;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(681, 86);
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
            lblUserName.Location = new Point(22, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 22);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalProduct
            // 
            pnlTotalProduct.BackColor = Color.FromArgb(192, 192, 255);
            pnlTotalProduct.Controls.Add(iconTotalProducts);
            pnlTotalProduct.Controls.Add(lblTotalProducts);
            pnlTotalProduct.Controls.Add(lblTotalProductsTitle);
            pnlTotalProduct.Location = new Point(22, 127);
            pnlTotalProduct.Name = "pnlTotalProduct";
            pnlTotalProduct.Size = new Size(169, 162);
            pnlTotalProduct.TabIndex = 31;
            // 
            // iconTotalProducts
            // 
            iconTotalProducts.Image = (Image)resources.GetObject("iconTotalProducts.Image");
            iconTotalProducts.Location = new Point(32, 9);
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
            lblTotalProducts.Location = new Point(12, 93);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(142, 60);
            lblTotalProducts.TabIndex = 5;
            lblTotalProducts.Text = "1000";
            lblTotalProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsTitle.Location = new Point(13, 69);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(139, 24);
            lblTotalProductsTitle.TabIndex = 5;
            lblTotalProductsTitle.Text = "Total Products";
            lblTotalProductsTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(192, 255, 255);
            pnlStatus.Controls.Add(iconStatus);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Controls.Add(lblStatusTitle);
            pnlStatus.Location = new Point(220, 127);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(169, 162);
            pnlStatus.TabIndex = 31;
            // 
            // iconStatus
            // 
            iconStatus.Image = (Image)resources.GetObject("iconStatus.Image");
            iconStatus.Location = new Point(32, 8);
            iconStatus.Name = "iconStatus";
            iconStatus.Size = new Size(100, 50);
            iconStatus.SizeMode = PictureBoxSizeMode.Zoom;
            iconStatus.TabIndex = 6;
            iconStatus.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(13, 92);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(142, 60);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "OK";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.Location = new Point(22, 67);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(120, 24);
            lblStatusTitle.TabIndex = 5;
            lblStatusTitle.Text = "Stock Status";
            lblStatusTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            // pnlReceived
            // 
            pnlReceived.BackColor = Color.FromArgb(192, 255, 192);
            pnlReceived.Controls.Add(iconReceived);
            pnlReceived.Controls.Add(lblReceived);
            pnlReceived.Controls.Add(lblReceivedTitle);
            pnlReceived.Location = new Point(415, 127);
            pnlReceived.Name = "pnlReceived";
            pnlReceived.Size = new Size(169, 162);
            pnlReceived.TabIndex = 31;
            // 
            // iconReceived
            // 
            iconReceived.Image = (Image)resources.GetObject("iconReceived.Image");
            iconReceived.Location = new Point(32, 8);
            iconReceived.Name = "iconReceived";
            iconReceived.Size = new Size(100, 50);
            iconReceived.SizeMode = PictureBoxSizeMode.Zoom;
            iconReceived.TabIndex = 6;
            iconReceived.TabStop = false;
            // 
            // lblReceived
            // 
            lblReceived.Anchor = AnchorStyles.Top;
            lblReceived.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceived.Location = new Point(12, 89);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(142, 60);
            lblReceived.TabIndex = 5;
            lblReceived.Text = "130";
            lblReceived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReceivedTitle
            // 
            lblReceivedTitle.AutoSize = true;
            lblReceivedTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceivedTitle.Location = new Point(7, 66);
            lblReceivedTitle.Name = "lblReceivedTitle";
            lblReceivedTitle.Size = new Size(151, 24);
            lblReceivedTitle.TabIndex = 5;
            lblReceivedTitle.Text = "Received Today";
            lblReceivedTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            // pnlDispatched
            // 
            pnlDispatched.BackColor = Color.FromArgb(255, 224, 192);
            pnlDispatched.Controls.Add(iconDispatched);
            pnlDispatched.Controls.Add(lblDispatched);
            pnlDispatched.Controls.Add(lblDispatchedTitle);
            pnlDispatched.Location = new Point(609, 127);
            pnlDispatched.Name = "pnlDispatched";
            pnlDispatched.Size = new Size(169, 162);
            pnlDispatched.TabIndex = 31;
            // 
            // iconDispatched
            // 
            iconDispatched.Image = (Image)resources.GetObject("iconDispatched.Image");
            iconDispatched.Location = new Point(32, 9);
            iconDispatched.Name = "iconDispatched";
            iconDispatched.Size = new Size(100, 50);
            iconDispatched.SizeMode = PictureBoxSizeMode.Zoom;
            iconDispatched.TabIndex = 6;
            iconDispatched.TabStop = false;
            // 
            // lblDispatched
            // 
            lblDispatched.Anchor = AnchorStyles.Top;
            lblDispatched.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDispatched.Location = new Point(12, 89);
            lblDispatched.Name = "lblDispatched";
            lblDispatched.Size = new Size(142, 60);
            lblDispatched.TabIndex = 5;
            lblDispatched.Text = "40";
            lblDispatched.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDispatchedTitle
            // 
            lblDispatchedTitle.AutoSize = true;
            lblDispatchedTitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDispatchedTitle.Location = new Point(2, 67);
            lblDispatchedTitle.Name = "lblDispatchedTitle";
            lblDispatchedTitle.Size = new Size(166, 24);
            lblDispatchedTitle.TabIndex = 5;
            lblDispatchedTitle.Text = "Dispatched Today";
            lblDispatchedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Staff_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDispatched);
            Controls.Add(pnlReceived);
            Controls.Add(label12);
            Controls.Add(pnlStatus);
            Controls.Add(label7);
            Controls.Add(pnlTotalProduct);
            Controls.Add(label6);
            Controls.Add(btnLogout);
            Controls.Add(btnAccount);
            Controls.Add(btnStock);
            Controls.Add(btnViewProducts);
            Controls.Add(lblUserName);
            Controls.Add(lblTime);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Staff_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Staff Dashboard";
            Load += Staff_Dashboard_Load;
            pnlTotalProduct.ResumeLayout(false);
            pnlTotalProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalProducts).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatus).EndInit();
            pnlReceived.ResumeLayout(false);
            pnlReceived.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconReceived).EndInit();
            pnlDispatched.ResumeLayout(false);
            pnlDispatched.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconDispatched).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private Button btnViewProducts;
        private Button btnStock;
        private Button btnAccount;
        private Button btnLogout;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Label lblUserName;
        private Panel pnlTotalProduct;
        private Label lblTotalProductsTitle;
        private Label lblTotalProducts;
        private Label label6;
        private Panel pnlStatus;
        private Label lblStatus;
        private Label lblStatusTitle;
        private Label label7;
        private Panel pnlReceived;
        private Label lblReceived;
        private Label lblReceivedTitle;
        private Label label12;
        private Panel pnlDispatched;
        private Label lblDispatched;
        private Label lblDispatchedTitle;
        private PictureBox iconTotalProducts;
        private PictureBox iconStatus;
        private PictureBox iconReceived;
        private PictureBox iconDispatched;
    }
}