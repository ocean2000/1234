namespace WindowsFormsApp5
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.btnExportReportToExcel = new System.Windows.Forms.Button();
            this.txbMailAddressReport = new System.Windows.Forms.TextBox();
            this.txbIDbillDetail = new System.Windows.Forms.TextBox();
            this.btnBillDetail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpItem = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbMailAddress = new System.Windows.Forms.TextBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnAddItem00 = new System.Windows.Forms.Button();
            this.nmTotal = new System.Windows.Forms.NumericUpDown();
            this.nmPriceItem = new System.Windows.Forms.NumericUpDown();
            this.txbNameItem = new System.Windows.Forms.TextBox();
            this.txbIDItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchItem = new System.Windows.Forms.TextBox();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dtgvItem = new System.Windows.Forms.DataGridView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.btnEditAccount1 = new System.Windows.Forms.Button();
            this.btnAddAccount1 = new System.Windows.Forms.Button();
            this.checkbType = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTypeAcc = new System.Windows.Forms.TextBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).BeginInit();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpItem);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1418, 686);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.BackColor = System.Drawing.Color.PaleGreen;
            this.tpBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpBill.Controls.Add(this.btnExportReportToExcel);
            this.tpBill.Controls.Add(this.txbMailAddressReport);
            this.tpBill.Controls.Add(this.txbIDbillDetail);
            this.tpBill.Controls.Add(this.btnBillDetail);
            this.tpBill.Controls.Add(this.label6);
            this.tpBill.Controls.Add(this.label5);
            this.tpBill.Controls.Add(this.cbItem);
            this.tpBill.Controls.Add(this.cbAccount);
            this.tpBill.Controls.Add(this.lbTotalBill);
            this.tpBill.Controls.Add(this.label8);
            this.tpBill.Controls.Add(this.btnShowBill);
            this.tpBill.Controls.Add(this.dtpkFrom);
            this.tpBill.Controls.Add(this.dtpkTo);
            this.tpBill.Controls.Add(this.dtgvBill);
            this.tpBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1410, 657);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh Thu";
            // 
            // btnExportReportToExcel
            // 
            this.btnExportReportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportReportToExcel.BackgroundImage")));
            this.btnExportReportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportReportToExcel.Location = new System.Drawing.Point(1293, 101);
            this.btnExportReportToExcel.Name = "btnExportReportToExcel";
            this.btnExportReportToExcel.Size = new System.Drawing.Size(111, 39);
            this.btnExportReportToExcel.TabIndex = 22;
            this.btnExportReportToExcel.UseVisualStyleBackColor = true;
            this.btnExportReportToExcel.Click += new System.EventHandler(this.btnExportReportToExcel_Click);
            // 
            // txbMailAddressReport
            // 
            this.txbMailAddressReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMailAddressReport.Location = new System.Drawing.Point(1008, 102);
            this.txbMailAddressReport.Multiline = true;
            this.txbMailAddressReport.Name = "txbMailAddressReport";
            this.txbMailAddressReport.Size = new System.Drawing.Size(279, 39);
            this.txbMailAddressReport.TabIndex = 21;
            this.txbMailAddressReport.Tag = "";
            this.txbMailAddressReport.Text = "Địa chỉ Email";
            // 
            // txbIDbillDetail
            // 
            this.txbIDbillDetail.Location = new System.Drawing.Point(1186, 44);
            this.txbIDbillDetail.Name = "txbIDbillDetail";
            this.txbIDbillDetail.Size = new System.Drawing.Size(100, 27);
            this.txbIDbillDetail.TabIndex = 11;
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillDetail.BackgroundImage")));
            this.btnBillDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBillDetail.Location = new System.Drawing.Point(1292, 37);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(112, 41);
            this.btnBillDetail.TabIndex = 10;
            this.btnBillDetail.UseVisualStyleBackColor = true;
            this.btnBillDetail.Click += new System.EventHandler(this.btnBillDetail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Người tạo hóa đơn";
            // 
            // cbItem
            // 
            this.cbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbItem.Location = new System.Drawing.Point(608, 71);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(225, 28);
            this.cbItem.TabIndex = 7;
            // 
            // cbAccount
            // 
            this.cbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbAccount.Location = new System.Drawing.Point(608, 17);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(225, 28);
            this.cbAccount.TabIndex = 6;
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Location = new System.Drawing.Point(180, 112);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(18, 20);
            this.lbTotalBill.TabIndex = 5;
            this.lbTotalBill.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // btnShowBill
            // 
            this.btnShowBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowBill.BackgroundImage")));
            this.btnShowBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowBill.Location = new System.Drawing.Point(879, 37);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(112, 41);
            this.btnShowBill.TabIndex = 3;
            this.btnShowBill.UseVisualStyleBackColor = true;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Location = new System.Drawing.Point(6, 15);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(345, 27);
            this.dtpkFrom.TabIndex = 2;
            // 
            // dtpkTo
            // 
            this.dtpkTo.Location = new System.Drawing.Point(6, 69);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(345, 27);
            this.dtpkTo.TabIndex = 1;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 146);
            this.dtgvBill.MultiSelect = false;
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(1410, 511);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpItem
            // 
            this.tpItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.tpItem.Controls.Add(this.label10);
            this.tpItem.Controls.Add(this.btnCancel);
            this.tpItem.Controls.Add(this.txbMailAddress);
            this.tpItem.Controls.Add(this.btnExportToExcel);
            this.tpItem.Controls.Add(this.btnAddItem00);
            this.tpItem.Controls.Add(this.nmTotal);
            this.tpItem.Controls.Add(this.nmPriceItem);
            this.tpItem.Controls.Add(this.txbNameItem);
            this.tpItem.Controls.Add(this.txbIDItem);
            this.tpItem.Controls.Add(this.label4);
            this.tpItem.Controls.Add(this.label3);
            this.tpItem.Controls.Add(this.label2);
            this.tpItem.Controls.Add(this.label1);
            this.tpItem.Controls.Add(this.txbSearchItem);
            this.tpItem.Controls.Add(this.btnShowItem);
            this.tpItem.Controls.Add(this.btnEditItem);
            this.tpItem.Controls.Add(this.btnDeleteItem);
            this.tpItem.Controls.Add(this.btnAddItem);
            this.tpItem.Controls.Add(this.dtgvItem);
            this.tpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpItem.Location = new System.Drawing.Point(4, 25);
            this.tpItem.Name = "tpItem";
            this.tpItem.Padding = new System.Windows.Forms.Padding(3);
            this.tpItem.Size = new System.Drawing.Size(1410, 657);
            this.tpItem.TabIndex = 1;
            this.tpItem.Text = "Sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tìm sản phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(789, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 36);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbMailAddress
            // 
            this.txbMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMailAddress.Location = new System.Drawing.Point(1008, 168);
            this.txbMailAddress.Multiline = true;
            this.txbMailAddress.Name = "txbMailAddress";
            this.txbMailAddress.Size = new System.Drawing.Size(279, 39);
            this.txbMailAddress.TabIndex = 19;
            this.txbMailAddress.Tag = "";
            this.txbMailAddress.Text = "Địa chỉ Email";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.BackgroundImage")));
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportToExcel.Location = new System.Drawing.Point(1293, 168);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(111, 39);
            this.btnExportToExcel.TabIndex = 18;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnAddItem00
            // 
            this.btnAddItem00.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem00.BackgroundImage")));
            this.btnAddItem00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItem00.Location = new System.Drawing.Point(6, 6);
            this.btnAddItem00.Name = "btnAddItem00";
            this.btnAddItem00.Size = new System.Drawing.Size(85, 36);
            this.btnAddItem00.TabIndex = 1;
            this.btnAddItem00.UseVisualStyleBackColor = true;
            this.btnAddItem00.Click += new System.EventHandler(this.btnAddItem00_Click);
            // 
            // nmTotal
            // 
            this.nmTotal.Location = new System.Drawing.Point(564, 101);
            this.nmTotal.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.nmTotal.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nmTotal.Name = "nmTotal";
            this.nmTotal.Size = new System.Drawing.Size(219, 27);
            this.nmTotal.TabIndex = 13;
            // 
            // nmPriceItem
            // 
            this.nmPriceItem.Location = new System.Drawing.Point(564, 146);
            this.nmPriceItem.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.nmPriceItem.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nmPriceItem.Name = "nmPriceItem";
            this.nmPriceItem.Size = new System.Drawing.Size(219, 27);
            this.nmPriceItem.TabIndex = 14;
            // 
            // txbNameItem
            // 
            this.txbNameItem.Location = new System.Drawing.Point(564, 54);
            this.txbNameItem.Name = "txbNameItem";
            this.txbNameItem.Size = new System.Drawing.Size(219, 27);
            this.txbNameItem.TabIndex = 12;
            // 
            // txbIDItem
            // 
            this.txbIDItem.Location = new System.Drawing.Point(564, 8);
            this.txbIDItem.Name = "txbIDItem";
            this.txbIDItem.ReadOnly = true;
            this.txbIDItem.Size = new System.Drawing.Size(219, 27);
            this.txbIDItem.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hàng";
            // 
            // txbSearchItem
            // 
            this.txbSearchItem.Location = new System.Drawing.Point(163, 121);
            this.txbSearchItem.Name = "txbSearchItem";
            this.txbSearchItem.Size = new System.Drawing.Size(201, 27);
            this.txbSearchItem.TabIndex = 16;
            this.txbSearchItem.TextChanged += new System.EventHandler(this.txbSearchItem_TextChanged);
            // 
            // btnShowItem
            // 
            this.btnShowItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowItem.BackgroundImage")));
            this.btnShowItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowItem.Location = new System.Drawing.Point(279, 6);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(85, 36);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.UseVisualStyleBackColor = true;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditItem.BackgroundImage")));
            this.btnEditItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditItem.Location = new System.Drawing.Point(188, 6);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(85, 36);
            this.btnEditItem.TabIndex = 3;
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.BackgroundImage")));
            this.btnDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteItem.Location = new System.Drawing.Point(97, 6);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(85, 36);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItem.Location = new System.Drawing.Point(789, 109);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(177, 51);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dtgvItem
            // 
            this.dtgvItem.AllowUserToAddRows = false;
            this.dtgvItem.AllowUserToDeleteRows = false;
            this.dtgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItem.Location = new System.Drawing.Point(0, 213);
            this.dtgvItem.MultiSelect = false;
            this.dtgvItem.Name = "dtgvItem";
            this.dtgvItem.ReadOnly = true;
            this.dtgvItem.RowTemplate.Height = 24;
            this.dtgvItem.Size = new System.Drawing.Size(1410, 448);
            this.dtgvItem.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tpAccount.Controls.Add(this.btnEditAccount1);
            this.tpAccount.Controls.Add(this.btnAddAccount1);
            this.tpAccount.Controls.Add(this.checkbType);
            this.tpAccount.Controls.Add(this.label11);
            this.tpAccount.Controls.Add(this.txbPass);
            this.tpAccount.Controls.Add(this.lbPassWord);
            this.tpAccount.Controls.Add(this.label9);
            this.tpAccount.Controls.Add(this.label7);
            this.tpAccount.Controls.Add(this.txbTypeAcc);
            this.tpAccount.Controls.Add(this.txbDisplayName);
            this.tpAccount.Controls.Add(this.txbUserName);
            this.tpAccount.Controls.Add(this.dtgvAccount);
            this.tpAccount.Controls.Add(this.btnShowAccount);
            this.tpAccount.Controls.Add(this.btnEditAccount);
            this.tpAccount.Controls.Add(this.btnDeleteAccount);
            this.tpAccount.Controls.Add(this.btnAddAccount);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1410, 657);
            this.tpAccount.TabIndex = 2;
            this.tpAccount.Text = "Tài khoản";
            // 
            // btnEditAccount1
            // 
            this.btnEditAccount1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAccount1.BackgroundImage")));
            this.btnEditAccount1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditAccount1.Location = new System.Drawing.Point(252, 48);
            this.btnEditAccount1.Name = "btnEditAccount1";
            this.btnEditAccount1.Size = new System.Drawing.Size(116, 60);
            this.btnEditAccount1.TabIndex = 25;
            this.btnEditAccount1.UseVisualStyleBackColor = true;
            this.btnEditAccount1.Click += new System.EventHandler(this.btnEditAccount1_Click);
            // 
            // btnAddAccount1
            // 
            this.btnAddAccount1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount1.BackgroundImage")));
            this.btnAddAccount1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAccount1.Location = new System.Drawing.Point(8, 48);
            this.btnAddAccount1.Name = "btnAddAccount1";
            this.btnAddAccount1.Size = new System.Drawing.Size(116, 60);
            this.btnAddAccount1.TabIndex = 24;
            this.btnAddAccount1.UseVisualStyleBackColor = true;
            this.btnAddAccount1.Click += new System.EventHandler(this.btnAddAccount1_Click);
            // 
            // checkbType
            // 
            this.checkbType.AutoSize = true;
            this.checkbType.Location = new System.Drawing.Point(266, 450);
            this.checkbType.Name = "checkbType";
            this.checkbType.Size = new System.Drawing.Size(79, 21);
            this.checkbType.TabIndex = 23;
            this.checkbType.Text = "Quản lý";
            this.checkbType.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Loại tài khoản";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(266, 383);
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.ReadOnly = true;
            this.txbPass.Size = new System.Drawing.Size(224, 31);
            this.txbPass.TabIndex = 21;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(172, 386);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(66, 17);
            this.lbPassWord.TabIndex = 20;
            this.lbPassWord.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên hiển thị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên đăng nhập";
            // 
            // txbTypeAcc
            // 
            this.txbTypeAcc.Location = new System.Drawing.Point(266, 447);
            this.txbTypeAcc.Multiline = true;
            this.txbTypeAcc.Name = "txbTypeAcc";
            this.txbTypeAcc.ReadOnly = true;
            this.txbTypeAcc.Size = new System.Drawing.Size(224, 31);
            this.txbTypeAcc.TabIndex = 17;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(266, 317);
            this.txbDisplayName.Multiline = true;
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.ReadOnly = true;
            this.txbDisplayName.Size = new System.Drawing.Size(224, 31);
            this.txbDisplayName.TabIndex = 16;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(266, 254);
            this.txbUserName.Multiline = true;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(224, 29);
            this.txbUserName.TabIndex = 15;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(714, 0);
            this.dtgvAccount.MultiSelect = false;
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(696, 657);
            this.dtgvAccount.TabIndex = 10;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAccount.BackgroundImage")));
            this.btnShowAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowAccount.Location = new System.Drawing.Point(374, 48);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(116, 60);
            this.btnShowAccount.TabIndex = 9;
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.BackgroundImage")));
            this.btnEditAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditAccount.Location = new System.Drawing.Point(541, 362);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(116, 60);
            this.btnEditAccount.TabIndex = 8;
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.BackgroundImage")));
            this.btnDeleteAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteAccount.Location = new System.Drawing.Point(130, 48);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(116, 60);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.BackgroundImage")));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAccount.Location = new System.Drawing.Point(541, 428);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(116, 60);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 710);
            this.Controls.Add(this.tcAdmin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1460, 757);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpItem.ResumeLayout(false);
            this.tpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).EndInit();
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpItem;
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TextBox txbNameItem;
        private System.Windows.Forms.TextBox txbIDItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchItem;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dtgvItem;
        private System.Windows.Forms.NumericUpDown nmPriceItem;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TextBox txbTypeAcc;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.NumericUpDown nmTotal;
        private System.Windows.Forms.Button btnAddItem00;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txbMailAddress;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.CheckBox checkbType;
        private System.Windows.Forms.Button btnAddAccount1;
        private System.Windows.Forms.Button btnEditAccount1;
        private System.Windows.Forms.TextBox txbIDbillDetail;
        private System.Windows.Forms.Button btnBillDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbMailAddressReport;
        private System.Windows.Forms.Button btnExportReportToExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
    }
}