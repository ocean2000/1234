namespace WindowsFormsApp5
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nmItem = new System.Windows.Forms.NumericUpDown();
            this.txbSearchNameItem = new System.Windows.Forms.TextBox();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvItem = new System.Windows.Forms.DataGridView();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDBill = new System.Windows.Forms.TextBox();
            this.lbDisplayname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoadItem = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnInsertBill = new System.Windows.Forms.Button();
            this.btnAddItemBill = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // nmItem
            // 
            this.nmItem.Location = new System.Drawing.Point(1179, 89);
            this.nmItem.Margin = new System.Windows.Forms.Padding(4);
            this.nmItem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmItem.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nmItem.Name = "nmItem";
            this.nmItem.Size = new System.Drawing.Size(167, 23);
            this.nmItem.TabIndex = 3;
            this.nmItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbSearchNameItem
            // 
            this.txbSearchNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchNameItem.Location = new System.Drawing.Point(1179, 140);
            this.txbSearchNameItem.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchNameItem.Multiline = true;
            this.txbSearchNameItem.Name = "txbSearchNameItem";
            this.txbSearchNameItem.Size = new System.Drawing.Size(344, 35);
            this.txbSearchNameItem.TabIndex = 5;
            this.txbSearchNameItem.TextChanged += new System.EventHandler(this.txbSearchNameItem_TextChanged);
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.GridLines = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(13, 258);
            this.listViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(790, 499);
            this.listViewBill.TabIndex = 2;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewBill_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 250;
            // 
            // dtgvItem
            // 
            this.dtgvItem.AllowUserToAddRows = false;
            this.dtgvItem.AllowUserToDeleteRows = false;
            this.dtgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItem.Location = new System.Drawing.Point(825, 258);
            this.dtgvItem.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvItem.MultiSelect = false;
            this.dtgvItem.Name = "dtgvItem";
            this.dtgvItem.ReadOnly = true;
            this.dtgvItem.RowTemplate.Height = 24;
            this.dtgvItem.Size = new System.Drawing.Size(698, 499);
            this.dtgvItem.TabIndex = 6;
            this.dtgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvItem_CellContentClick);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(131, 214);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbTotalPrice.Size = new System.Drawing.Size(194, 23);
            this.txbTotalPrice.TabIndex = 9;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền";
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(592, 214);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDiscount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(211, 23);
            this.nmDiscount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(505, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số hóa đơn";
            // 
            // txbIDBill
            // 
            this.txbIDBill.Location = new System.Drawing.Point(131, 179);
            this.txbIDBill.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDBill.Name = "txbIDBill";
            this.txbIDBill.ReadOnly = true;
            this.txbIDBill.Size = new System.Drawing.Size(194, 23);
            this.txbIDBill.TabIndex = 14;
            this.txbIDBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDisplayname
            // 
            this.lbDisplayname.AutoSize = true;
            this.lbDisplayname.BackColor = System.Drawing.Color.Transparent;
            this.lbDisplayname.Location = new System.Drawing.Point(201, 9);
            this.lbDisplayname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisplayname.Name = "lbDisplayname";
            this.lbDisplayname.Size = new System.Drawing.Size(46, 17);
            this.lbDisplayname.TabIndex = 15;
            this.lbDisplayname.Text = "label4";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Location = new System.Drawing.Point(22, 9);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(46, 17);
            this.lbUsername.TabIndex = 16;
            this.lbUsername.Text = "label5";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.Location = new System.Drawing.Point(205, 58);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(145, 46);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.BackgroundImage")));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccount.Location = new System.Drawing.Point(26, 57);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(145, 46);
            this.btnAccount.TabIndex = 18;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLoadItem
            // 
            this.btnLoadItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadItem.BackgroundImage")));
            this.btnLoadItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadItem.Location = new System.Drawing.Point(606, 117);
            this.btnLoadItem.Name = "btnLoadItem";
            this.btnLoadItem.Size = new System.Drawing.Size(167, 35);
            this.btnLoadItem.TabIndex = 19;
            this.btnLoadItem.UseVisualStyleBackColor = true;
            this.btnLoadItem.Click += new System.EventHandler(this.btnLoadItem_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.BackgroundImage")));
            this.btnDeleteBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteBill.Location = new System.Drawing.Point(846, 111);
            this.btnDeleteBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(167, 46);
            this.btnDeleteBill.TabIndex = 2;
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnInsertBill
            // 
            this.btnInsertBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertBill.BackgroundImage")));
            this.btnInsertBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertBill.Location = new System.Drawing.Point(1001, 12);
            this.btnInsertBill.Name = "btnInsertBill";
            this.btnInsertBill.Size = new System.Drawing.Size(167, 46);
            this.btnInsertBill.TabIndex = 17;
            this.btnInsertBill.UseVisualStyleBackColor = true;
            this.btnInsertBill.Click += new System.EventHandler(this.btnInsertBill_Click);
            // 
            // btnAddItemBill
            // 
            this.btnAddItemBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItemBill.BackgroundImage")));
            this.btnAddItemBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItemBill.Location = new System.Drawing.Point(930, 182);
            this.btnAddItemBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItemBill.Name = "btnAddItemBill";
            this.btnAddItemBill.Size = new System.Drawing.Size(167, 35);
            this.btnAddItemBill.TabIndex = 4;
            this.btnAddItemBill.UseVisualStyleBackColor = true;
            this.btnAddItemBill.Click += new System.EventHandler(this.btnAddItemBill_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.Location = new System.Drawing.Point(825, 57);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(167, 46);
            this.btnPay.TabIndex = 1;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txbSearchNameItem);
            this.Controls.Add(this.nmItem);
            this.Controls.Add(this.btnLoadItem);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnInsertBill);
            this.Controls.Add(this.btnAddItemBill);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDBill);
            this.Controls.Add(this.nmDiscount);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbDisplayname);
            this.Controls.Add(this.dtgvItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Button btnAddItemBill;
        private System.Windows.Forms.DataGridView dtgvItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDBill;
        private System.Windows.Forms.Label lbDisplayname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.NumericUpDown nmItem;
        private System.Windows.Forms.TextBox txbSearchNameItem;
        private System.Windows.Forms.Button btnInsertBill;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLoadItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}