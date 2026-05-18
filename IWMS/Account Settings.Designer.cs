namespace IWMS
{
    partial class Account_Settings
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtUserID = new TextBox();
            lblUserID = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblConfPassError = new Label();
            lblShowHidePass2 = new Label();
            lblShowHidePass1 = new Label();
            lblConfPassEmpty = new Label();
            lblPassEmpty = new Label();
            txtConfirmPass = new TextBox();
            txtPass = new TextBox();
            lblConfirmPass = new Label();
            lblUserPass = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            rTxtAddress = new RichTextBox();
            lblDOB = new Label();
            lblGender = new Label();
            comboRole = new ComboBox();
            lblRole = new Label();
            txtGender = new TextBox();
            txtDOB = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(133, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(299, 36);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(152, 24);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Account Settings";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("Trebuchet MS", 12F);
            txtUserID.Location = new Point(165, 98);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(204, 26);
            txtUserID.TabIndex = 13;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(89, 100);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(71, 22);
            lblUserID.TabIndex = 12;
            lblUserID.Text = "User ID :";
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Trebuchet MS", 12F);
            txtFullName.Location = new Point(165, 162);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(204, 26);
            txtFullName.TabIndex = 15;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(70, 164);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(90, 22);
            lblFullName.TabIndex = 14;
            lblFullName.Text = "Full Name :";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Trebuchet MS", 12F);
            txtUserName.Location = new Point(165, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(204, 26);
            txtUserName.TabIndex = 17;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(62, 132);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 22);
            lblUserName.TabIndex = 16;
            lblUserName.Text = "User Name :";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfPassError
            // 
            lblConfPassError.AutoSize = true;
            lblConfPassError.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfPassError.ForeColor = Color.Red;
            lblConfPassError.Location = new Point(165, 276);
            lblConfPassError.Name = "lblConfPassError";
            lblConfPassError.Size = new Size(144, 18);
            lblConfPassError.TabIndex = 44;
            lblConfPassError.Text = "Password doesn't match!";
            lblConfPassError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowHidePass2
            // 
            lblShowHidePass2.AutoSize = true;
            lblShowHidePass2.BackColor = Color.Transparent;
            lblShowHidePass2.Cursor = Cursors.Hand;
            lblShowHidePass2.Location = new Point(371, 255);
            lblShowHidePass2.Name = "lblShowHidePass2";
            lblShowHidePass2.Size = new Size(36, 15);
            lblShowHidePass2.TabIndex = 43;
            lblShowHidePass2.Text = "Show";
            // 
            // lblShowHidePass1
            // 
            lblShowHidePass1.AutoSize = true;
            lblShowHidePass1.BackColor = Color.Transparent;
            lblShowHidePass1.Cursor = Cursors.Hand;
            lblShowHidePass1.Location = new Point(371, 201);
            lblShowHidePass1.Name = "lblShowHidePass1";
            lblShowHidePass1.Size = new Size(36, 15);
            lblShowHidePass1.TabIndex = 42;
            lblShowHidePass1.Text = "Show";
            // 
            // lblConfPassEmpty
            // 
            lblConfPassEmpty.AutoSize = true;
            lblConfPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfPassEmpty.ForeColor = Color.Red;
            lblConfPassEmpty.Location = new Point(165, 275);
            lblConfPassEmpty.Name = "lblConfPassEmpty";
            lblConfPassEmpty.Size = new Size(126, 18);
            lblConfPassEmpty.TabIndex = 40;
            lblConfPassEmpty.Text = "This field is required!";
            lblConfPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassEmpty
            // 
            lblPassEmpty.AutoSize = true;
            lblPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassEmpty.ForeColor = Color.Red;
            lblPassEmpty.Location = new Point(165, 221);
            lblPassEmpty.Name = "lblPassEmpty";
            lblPassEmpty.Size = new Size(126, 18);
            lblPassEmpty.TabIndex = 41;
            lblPassEmpty.Text = "This field is required!";
            lblPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Trebuchet MS", 12F);
            txtConfirmPass.Location = new Point(165, 249);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(204, 26);
            txtConfirmPass.TabIndex = 39;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Trebuchet MS", 12F);
            txtPass.Location = new Point(165, 195);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(204, 26);
            txtPass.TabIndex = 38;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPass.Location = new Point(11, 250);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(148, 22);
            lblConfirmPass.TabIndex = 37;
            lblConfirmPass.Text = "Confirm Password :";
            lblConfirmPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(73, 196);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(86, 22);
            lblUserPass.TabIndex = 36;
            lblUserPass.Text = "Password :";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Trebuchet MS", 12F);
            txtEmail.Location = new Point(165, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(204, 26);
            txtEmail.TabIndex = 46;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(99, 296);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 22);
            lblEmail.TabIndex = 45;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(95, 333);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 22);
            lblPhone.TabIndex = 47;
            lblPhone.Text = "Phone :";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Trebuchet MS", 12F);
            txtPhone.Location = new Point(165, 333);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(204, 26);
            txtPhone.TabIndex = 46;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(439, 124);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 22);
            lblAddress.TabIndex = 49;
            lblAddress.Text = "Address :";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rTxtAddress
            // 
            rTxtAddress.Font = new Font("Trebuchet MS", 12F);
            rTxtAddress.Location = new Point(520, 100);
            rTxtAddress.Name = "rTxtAddress";
            rTxtAddress.Size = new Size(204, 71);
            rTxtAddress.TabIndex = 48;
            rTxtAddress.Text = "";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(442, 207);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(114, 22);
            lblDOB.TabIndex = 55;
            lblDOB.Text = "Date of Birth :";
            lblDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(481, 255);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 22);
            lblGender.TabIndex = 52;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Enabled = false;
            comboRole.Font = new Font("Trebuchet MS", 12F);
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Staff" });
            comboRole.Location = new Point(562, 302);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(132, 30);
            comboRole.TabIndex = 51;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(502, 305);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 22);
            lblRole.TabIndex = 50;
            lblRole.Text = "Role :";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Font = new Font("Trebuchet MS", 12F);
            txtGender.Location = new Point(562, 253);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(132, 26);
            txtGender.TabIndex = 46;
            // 
            // txtDOB
            // 
            txtDOB.Enabled = false;
            txtDOB.Font = new Font("Trebuchet MS", 12F);
            txtDOB.Location = new Point(562, 205);
            txtDOB.Name = "txtDOB";
            txtDOB.ReadOnly = true;
            txtDOB.Size = new Size(132, 26);
            txtDOB.TabIndex = 46;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Enabled = false;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(197, 389);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 56;
            btnRegister.Text = "Update";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(411, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Account_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 468);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(comboRole);
            Controls.Add(lblRole);
            Controls.Add(lblAddress);
            Controls.Add(rTxtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(txtDOB);
            Controls.Add(txtGender);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblConfPassError);
            Controls.Add(lblShowHidePass2);
            Controls.Add(lblShowHidePass1);
            Controls.Add(lblConfPassEmpty);
            Controls.Add(lblPassEmpty);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPass);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblUserPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Account_Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Account Settings";
            Load += Account_Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUserID;
        private Label lblUserID;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblConfPassError;
        private Label lblShowHidePass2;
        private Label lblShowHidePass1;
        private Label lblConfPassEmpty;
        private Label lblPassEmpty;
        private TextBox txtConfirmPass;
        private TextBox txtPass;
        private Label lblConfirmPass;
        private Label lblUserPass;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private RichTextBox rTxtAddress;
        private Label lblDOB;
        private Label lblGender;
        private ComboBox comboRole;
        private Label lblRole;
        private TextBox txtGender;
        private TextBox txtDOB;
        private Button btnRegister;
        private Button btnCancel;
    }
}