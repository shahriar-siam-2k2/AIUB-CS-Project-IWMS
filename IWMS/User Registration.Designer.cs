namespace IWMS
{
    partial class User_Registration
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
            lblFullName = new Label();
            lblUserName = new Label();
            lblUserPass = new Label();
            lblConfirmPass = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblRole = new Label();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            txtConfirmPass = new TextBox();
            txtEmail = new TextBox();
            comboRole = new ComboBox();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            btnRegister = new Button();
            mtbPhone = new MaskedTextBox();
            rbOthers = new RadioButton();
            rTxtAddress = new RichTextBox();
            lblAddress = new Label();
            btnCancel = new Button();
            lblNameEmpty = new Label();
            lblUserEmpty = new Label();
            lblPassEmpty = new Label();
            lblConfPassEmpty = new Label();
            lblEmailEmpty = new Label();
            lblAddressEmpty = new Label();
            lblPhoneEmpty = new Label();
            lblDOBError = new Label();
            lblGenderEmpty = new Label();
            lblRoleEmpty = new Label();
            lblInvalidEmail = new Label();
            lblAge = new Label();
            lblDOBEmpty = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(32, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(177, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(154, 24);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "User Registration";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(117, 103);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(90, 22);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Full Name :";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(110, 155);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 22);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "User Name :";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserName.Click += label1_Click;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(121, 201);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(86, 22);
            lblUserPass.TabIndex = 6;
            lblUserPass.Text = "Password :";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPass.Location = new Point(59, 255);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(148, 22);
            lblConfirmPass.TabIndex = 7;
            lblConfirmPass.Text = "Confirm Password :";
            lblConfirmPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(147, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 22);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(143, 354);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 22);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone :";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(156, 597);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 22);
            lblRole.TabIndex = 10;
            lblRole.Text = "Role :";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Trebuchet MS", 12F);
            txtFullName.Location = new Point(206, 102);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(204, 26);
            txtFullName.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Trebuchet MS", 12F);
            txtUserName.Location = new Point(206, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(204, 26);
            txtUserName.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Trebuchet MS", 12F);
            txtPass.Location = new Point(206, 200);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(204, 26);
            txtPass.TabIndex = 13;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Trebuchet MS", 12F);
            txtConfirmPass.Location = new Point(206, 254);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(204, 26);
            txtConfirmPass.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Trebuchet MS", 12F);
            txtEmail.Location = new Point(206, 302);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 26);
            txtEmail.TabIndex = 15;
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Font = new Font("Trebuchet MS", 12F);
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Staff" });
            comboRole.Location = new Point(206, 596);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(121, 30);
            comboRole.TabIndex = 17;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(134, 549);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 22);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Trebuchet MS", 12F);
            rbMale.Location = new Point(226, 549);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(60, 26);
            rbMale.TabIndex = 19;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Trebuchet MS", 12F);
            rbFemale.Location = new Point(310, 549);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(79, 26);
            rbFemale.TabIndex = 20;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(93, 504);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(114, 22);
            lblDOB.TabIndex = 21;
            lblDOB.Text = "Date of Birth :";
            lblDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            dtpDOB.AllowDrop = true;
            dtpDOB.CalendarFont = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(206, 501);
            dtpDOB.MaxDate = new DateTime(2026, 4, 27, 14, 42, 27, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.RightToLeft = RightToLeft.No;
            dtpDOB.Size = new Size(200, 26);
            dtpDOB.TabIndex = 22;
            dtpDOB.Value = new DateTime(2026, 4, 27, 0, 0, 0, 0);
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(93, 659);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Register User";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // mtbPhone
            // 
            mtbPhone.Font = new Font("Trebuchet MS", 12F);
            mtbPhone.Location = new Point(206, 351);
            mtbPhone.Mask = "+88 00000000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(204, 26);
            mtbPhone.TabIndex = 24;
            // 
            // rbOthers
            // 
            rbOthers.AutoSize = true;
            rbOthers.Font = new Font("Trebuchet MS", 12F);
            rbOthers.Location = new Point(408, 549);
            rbOthers.Name = "rbOthers";
            rbOthers.Size = new Size(75, 26);
            rbOthers.TabIndex = 25;
            rbOthers.TabStop = true;
            rbOthers.Text = "Others";
            rbOthers.UseVisualStyleBackColor = true;
            // 
            // rTxtAddress
            // 
            rTxtAddress.Font = new Font("Trebuchet MS", 12F);
            rTxtAddress.Location = new Point(206, 403);
            rTxtAddress.Name = "rTxtAddress";
            rTxtAddress.Size = new Size(204, 71);
            rTxtAddress.TabIndex = 26;
            rTxtAddress.Text = "";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(130, 425);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 22);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address :";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(310, 659);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNameEmpty
            // 
            lblNameEmpty.AutoSize = true;
            lblNameEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameEmpty.ForeColor = Color.Red;
            lblNameEmpty.Location = new Point(206, 128);
            lblNameEmpty.Name = "lblNameEmpty";
            lblNameEmpty.Size = new Size(126, 18);
            lblNameEmpty.TabIndex = 29;
            lblNameEmpty.Text = "This field is required!";
            lblNameEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserEmpty
            // 
            lblUserEmpty.AutoSize = true;
            lblUserEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserEmpty.ForeColor = Color.Red;
            lblUserEmpty.Location = new Point(206, 180);
            lblUserEmpty.Name = "lblUserEmpty";
            lblUserEmpty.Size = new Size(126, 18);
            lblUserEmpty.TabIndex = 29;
            lblUserEmpty.Text = "This field is required!";
            lblUserEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassEmpty
            // 
            lblPassEmpty.AutoSize = true;
            lblPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassEmpty.ForeColor = Color.Red;
            lblPassEmpty.Location = new Point(206, 226);
            lblPassEmpty.Name = "lblPassEmpty";
            lblPassEmpty.Size = new Size(126, 18);
            lblPassEmpty.TabIndex = 29;
            lblPassEmpty.Text = "This field is required!";
            lblPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfPassEmpty
            // 
            lblConfPassEmpty.AutoSize = true;
            lblConfPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfPassEmpty.ForeColor = Color.Red;
            lblConfPassEmpty.Location = new Point(206, 280);
            lblConfPassEmpty.Name = "lblConfPassEmpty";
            lblConfPassEmpty.Size = new Size(126, 18);
            lblConfPassEmpty.TabIndex = 29;
            lblConfPassEmpty.Text = "This field is required!";
            lblConfPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailEmpty
            // 
            lblEmailEmpty.AutoSize = true;
            lblEmailEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailEmpty.ForeColor = Color.Red;
            lblEmailEmpty.Location = new Point(205, 329);
            lblEmailEmpty.Name = "lblEmailEmpty";
            lblEmailEmpty.Size = new Size(126, 18);
            lblEmailEmpty.TabIndex = 29;
            lblEmailEmpty.Text = "This field is required!";
            lblEmailEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddressEmpty
            // 
            lblAddressEmpty.AutoSize = true;
            lblAddressEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressEmpty.ForeColor = Color.Red;
            lblAddressEmpty.Location = new Point(206, 477);
            lblAddressEmpty.Name = "lblAddressEmpty";
            lblAddressEmpty.Size = new Size(126, 18);
            lblAddressEmpty.TabIndex = 29;
            lblAddressEmpty.Text = "This field is required!";
            lblAddressEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhoneEmpty
            // 
            lblPhoneEmpty.AutoSize = true;
            lblPhoneEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneEmpty.ForeColor = Color.Red;
            lblPhoneEmpty.Location = new Point(205, 378);
            lblPhoneEmpty.Name = "lblPhoneEmpty";
            lblPhoneEmpty.Size = new Size(189, 18);
            lblPhoneEmpty.TabIndex = 29;
            lblPhoneEmpty.Text = "Phone number must be 11 digits!";
            lblPhoneEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDOBError
            // 
            lblDOBError.AutoSize = true;
            lblDOBError.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOBError.ForeColor = Color.Red;
            lblDOBError.Location = new Point(205, 529);
            lblDOBError.Name = "lblDOBError";
            lblDOBError.Size = new Size(142, 18);
            lblDOBError.TabIndex = 29;
            lblDOBError.Text = "Must be 18+ to register!";
            lblDOBError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderEmpty
            // 
            lblGenderEmpty.AutoSize = true;
            lblGenderEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenderEmpty.ForeColor = Color.Red;
            lblGenderEmpty.Location = new Point(206, 571);
            lblGenderEmpty.Name = "lblGenderEmpty";
            lblGenderEmpty.Size = new Size(100, 18);
            lblGenderEmpty.TabIndex = 29;
            lblGenderEmpty.Text = "Select a gender!";
            lblGenderEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoleEmpty
            // 
            lblRoleEmpty.AutoSize = true;
            lblRoleEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleEmpty.ForeColor = Color.Red;
            lblRoleEmpty.Location = new Point(205, 628);
            lblRoleEmpty.Name = "lblRoleEmpty";
            lblRoleEmpty.Size = new Size(83, 18);
            lblRoleEmpty.TabIndex = 29;
            lblRoleEmpty.Text = "Select a role!";
            lblRoleEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvalidEmail
            // 
            lblInvalidEmail.AutoSize = true;
            lblInvalidEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvalidEmail.ForeColor = Color.Red;
            lblInvalidEmail.Location = new Point(206, 330);
            lblInvalidEmail.Name = "lblInvalidEmail";
            lblInvalidEmail.Size = new Size(102, 18);
            lblInvalidEmail.TabIndex = 30;
            lblInvalidEmail.Text = "Enter valid email!";
            lblInvalidEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(412, 504);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(0, 22);
            lblAge.TabIndex = 31;
            lblAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDOBEmpty
            // 
            lblDOBEmpty.AutoSize = true;
            lblDOBEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOBEmpty.ForeColor = Color.Red;
            lblDOBEmpty.Location = new Point(205, 528);
            lblDOBEmpty.Name = "lblDOBEmpty";
            lblDOBEmpty.Size = new Size(122, 18);
            lblDOBEmpty.TabIndex = 32;
            lblDOBEmpty.Text = "Select date of birth!";
            lblDOBEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User_Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 736);
            Controls.Add(lblDOBEmpty);
            Controls.Add(lblAge);
            Controls.Add(lblInvalidEmail);
            Controls.Add(lblPhoneEmpty);
            Controls.Add(lblRoleEmpty);
            Controls.Add(lblGenderEmpty);
            Controls.Add(lblDOBError);
            Controls.Add(lblAddressEmpty);
            Controls.Add(lblEmailEmpty);
            Controls.Add(lblConfPassEmpty);
            Controls.Add(lblPassEmpty);
            Controls.Add(lblUserEmpty);
            Controls.Add(lblNameEmpty);
            Controls.Add(btnCancel);
            Controls.Add(lblAddress);
            Controls.Add(rTxtAddress);
            Controls.Add(rbOthers);
            Controls.Add(mtbPhone);
            Controls.Add(btnRegister);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(lblGender);
            Controls.Add(comboRole);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Controls.Add(lblRole);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblUserPass);
            Controls.Add(lblUserName);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "User_Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - User Registration";
            Load += User_Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private Label lblUserName;
        private Label lblUserPass;
        private Label lblConfirmPass;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblRole;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private TextBox txtPass;
        private TextBox txtConfirmPass;
        private TextBox txtEmail;
        private ComboBox comboRole;
        private Label lblGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Button btnRegister;
        private MaskedTextBox mtbPhone;
        private RadioButton rbOthers;
        private RichTextBox rTxtAddress;
        private Label lblAddress;
        private Button btnCancel;
        private Label lblNameEmpty;
        private Label lblUserEmpty;
        private Label lblPassEmpty;
        private Label lblConfPassEmpty;
        private Label lblEmailEmpty;
        private Label lblAddressEmpty;
        private Label lblPhoneEmpty;
        private Label lblDOBError;
        private Label lblGenderEmpty;
        private Label lblRoleEmpty;
        private Label lblInvalidEmail;
        private Label lblAge;
        private Label lblDOBEmpty;
    }
}