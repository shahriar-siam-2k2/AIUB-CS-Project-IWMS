namespace IWMS
{
    partial class User_Management
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
            dgvUsers = new DataGridView();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            lblRole = new Label();
            lblUserName = new Label();
            btnRefresh = new Button();
            lblUserID = new Label();
            txtUserID = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            lblPhone = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPass = new TextBox();
            lblUserPass = new Label();
            txtUserName = new TextBox();
            lblUserNameField = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblDOB = new Label();
            lblGender = new Label();
            comboRole = new ComboBox();
            lblRoleField = new Label();
            lblAddress = new Label();
            rTxtAddress = new RichTextBox();
            comboGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(317, 69);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(471, 352);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvCatagories_CellClick;
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
            lblSubtitle.Location = new Point(328, 29);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(161, 24);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "User Management";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(317, 440);
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
            btnUpdate.Location = new Point(442, 440);
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
            btnDelete.Location = new Point(565, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 45);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(500, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(706, 29);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(85, 20);
            lblRole.TabIndex = 30;
            lblRole.Text = "Admin";
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
            btnRefresh.Location = new Point(690, 440);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 45);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Trebuchet MS", 11.25F);
            lblUserID.Location = new Point(2, 157);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(57, 20);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "User ID";
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            txtUserID.AccessibleDescription = "Category ID is Read-Only";
            txtUserID.Cursor = Cursors.No;
            txtUserID.Font = new Font("Trebuchet MS", 11.25F);
            txtUserID.Location = new Point(6, 182);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(147, 25);
            txtUserID.TabIndex = 33;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Trebuchet MS", 11.25F);
            txtSearch.Location = new Point(72, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 25);
            txtSearch.TabIndex = 36;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Trebuchet MS", 11.25F);
            lblSearch.Location = new Point(113, 51);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(88, 20);
            lblSearch.TabIndex = 35;
            lblSearch.Text = "Search User";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(72, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 31);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(167, 157);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 22);
            lblPhone.TabIndex = 62;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Trebuchet MS", 12F);
            txtPhone.Location = new Point(166, 182);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 26);
            txtPhone.TabIndex = 60;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Trebuchet MS", 12F);
            txtEmail.Location = new Point(6, 397);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(147, 26);
            txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(6, 372);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 22);
            lblEmail.TabIndex = 59;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.CharacterCasing = CharacterCasing.Upper;
            txtPass.Font = new Font("Trebuchet MS", 12F);
            txtPass.Location = new Point(6, 343);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(147, 26);
            txtPass.TabIndex = 54;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(2, 318);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(75, 22);
            lblUserPass.TabIndex = 52;
            lblUserPass.Text = "Password";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Trebuchet MS", 12F);
            txtUserName.Location = new Point(6, 235);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(147, 26);
            txtUserName.TabIndex = 51;
            // 
            // lblUserNameField
            // 
            lblUserNameField.AutoSize = true;
            lblUserNameField.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserNameField.Location = new Point(2, 210);
            lblUserNameField.Name = "lblUserNameField";
            lblUserNameField.Size = new Size(86, 22);
            lblUserNameField.TabIndex = 50;
            lblUserNameField.Text = "User Name";
            lblUserNameField.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Trebuchet MS", 12F);
            txtFullName.Location = new Point(6, 289);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(147, 26);
            txtFullName.TabIndex = 49;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(3, 264);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 22);
            lblFullName.TabIndex = 48;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(169, 319);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(103, 22);
            lblDOB.TabIndex = 70;
            lblDOB.Text = "Date of Birth";
            lblDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(171, 373);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 22);
            lblGender.TabIndex = 69;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Font = new Font("Trebuchet MS", 12F);
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Staff" });
            comboRole.Location = new Point(72, 457);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(132, 30);
            comboRole.TabIndex = 68;
            // 
            // lblRoleField
            // 
            lblRoleField.AutoSize = true;
            lblRoleField.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleField.Location = new Point(113, 432);
            lblRoleField.Name = "lblRoleField";
            lblRoleField.Size = new Size(40, 22);
            lblRoleField.TabIndex = 67;
            lblRoleField.Text = "Role";
            lblRoleField.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(169, 214);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 22);
            lblAddress.TabIndex = 66;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rTxtAddress
            // 
            rTxtAddress.Font = new Font("Trebuchet MS", 12F);
            rTxtAddress.Location = new Point(166, 237);
            rTxtAddress.Name = "rTxtAddress";
            rTxtAddress.Size = new Size(141, 78);
            rTxtAddress.TabIndex = 65;
            rTxtAddress.Text = "";
            // 
            // comboGender
            // 
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.Font = new Font("Trebuchet MS", 12F);
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboGender.Location = new Point(168, 397);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(139, 30);
            comboGender.TabIndex = 71;
            // 
            // dtpDOB
            // 
            dtpDOB.AllowDrop = true;
            dtpDOB.CalendarFont = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(166, 344);
            dtpDOB.MaxDate = new DateTime(2026, 4, 27, 14, 42, 27, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.RightToLeft = RightToLeft.No;
            dtpDOB.Size = new Size(141, 26);
            dtpDOB.TabIndex = 72;
            dtpDOB.Value = new DateTime(2026, 4, 27, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(84, 497);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 45);
            btnClear.TabIndex = 73;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnClear);
            Controls.Add(dtpDOB);
            Controls.Add(comboGender);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(comboRole);
            Controls.Add(lblRoleField);
            Controls.Add(lblAddress);
            Controls.Add(rTxtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPass);
            Controls.Add(lblUserPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserNameField);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtUserID);
            Controls.Add(btnRefresh);
            Controls.Add(lblUserName);
            Controls.Add(lblRole);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lblUserID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(dgvUsers);
            Name = "User_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - User Management";
            Load += User_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblRole;
        private Label lblUserName;
        private Button btnRefresh;
        private Label lblUserID;
        private TextBox txtUserID;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Label lblPhone;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPass;
        private Label lblUserPass;
        private TextBox txtUserName;
        private Label lblUserNameField;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblDOB;
        private Label lblGender;
        private ComboBox comboRole;
        private Label lblRoleField;
        private Label lblAddress;
        private RichTextBox rTxtAddress;
        private ComboBox comboGender;
        private DateTimePicker dtpDOB;
        private Button btnClear;
    }
}