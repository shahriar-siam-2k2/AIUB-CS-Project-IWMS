namespace IWMS
{
    partial class Transaction
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
            txtSearch = new TextBox();
            lblSearch = new Label();
            txtDOB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(257, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Inventory and Warehouse Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.ButtonHighlight;
            lblSubtitle.Location = new Point(384, 61);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(220, 24);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Transaction Management";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Trebuchet MS", 11.25F);
            txtSearch.Location = new Point(53, 179);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 25);
            txtSearch.TabIndex = 37;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Trebuchet MS", 11.25F);
            lblSearch.ForeColor = SystemColors.ButtonFace;
            lblSearch.Location = new Point(81, 147);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(103, 20);
            lblSearch.TabIndex = 38;
            lblSearch.Text = "Transaction ID";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            lblSearch.Click += lblSearch_Click;
            // 
            // txtDOB
            // 
            txtDOB.Enabled = false;
            txtDOB.Font = new Font("Trebuchet MS", 12F);
            txtDOB.Location = new Point(53, 256);
            txtDOB.Name = "txtDOB";
            txtDOB.ReadOnly = true;
            txtDOB.Size = new Size(165, 26);
            txtDOB.TabIndex = 47;
            txtDOB.TextChanged += txtDOB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(74, 223);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 48;
            label1.Text = "Transaction Date";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(72, 303);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 50;
            label2.Text = "Product Selection";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(315, 147);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 53;
            label3.Text = "Product Selection";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(301, 179);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(159, 23);
            numericUpDown1.TabIndex = 54;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(315, 448);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 55;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(507, 448);
            button2.Name = "button2";
            button2.Size = new Size(97, 29);
            button2.TabIndex = 56;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(87, 366);
            button3.Name = "button3";
            button3.Size = new Size(97, 29);
            button3.TabIndex = 58;
            button3.Text = "Search ";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 51;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(972, 532);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDOB);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            ImeMode = ImeMode.NoControl;
            Name = "Transaction";
            Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtSearch;
        private Label lblSearch;
        private TextBox txtDOB;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}