namespace IWMS
{
    partial class Forgot_Password
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
            lblChangePass = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblInvalidEmail = new Label();
            lblEmailEmpty = new Label();
            lblConfPassError = new Label();
            lblShowHidePass2 = new Label();
            lblShowHidePass1 = new Label();
            lblConfPassEmpty = new Label();
            lblPassEmpty = new Label();
            txtConfirmPass = new TextBox();
            txtPass = new TextBox();
            lblConfirmPass = new Label();
            lblUserPass = new Label();
            btnChange = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Inventory and Warehouse Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblChangePass
            // 
            lblChangePass.AutoSize = true;
            lblChangePass.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChangePass.Location = new Point(158, 36);
            lblChangePass.Name = "lblChangePass";
            lblChangePass.Size = new Size(156, 24);
            lblChangePass.TabIndex = 5;
            lblChangePass.Text = "Change Password";
            lblChangePass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Trebuchet MS", 12F);
            txtEmail.Location = new Point(136, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 26);
            txtEmail.TabIndex = 32;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(134, 95);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(127, 22);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Enter Your Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvalidEmail
            // 
            lblInvalidEmail.AutoSize = true;
            lblInvalidEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvalidEmail.ForeColor = Color.Red;
            lblInvalidEmail.Location = new Point(136, 150);
            lblInvalidEmail.Name = "lblInvalidEmail";
            lblInvalidEmail.Size = new Size(102, 18);
            lblInvalidEmail.TabIndex = 34;
            lblInvalidEmail.Text = "Enter valid email!";
            lblInvalidEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailEmpty
            // 
            lblEmailEmpty.AutoSize = true;
            lblEmailEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailEmpty.ForeColor = Color.Red;
            lblEmailEmpty.Location = new Point(135, 149);
            lblEmailEmpty.Name = "lblEmailEmpty";
            lblEmailEmpty.Size = new Size(126, 18);
            lblEmailEmpty.TabIndex = 33;
            lblEmailEmpty.Text = "This field is required!";
            lblEmailEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfPassError
            // 
            lblConfPassError.AutoSize = true;
            lblConfPassError.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfPassError.ForeColor = Color.Red;
            lblConfPassError.Location = new Point(137, 326);
            lblConfPassError.Name = "lblConfPassError";
            lblConfPassError.Size = new Size(144, 18);
            lblConfPassError.TabIndex = 45;
            lblConfPassError.Text = "Password doesn't match!";
            lblConfPassError.TextAlign = ContentAlignment.MiddleCenter;
            lblConfPassError.Click += this.lblConfPassError_Click;
            // 
            // lblShowHidePass2
            // 
            lblShowHidePass2.AutoSize = true;
            lblShowHidePass2.BackColor = Color.Transparent;
            lblShowHidePass2.Cursor = Cursors.Hand;
            lblShowHidePass2.Location = new Point(346, 303);
            lblShowHidePass2.Name = "lblShowHidePass2";
            lblShowHidePass2.Size = new Size(36, 15);
            lblShowHidePass2.TabIndex = 44;
            lblShowHidePass2.Text = "Show";
            // 
            // lblShowHidePass1
            // 
            lblShowHidePass1.AutoSize = true;
            lblShowHidePass1.BackColor = Color.Transparent;
            lblShowHidePass1.Cursor = Cursors.Hand;
            lblShowHidePass1.Location = new Point(346, 215);
            lblShowHidePass1.Name = "lblShowHidePass1";
            lblShowHidePass1.Size = new Size(36, 15);
            lblShowHidePass1.TabIndex = 43;
            lblShowHidePass1.Text = "Show";
            // 
            // lblConfPassEmpty
            // 
            lblConfPassEmpty.AutoSize = true;
            lblConfPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfPassEmpty.ForeColor = Color.Red;
            lblConfPassEmpty.Location = new Point(137, 325);
            lblConfPassEmpty.Name = "lblConfPassEmpty";
            lblConfPassEmpty.Size = new Size(126, 18);
            lblConfPassEmpty.TabIndex = 40;
            lblConfPassEmpty.Text = "This field is required!";
            lblConfPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblConfPassEmpty.Click += lblConfPassEmpty_Click;
            // 
            // lblPassEmpty
            // 
            lblPassEmpty.AutoSize = true;
            lblPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassEmpty.ForeColor = Color.Red;
            lblPassEmpty.Location = new Point(136, 236);
            lblPassEmpty.Name = "lblPassEmpty";
            lblPassEmpty.Size = new Size(126, 18);
            lblPassEmpty.TabIndex = 41;
            lblPassEmpty.Text = "This field is required!";
            lblPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Trebuchet MS", 12F);
            txtConfirmPass.Location = new Point(136, 295);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(204, 26);
            txtConfirmPass.TabIndex = 39;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Trebuchet MS", 12F);
            txtPass.Location = new Point(136, 207);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(204, 26);
            txtPass.TabIndex = 38;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPass.Location = new Point(135, 270);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(148, 22);
            lblConfirmPass.TabIndex = 37;
            lblConfirmPass.Text = "Confirm Password :";
            lblConfirmPass.TextAlign = ContentAlignment.MiddleCenter;
            lblConfirmPass.Click += lblConfirmPass_Click;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(136, 182);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(155, 22);
            lblUserPass.TabIndex = 36;
            lblUserPass.Text = "Enter New Password";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.LimeGreen;
            btnChange.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(135, 376);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(101, 49);
            btnChange.TabIndex = 46;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(263, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 49);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 532);
            Controls.Add(btnCancel);
            Controls.Add(btnChange);
            Controls.Add(lblConfPassError);
            Controls.Add(lblShowHidePass2);
            Controls.Add(lblShowHidePass1);
            Controls.Add(lblConfPassEmpty);
            Controls.Add(lblPassEmpty);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPass);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblUserPass);
            Controls.Add(lblInvalidEmail);
            Controls.Add(lblEmailEmpty);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblChangePass);
            Controls.Add(lblTitle);
            Name = "Forgot_Password";
            Text = "Forgot_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblChangePass;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblInvalidEmail;
        private Label lblEmailEmpty;
        private Label lblConfPassError;
        private Label lblShowHidePass2;
        private Label lblShowHidePass1;
        private Label lblConfPassEmpty;
        private Label lblPassEmpty;
        private TextBox txtConfirmPass;
        private TextBox txtPass;
        private Label lblConfirmPass;
        private Label lblUserPass;
        private Button btnChange;
        private Button btnCancel;
    }
}