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
            txtTrID = new TextBox();
            lblTrID = new Label();
            lblTrDate = new Label();
            lblSearch = new Label();
            lblPQuantity = new Label();
            nudPQuantity = new NumericUpDown();
            btnSubmit = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblUserName = new Label();
            lblRole = new Label();
            dgvProducts = new DataGridView();
            dtpTrDate = new DateTimePicker();
            lblTrType = new Label();
            comboTrType = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            dgvTransactions = new DataGridView();
            lblProducts = new Label();
            lblTransactions = new Label();
            txtPrID = new TextBox();
            lblPrID = new Label();
            txtPrName = new TextBox();
            lblPrName = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(263, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.ButtonHighlight;
            lblSubtitle.Location = new Point(426, 38);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(114, 24);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Transactions";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTrID
            // 
            txtTrID.Cursor = Cursors.No;
            txtTrID.Font = new Font("Trebuchet MS", 11.25F);
            txtTrID.Location = new Point(113, 318);
            txtTrID.Name = "txtTrID";
            txtTrID.ReadOnly = true;
            txtTrID.Size = new Size(141, 25);
            txtTrID.TabIndex = 37;
            // 
            // lblTrID
            // 
            lblTrID.AutoSize = true;
            lblTrID.Font = new Font("Trebuchet MS", 11.25F);
            lblTrID.ForeColor = SystemColors.ButtonFace;
            lblTrID.Location = new Point(107, 295);
            lblTrID.Name = "lblTrID";
            lblTrID.Size = new Size(103, 20);
            lblTrID.TabIndex = 38;
            lblTrID.Text = "Transaction ID";
            lblTrID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrDate
            // 
            lblTrDate.AutoSize = true;
            lblTrDate.Font = new Font("Trebuchet MS", 11.25F);
            lblTrDate.ForeColor = SystemColors.ButtonFace;
            lblTrDate.Location = new Point(109, 360);
            lblTrDate.Name = "lblTrDate";
            lblTrDate.Size = new Size(121, 20);
            lblTrDate.TabIndex = 48;
            lblTrDate.Text = "Transaction Date";
            lblTrDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Trebuchet MS", 11.25F);
            lblSearch.ForeColor = SystemColors.ButtonFace;
            lblSearch.Location = new Point(700, 295);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(108, 20);
            lblSearch.TabIndex = 50;
            lblSearch.Text = "Search Product";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPQuantity
            // 
            lblPQuantity.AutoSize = true;
            lblPQuantity.Font = new Font("Trebuchet MS", 11.25F);
            lblPQuantity.ForeColor = SystemColors.ButtonFace;
            lblPQuantity.Location = new Point(282, 296);
            lblPQuantity.Name = "lblPQuantity";
            lblPQuantity.Size = new Size(121, 20);
            lblPQuantity.TabIndex = 53;
            lblPQuantity.Text = "Product Quantity";
            lblPQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudPQuantity
            // 
            nudPQuantity.Location = new Point(286, 319);
            nudPQuantity.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPQuantity.Name = "nudPQuantity";
            nudPQuantity.Size = new Size(141, 23);
            nudPQuantity.TabIndex = 54;
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(316, 473);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(97, 29);
            btnSubmit.TabIndex = 55;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(426, 524);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 29);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(704, 347);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 29);
            btnSearch.TabIndex = 58;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(670, 318);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 23);
            txtSearch.TabIndex = 51;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonFace;
            lblUserName.Location = new Point(849, 16);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 20);
            lblUserName.TabIndex = 61;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRole.ForeColor = SystemColors.ButtonFace;
            lblRole.Location = new Point(849, 36);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(85, 20);
            lblRole.TabIndex = 60;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(551, 95);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(383, 187);
            dgvProducts.TabIndex = 59;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // dtpTrDate
            // 
            dtpTrDate.AllowDrop = true;
            dtpTrDate.CalendarFont = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTrDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTrDate.Format = DateTimePickerFormat.Short;
            dtpTrDate.Location = new Point(113, 386);
            dtpTrDate.MaxDate = new DateTime(2026, 4, 27, 14, 42, 27, 0);
            dtpTrDate.Name = "dtpTrDate";
            dtpTrDate.RightToLeft = RightToLeft.No;
            dtpTrDate.Size = new Size(141, 26);
            dtpTrDate.TabIndex = 73;
            dtpTrDate.Value = new DateTime(2026, 4, 27, 0, 0, 0, 0);
            // 
            // lblTrType
            // 
            lblTrType.AutoSize = true;
            lblTrType.Font = new Font("Trebuchet MS", 11.25F);
            lblTrType.ForeColor = SystemColors.ButtonFace;
            lblTrType.Location = new Point(282, 361);
            lblTrType.Name = "lblTrType";
            lblTrType.Size = new Size(120, 20);
            lblTrType.TabIndex = 74;
            lblTrType.Text = "Transaction Type";
            lblTrType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboTrType
            // 
            comboTrType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTrType.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTrType.FormattingEnabled = true;
            comboTrType.Items.AddRange(new object[] { "Stock-In", "Stock-Out" });
            comboTrType.Location = new Point(286, 384);
            comboTrType.Name = "comboTrType";
            comboTrType.Size = new Size(141, 28);
            comboTrType.TabIndex = 75;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(426, 473);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 29);
            btnClear.TabIndex = 55;
            btnClear.Text = "CLEAR ALL";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(540, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 29);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 95);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.Size = new Size(528, 187);
            dgvTransactions.TabIndex = 59;
            dgvTransactions.CellClick += dgvTransactions_CellClick;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Trebuchet MS", 11.25F);
            lblProducts.ForeColor = SystemColors.ButtonFace;
            lblProducts.Location = new Point(716, 72);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(65, 20);
            lblProducts.TabIndex = 38;
            lblProducts.Text = "Products";
            lblProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Trebuchet MS", 11.25F);
            lblTransactions.ForeColor = SystemColors.ButtonFace;
            lblTransactions.Location = new Point(211, 72);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(91, 20);
            lblTransactions.TabIndex = 38;
            lblTransactions.Text = "Transactions";
            lblTransactions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrID
            // 
            txtPrID.Cursor = Cursors.No;
            txtPrID.Font = new Font("Trebuchet MS", 11.25F);
            txtPrID.Location = new Point(587, 414);
            txtPrID.Name = "txtPrID";
            txtPrID.ReadOnly = true;
            txtPrID.Size = new Size(141, 25);
            txtPrID.TabIndex = 37;
            // 
            // lblPrID
            // 
            lblPrID.AutoSize = true;
            lblPrID.Font = new Font("Trebuchet MS", 11.25F);
            lblPrID.ForeColor = SystemColors.ButtonFace;
            lblPrID.Location = new Point(582, 391);
            lblPrID.Name = "lblPrID";
            lblPrID.Size = new Size(77, 20);
            lblPrID.TabIndex = 38;
            lblPrID.Text = "Product ID";
            lblPrID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrName
            // 
            txtPrName.Font = new Font("Trebuchet MS", 11.25F);
            txtPrName.Location = new Point(795, 414);
            txtPrName.Name = "txtPrName";
            txtPrName.ReadOnly = true;
            txtPrName.Size = new Size(141, 25);
            txtPrName.TabIndex = 37;
            // 
            // lblPrName
            // 
            lblPrName.AutoSize = true;
            lblPrName.Font = new Font("Trebuchet MS", 11.25F);
            lblPrName.ForeColor = SystemColors.ButtonFace;
            lblPrName.Location = new Point(790, 391);
            lblPrName.Name = "lblPrName";
            lblPrName.Size = new Size(103, 20);
            lblPrName.TabIndex = 38;
            lblPrName.Text = "Product Name";
            lblPrName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(946, 565);
            Controls.Add(comboTrType);
            Controls.Add(lblTrType);
            Controls.Add(dtpTrDate);
            Controls.Add(lblUserName);
            Controls.Add(lblRole);
            Controls.Add(dgvTransactions);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(nudPQuantity);
            Controls.Add(lblPQuantity);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblTrDate);
            Controls.Add(lblTransactions);
            Controls.Add(lblProducts);
            Controls.Add(lblPrName);
            Controls.Add(lblPrID);
            Controls.Add(txtPrName);
            Controls.Add(txtPrID);
            Controls.Add(lblTrID);
            Controls.Add(txtTrID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IWMS - Transactions";
            Load += Transaction_Load;
            ((System.ComponentModel.ISupportInitialize)nudPQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtTrID;
        private Label lblTrID;
        private Label lblTrDate;
        private Label lblSearch;
        private Label lblPQuantity;
        private NumericUpDown nudPQuantity;
        private Button btnSubmit;
        private Button btnCancel;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblUserName;
        private Label lblRole;
        private DataGridView dgvProducts;
        private DateTimePicker dtpTrDate;
        private Label lblTrType;
        private ComboBox comboTrType;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dgvTransactions;
        private Label lblProducts;
        private Label lblTransactions;
        private TextBox txtPrID;
        private Label lblPrID;
        private TextBox txtPrName;
        private Label lblPrName;
    }
}