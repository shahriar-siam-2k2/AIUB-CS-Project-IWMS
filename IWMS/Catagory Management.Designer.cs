namespace IWMS
{
    partial class Catagory_Management
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
            dataGridView1 = new DataGridView();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnRegister = new Button();
            button1 = new Button();
            button2 = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(203, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(558, 332);
            dataGridView1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(149, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(283, 36);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(199, 24);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Catagory Management";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Lime;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(315, 431);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 45);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Add";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(440, 431);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 25;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(563, 431);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 26;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(337, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Catagory_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnCancel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(dataGridView1);
            Name = "Catagory_Management";
            Text = "Catagory_Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRegister;
        private Button button1;
        private Button button2;
        private Button btnCancel;
    }
}