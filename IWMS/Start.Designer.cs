namespace IWMS
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory and Warehouse Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(176, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(176, 175);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(176, 238);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(496, 332);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Start";
            Load += Start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnClose;
    }
}
