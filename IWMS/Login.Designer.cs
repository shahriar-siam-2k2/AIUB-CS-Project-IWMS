namespace IWMS
{
    partial class Login
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
            lblUserName = new Label();
            lblUserPass = new Label();
            txtUserName = new TextBox();
            txtUserPass = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            lblUserEmpty = new Label();
            lblPassEmpty = new Label();
            lblShowHidePass = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(12, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.ControlLight;
            lblSubtitle.Location = new Point(165, 86);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(150, 27);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Member Login";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ControlLight;
            lblUserName.Location = new Point(106, 132);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 22);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPass.ForeColor = SystemColors.ControlLight;
            lblUserPass.Location = new Point(107, 214);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(81, 22);
            lblUserPass.TabIndex = 4;
            lblUserPass.Text = "Password";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(110, 157);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 29);
            txtUserName.TabIndex = 5;
            // 
            // txtUserPass
            // 
            txtUserPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserPass.Location = new Point(110, 239);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.Size = new Size(263, 29);
            txtUserPass.TabIndex = 6;
            txtUserPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(175, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(175, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(123, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUserEmpty
            // 
            lblUserEmpty.AutoSize = true;
            lblUserEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserEmpty.ForeColor = Color.Red;
            lblUserEmpty.Location = new Point(107, 187);
            lblUserEmpty.Name = "lblUserEmpty";
            lblUserEmpty.Size = new Size(126, 18);
            lblUserEmpty.TabIndex = 9;
            lblUserEmpty.Text = "This field is required!";
            lblUserEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassEmpty
            // 
            lblPassEmpty.AutoSize = true;
            lblPassEmpty.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassEmpty.ForeColor = Color.Red;
            lblPassEmpty.Location = new Point(107, 270);
            lblPassEmpty.Name = "lblPassEmpty";
            lblPassEmpty.Size = new Size(126, 18);
            lblPassEmpty.TabIndex = 10;
            lblPassEmpty.Text = "This field is required!";
            lblPassEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowHidePass
            // 
            lblShowHidePass.AutoSize = true;
            lblShowHidePass.BackColor = Color.White;
            lblShowHidePass.Cursor = Cursors.Hand;
            lblShowHidePass.Location = new Point(332, 245);
            lblShowHidePass.Name = "lblShowHidePass";
            lblShowHidePass.Size = new Size(36, 15);
            lblShowHidePass.TabIndex = 11;
            lblShowHidePass.Text = "Show";
            lblShowHidePass.Click += lblShowHidePass_Click;
            lblShowHidePass.MouseEnter += lblShowHidePass_MouseEnter;
            lblShowHidePass.MouseLeave += lblShowHidePass_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(485, 450);
            Controls.Add(lblShowHidePass);
            Controls.Add(lblPassEmpty);
            Controls.Add(lblUserEmpty);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtUserPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserPass);
            Controls.Add(lblUserName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUserName;
        private Label lblUserPass;
        private TextBox txtUserName;
        private TextBox txtUserPass;
        private Button btnLogin;
        private Button btnCancel;
        private Label lblUserEmpty;
        private Label lblPassEmpty;
        private Label lblShowHidePass;
    }
}