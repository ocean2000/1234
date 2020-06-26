using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.data;
using WindowsFormsApp5.dataClass;

namespace WindowsFormsApp5
{
    public partial class fAdmin : Form
    {
        public Account loginAccount;

        private static ErrorProvider err = new ErrorProvider();

        BindingSource ListItem = new BindingSource(); // binding item

        BindingSource ListAccount = new BindingSource(); // binding account

        BindingSource ListBill = new BindingSource(); // binding bill

        public fAdmin()
        {
            InitializeComponent();
            
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            dtgvItem.DataSource = ListItem;
            dtgvAccount.DataSource = ListAccount;
            dtgvBill.DataSource = ListBill;

            LoadListItem(); // load data vào dtgv bằng Bindding
            LoadListAccount();

            loadCbAccount(); // load comboBox của acc và item lên
            loadCbItem();
            LoadDate(); // load ngày tháng
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value); // xem Bill tháng này

            ItemBidding(); // Bindding
            AccountBindding();
            BillInfoBinding();
            SetToolTip();

            btnAddItem.Visible = false;
            btnCancel.Visible = false;

            btnAddAccount.Visible = false;
            btnEditAccount.Visible = false;
            checkbType.Visible = false;
            txbPass.Visible = false;
            lbPassWord.Visible = false;
        }

        void SetToolTip()
        {
            // tab doanh thu
            toolTip1.SetToolTip(dtpkFrom, "Ngày bắt đầu");
            toolTip1.SetToolTip(dtpkTo, "Ngày kết thúc");
            toolTip1.SetToolTip(cbAccount, "Nhân viên cần xem");
            toolTip1.SetToolTip(cbItem, "Mã sản phẩm cần xem");
            toolTip1.SetToolTip(txbIDbillDetail, "Số hóa đơn cần xem");
            toolTip1.SetToolTip(txbMailAddressReport, "Địa chỉ Email cần gửi báo cáo đến");
            toolTip1.SetToolTip(btnBillDetail, "Xem chi tiết hóa đơn");
            toolTip1.SetToolTip(btnShowBill, "Xem theo chọn lọc");
            toolTip1.SetToolTip(btnExportReportToExcel, "Tạo File Excel báo cáo và gửi Email");

            // tab san pham
            toolTip1.SetToolTip(btnAddItem00, "Thêm sản phẩm mới");
            toolTip1.SetToolTip(btnDeleteItem, "Xóa sản phẩm này");
            toolTip1.SetToolTip(btnEditItem, "Cập nhập sản phẩm này");
            toolTip1.SetToolTip(btnShowItem, "Tải lại bảng sản phẩm");
            toolTip1.SetToolTip(txbIDItem, "Mã sản phẩm là duy nhất, không được trùng");
            toolTip1.SetToolTip(txbNameItem, "Tên sản phẩm");
            toolTip1.SetToolTip(nmTotal, "Tồn kho");
            toolTip1.SetToolTip(nmPriceItem, "Đơn giá");
            toolTip1.SetToolTip(txbSearchItem, "Tìm tên hoặc mã sản phẩm");
            toolTip1.SetToolTip(txbMailAddress, "Địa chỉ Email cần gửi báo cáo đến");
            toolTip1.SetToolTip(btnAddItem, "Thêm sản phẩm này");
            toolTip1.SetToolTip(btnCancel, "Hủy bỏ thao tác thêm sản phẩm");
            toolTip1.SetToolTip(btnExportToExcel, "Tạo File Excel báo cáo và gửi Email");


            // tab tai khoan
            toolTip1.SetToolTip(btnAddAccount1, "Tạo tài khoản mới");
            toolTip1.SetToolTip(btnAddAccount, "Xác nhận thêm tài khoản này");
            toolTip1.SetToolTip(btnDeleteAccount, "Xóa tài khoản đang chọn");
            toolTip1.SetToolTip(btnEditAccount1, "Cập nhật tài khoản đang chọn");
            toolTip1.SetToolTip(btnEditAccount, "Xác nhận cập nhật tài khoản này");
            toolTip1.SetToolTip(btnShowAccount, "Tải lại trang");
            toolTip1.SetToolTip(txbUserName, "Tên dùng để đăng nhập");
            toolTip1.SetToolTip(txbDisplayName, "Tên dùng để hiển thị");
            toolTip1.SetToolTip(txbPass, "Mật khẩu");
            toolTip1.SetToolTip(txbTypeAcc, "Loại tài khoản");
            toolTip1.SetToolTip(checkbType, "Chọn để phân quyền Quản lý");
        }

        void LoadDate()
        {
            DateTime today = DateTime.Now;
            dtpkFrom.Value = new DateTime(today.Year, today.Month, 1);
            //dtpkTo.Value = new DateTime(today.Year, today.Month, today.Day + 1); //xem trong ngay hom nay
            dtpkTo.Value = dtpkFrom.Value.AddMonths(1).AddDays(-1); // xem trong thang nay
        }

        void loadCbAccount()
        {
            List<string> listacc = new List<string>();
            // add tất cả vào trước chuỗi
            listacc.Add("Tất cả");
            DataTable listAccount = AccountDAO.Instance.getListAccount();

            foreach (DataRow item in listAccount.Rows)
            {
                // mỗi user add vào list string
                listacc.Add(item["USERNAME"].ToString());
            }
            // comboBox = list string chứ ko = list obj
            cbAccount.DataSource = listacc;
        }

        void loadCbItem()
        {
            //IEnumerable<Item> items = null;
            //HttpClient client = new HttpClient();
            //// client.Timeout = TimeSpan.FromMinutes(10);
            //client.BaseAddress = new Uri("https://localhost:44358/");

            //var response = client.GetAsync("api/Item");
            //response.Wait();
            //var readdata = response.Result;
            //if (readdata.IsSuccessStatusCode)
            //{
            //    var display = readdata.Content.ReadAsAsync<IList<Item>>();
            //    display.Wait();
            //    items = display.Result;
            //    dtgvItem.DataSource = items;
            //}
            List<string> listIdItem = new List<string>();
            // add tất cả vào trước chuỗi
            listIdItem.Add("Tất cả");
            DataTable listId = ItemDAO.Instance.GetListItem();

            foreach (DataRow item in listId.Rows)
            {
                // mỗi item add vào list string
                listIdItem.Add(item["IDITEM"].ToString());
            }
            // comboBox = list string chứ ko = list obj
            cbItem.DataSource = listIdItem;
        }
        
        void LoadListBillByDate(DateTime from, DateTime to)
        {
            float tong = 0;
            string account = cbAccount.Text;
            string iditem = cbItem.Text;
            
            DataTable data = BillDAO.Instance.GetBillListByDate(from, to, account, iditem);

            foreach(DataRow item in data.Rows)
            {
                tong += (float)Convert.ToDouble(item["DOANH THU"].ToString());
            }
            try
            {
                lbTotalBill.Text = Convert.ToInt32(tong).ToString();
                // vẫn phải dùng float rồi convert qua int, vì đôi khi người dùng là
                // doanh nghiệp lớn thì số tiền kiểu float là có thể xảy ra
                // lúc đó ko cần chỉnh sửa ở csdl chỉ chỉnh sửa 1 ít ở phần này để đưa về float
            }
            catch
            {
                MessageBox.Show("Tổng doanh thu bị lỗi!");
                lbTotalBill.Text = tong.ToString();
            }

            ListBill.DataSource = data;
        }

        void LoadDetailBill(int idbill)
        {
            float tong = 0;
            DataTable data = BillDAO.Instance.GetBillDetail(idbill);

            foreach (DataRow item in data.Rows)
            {
                tong += (float)Convert.ToDouble(item["TỔNG CỘNG"].ToString());
            }
            try
            {
                lbTotalBill.Text = Convert.ToInt32(tong).ToString();
                // vẫn phải dùng float rồi convert qua int, vì đôi khi người dùng là
                // doanh nghiệp lớn thì số tiền kiểu float là có thể xảy ra
                // lúc đó ko cần chỉnh sửa ở sever chỉ chỉnh sửa 1 ít ở phần client để đưa về float
            }
            catch
            {
                MessageBox.Show("Tổng doanh thu bị lỗi!");
                lbTotalBill.Text = tong.ToString();
            }
            ListBill.DataSource = data;
        }

        void LoadListAccount()
        {
            DataTable data = AccountDAO.Instance.getListAccount();
            data.Columns.Add("Loại tài khoản", typeof(string)); // thêm cột loại tài khoản
            foreach(DataRow item in data.Rows)
            {
                if ((int)item["TYPE"] == 1) // chỉnh sửa hiển thị loại tài khoản sao cho trực quan hơn
                    item["Loại tài khoản"] = "Quản lý";
                else
                    item["Loại tài khoản"] = "Nhân viên";
            }
            ListAccount.DataSource = data; // gán list Account load đc vào cho Bindding

            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[1].HeaderText = "Tên hiển thị";
            dtgvAccount.Columns[2].Visible = false; // ẩn cột loại tài khoản ban đầu có hiển thị là 0 hoặc 1
            
        }

        void LoadListItem()
        {
            ListItem.DataSource = ItemDAO.Instance.getItem(); // gán list Item load đc vào cho Bindding

            dtgvItem.Columns[0].HeaderText = "Mã hàng"; // chỉnh sửa dtgv vì nó đã đc Bindding
            dtgvItem.Columns[1].HeaderText = "Tên hàng";
            dtgvItem.Columns[2].HeaderText = "Số lượng";
            dtgvItem.Columns[3].HeaderText = "Đơn giá";
        }

        void ItemBidding()
        {
            txbIDItem.DataBindings.Add("text", dtgvItem.DataSource, "id", true, DataSourceUpdateMode.Never); // true là cho phép ép kiểu đúng format 2 chiều
            txbNameItem.DataBindings.Add("text", dtgvItem.DataSource, "name", true, DataSourceUpdateMode.Never);// Never là khi chỉnh sửa 1 bên thì ko cho bidding ngay lúc đó
            nmTotal.DataBindings.Add("text", dtgvItem.DataSource, "total", true, DataSourceUpdateMode.Never); // mục đích ko cho chuyển ngược từ txb về dtgv
            nmPriceItem.DataBindings.Add("text", dtgvItem.DataSource, "price", true, DataSourceUpdateMode.Never);
        }

        void BillInfoBinding()
        {
            txbIDbillDetail.DataBindings.Add("text", dtgvBill.DataSource, "SỐ HÓA ĐƠN", true, DataSourceUpdateMode.Never);
        }

        void AccountBindding()
        {
            txbUserName.DataBindings.Add("TEXT", dtgvAccount.DataSource, "USERNAME", true, DataSourceUpdateMode.Never);
            txbDisplayName.DataBindings.Add("TEXT", dtgvAccount.DataSource, "DISPLAYNAME", true, DataSourceUpdateMode.Never);
            txbTypeAcc.DataBindings.Add("TEXT", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            
        }

        int InsertAccount(string username, string displayname, string pass, int type)
        {
            string a = username.ToLower();
            if(a == "admin")
            {
                err.Clear();
                MessageBox.Show("Thêm tài khoản không thành công!\nVui lòng chọn Tài khoản khác Admin.");
                err.SetError(txbUserName, "Tên đăng nhập phải khác Admin");
                txbUserName.Focus();
                return 0;

            }
            if(AccountDAO.Instance.IsExistAcc(username) > 0)
            {
                err.Clear();
                err.SetError(txbUserName, "Tên đăng nhập đã tồn tại, hãy chọn tên đăng nhập khác");
                txbUserName.Focus();
                return 0;
            }
            try
            {
                if (AccountDAO.Instance.InsertAccount(username, displayname, pass, type) > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadListAccount();
                    return 1;
                }
                else
                    return 0;
            }
            catch
            {
                MessageBox.Show("Tài khoản đã tồn tại hoặc dữ liệu không đúng, vui lòng kiểm tra lại.");
                return 0;
            }
            
        }

        void UpdateAccount(string username, int type)
        {

            if (AccountDAO.Instance.UpdateAccount(username, type) > 0)
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                LoadListAccount();
            }
            else
                MessageBox.Show("Cập nhật tài khoản không thành công!");
        }

        void DeleteAccount(string fromUsername, string toUsername)
        {
            if (AccountDAO.Instance.DeleteAccount(fromUsername, toUsername) > 0)
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListAccount();
            }
            else
                MessageBox.Show("Xóa tài khoản không thành công!");
        }

        bool IsUnicode(string input)
        {
            var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
            var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
            return asciiBytesCount != unicodBytesCount;
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            LoadListItem();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string id = txbIDItem.Text;
            string name = txbNameItem.Text;
            int total = (int)nmTotal.Value;
            float price = (float)nmPriceItem.Value;

            if (ErrCheck(err, txbIDItem, "Mã sản phẩm không thể trống"))
            {
                txbIDItem.Focus();
                return;
            }

            if (ItemDAO.Instance.isExistIdItem(id))
            {
                err.Clear();
                MessageBox.Show("Mã sản phẩm này đã tồn tại, hãy chọn mã khác!");
                txbIDItem.Focus();
                err.SetError(txbIDItem, "Mã sản phẩm này đã tồn tại");
                return;
            }

            if (ErrCheck(err, txbNameItem, "Tên sản phẩm không thể trống"))
            {
                txbNameItem.Focus();
                return;
            }

            
            try
            {
                if (ItemDAO.Instance.InsertItem(id, name, total, price) > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadListItem();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công, vui lòng xem lại dữ liệu.");
                }
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm không thành công! Vui lòng xem lại Mã hàng đã tồn tại hoặc các dữ liệu còn lại.");
            }

            err.Clear();
            btnAddItem00.Enabled = true;
            btnAddItem.Visible = false;
            btnCancel.Visible = false;
            txbIDItem.ReadOnly = true;
            btnDeleteItem.Enabled = true;
            btnEditItem.Enabled = true;
            btnShowItem.Enabled = true;
            LoadListItem();
        }

        private void btnAddItem00_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnCancel.Visible = true;
            btnAddItem00.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEditItem.Enabled = false;
            btnShowItem.Enabled = false;

            txbIDItem.ReadOnly = false;
            txbIDItem.Text = "";
            txbNameItem.Text = "";
            nmTotal.Value = 0;
            nmPriceItem.Value = 0;
            //nmPriceItem.DecimalPlaces = 2;
            // chỉnh sửa để cho ng dùng dùng float cho đơn giá
        }

        bool ErrCheck(ErrorProvider err, TextBox txb, string errSTR)
        {
            err.Clear();
            if(txb.Text.Length < 1)
            {
                err.SetError(txb, errSTR);
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string id = txbIDItem.Text;

            if (MessageBox.Show("Bạn có chắc muốn XÓA mã hàng " + id + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if ((ItemDAO.Instance.DeleteItem(id)) > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        LoadListItem();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công, vui lòng xem lại dữ liệu.");
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa sản phẩm không thành công! Vui lòng xem các dữ liệu.");
                }
            }
        }
        
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            string id = txbIDItem.Text;
            string name = txbNameItem.Text;
            int total = (int)nmTotal.Value;
            float price = (float)nmPriceItem.Value;
            if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa mã hàng " + id + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (ItemDAO.Instance.UpdateItem(id, name, total, price) > 0)
                    {
                        MessageBox.Show("Chỉnh sửa sản phẩm thành công!");
                        LoadListItem();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa sản phẩm không thành công, vui lòng xem lại dữ liệu.");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm sản phẩm không thành công! Vui lòng xem các dữ liệu.");
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            //saveFileDialog1 là đối tượng bên Design
            // địa chỉ mặc định ban đầu
            saveFileDialog1.InitialDirectory = "C:";
            //title cửa sổ
            saveFileDialog1.Title = "Save as Excel file";
            //fileName ban đầu NULL
            saveFileDialog1.FileName = "";
            // lọc định dạng
            saveFileDialog1.Filter = "Định dạng 1 (*.xlsx)|*.xlsx|Định dạng 2 (*.xls)|*.xls";

            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // khới tạo
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // định dạng hàng cột
                excelApp.Columns.ColumnWidth = 18;
                // ghi header của column dtgv vào trước
                for(int i = 1; i < dtgvItem.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dtgvItem.Columns[i - 1].HeaderText;
                }
                // ghi từng row từ trái sang
                for (int i = 0; i < dtgvItem.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvItem.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dtgvItem.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save file
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();

                if (MessageBox.Show("Bạn có muốn gửi Email kèm báo cáo này tới địa chỉ Email "+ txbMailAddress.Text +"?", "Hỏi thăm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SendMail(saveFileDialog1.FileName.ToString(), txbMailAddress.Text);
                }
            }
        }


        void SendMail(string fileLocation, string mailAddress)
        {
            try
            {
                // khởi tạo
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                // cài đặt
                mail.From = new MailAddress("email@gmail.com");
                // gửi tới...
                mail.To.Add(mailAddress);
                mail.Subject = "Báo Cáo Kinh Doanh";
                mail.Body = "Báo cáo (tệp đính kèm).";

                // thêm vào tệp đính kèm của mail
                if (File.Exists(@fileLocation)) // nếu tồn tại file này...
                    mail.Attachments.Add(new Attachment(@fileLocation));

                // cài đặt giao thức

                SmtpServer.Port = 587;
                // gửi từ...
                SmtpServer.Credentials = new System.Net.NetworkCredential("dungnnq2@gmail.com", "0147258Aa");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Đã gửi mail!");
            }
            catch
            {
                MessageBox.Show("Lỗi gửi mail!");
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            btnAddAccount1.Enabled = true;
            btnEditAccount1.Enabled = true;

            btnAddAccount.Visible = false;
            btnEditAccount.Visible = false;
            

            txbUserName.ReadOnly = true;
            txbDisplayName.ReadOnly = true;
            txbPass.Text = "";
            txbPass.ReadOnly = true;
            txbPass.Visible = false;
            txbTypeAcc.Visible = true;
            checkbType.Visible = false;
            btnDeleteAccount.Enabled = true;
            btnEditAccount1.Enabled = true;
            lbPassWord.Visible = false;

            err.Clear();
            LoadListAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string displayname = txbDisplayName.Text;
            string pass = txbPass.Text;
            int type = 0;
            if (checkbType.Checked)
                type = 1;

            if (ErrCheck(err, txbUserName, "Tên đăng nhập không thể trống"))
            {
                txbUserName.Focus();
                return;
            }

            if(IsUnicode(username))
            {
                err.Clear();
                err.SetError(txbUserName, "Tên đăng nhập không được chứa ký tự có dấu hoặc ký tự đặc biệt");
                txbUserName.Focus();
                return;
            }
            if (ErrCheck(err, txbPass, "Mật khẩu không thể trống"))
            {
                txbPass.Focus();
                return;
            }
            if (IsUnicode(pass))
            {
                err.Clear();
                err.SetError(txbPass, "Mật khẩu không được chứa ký tự có dấu hoặc ký tự đặc biệt");
                txbPass.Focus();
                return;
            }
            if (InsertAccount(username, displayname, pass, type) == 0)
                return;

            btnAddAccount1.Enabled = true;
            btnAddAccount.Visible = false;

            txbUserName.ReadOnly = true;
            txbDisplayName.ReadOnly = true;
            txbPass.Text = "";
            txbPass.ReadOnly = true;
            txbPass.Visible = false;
            txbTypeAcc.Visible = true;
            checkbType.Visible = false;
            btnDeleteAccount.Enabled = true;
            btnEditAccount1.Enabled = true;
            lbPassWord.Visible = false;

            err.Clear();
            LoadListAccount();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string fromUsername = txbUserName.Text;
            if(fromUsername.ToLower() == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin!");
                return;
            }
            if(loginAccount.Username == fromUsername)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!");
                return;
            }
            string toUsername = "admin";
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản "+ fromUsername+ "?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteAccount(fromUsername, toUsername);
                LoadListAccount();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            int type = 0;
            if(checkbType.Checked)
            {
                type = 1;
            }

            UpdateAccount(username,type);
            LoadListAccount();

            btnEditAccount1.Enabled = true;
            btnEditAccount.Visible = false;

            txbTypeAcc.Visible = true;
            checkbType.Visible = false;
            btnAddAccount1.Enabled = true;
            btnDeleteAccount.Enabled = true;
        }

        private void btnAddAccount1_Click(object sender, EventArgs e)
        {
            btnAddAccount1.Enabled = false;
            btnAddAccount.Visible = true;

            txbUserName.Text = "";
            txbDisplayName.Text = "";

            txbUserName.ReadOnly = false;
            txbDisplayName.ReadOnly = false;
            txbPass.Visible = true;
            txbPass.ReadOnly = false;
            txbTypeAcc.Visible = false;
            checkbType.Visible = true;
            btnDeleteAccount.Enabled = false;
            btnEditAccount1.Enabled = false;
            lbPassWord.Visible = true;
        }

        private void btnEditAccount1_Click(object sender, EventArgs e)
        {
            btnEditAccount1.Enabled = false;
            btnEditAccount.Visible = true;

            txbTypeAcc.Visible = false;
            checkbType.Visible = true;
            btnAddAccount1.Enabled = false;
            btnDeleteAccount.Enabled = false;
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDetailBill(Convert.ToInt32(txbIDbillDetail.Text));
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddItem00.Enabled = true;
            btnAddItem.Visible = false;
            btnCancel.Visible = false;
            txbIDItem.ReadOnly = true;
            btnDeleteItem.Enabled = true;
            btnEditItem.Enabled = true;
            btnShowItem.Enabled = true;
            LoadListItem();
        }

        private void btnExportReportToExcel_Click(object sender, EventArgs e)
        {
            //saveFileDialog1 là đối tượng bên Design
            // địa chỉ mặc định ban đầu
            saveFileDialog1.InitialDirectory = "C:";
            //title cửa sổ
            saveFileDialog1.Title = "Save as Excel file";
            //fileName ban đầu NULL
            saveFileDialog1.FileName = "";
            // lọc định dạng
            saveFileDialog1.Filter = "Định dạng 1 (*.xlsx)|*.xlsx|Định dạng 2 (*.xls)|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // khới tạo
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // định dạng hàng cột
                excelApp.Columns.ColumnWidth = 18;
                // ghi header của column dtgv vào trước
                for (int i = 1; i < dtgvBill.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dtgvBill.Columns[i - 1].HeaderText;
                }
                // ghi từng row từ trái sang
                for (int i = 0; i < dtgvBill.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgvBill.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dtgvBill.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // ghi tổng doanh thu vào hàng cuối
                excelApp.Cells[dtgvBill.Rows.Count + 4, dtgvBill.Columns.Count] = "Tổng doanh thu:";
                excelApp.Cells[dtgvBill.Rows.Count + 4, dtgvBill.Columns.Count + 1] = lbTotalBill.Text;

                // save file
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();

                if (MessageBox.Show("Bạn có muốn gửi Email kèm báo cáo này tới địa chỉ Email " + txbMailAddressReport.Text + "?", "Hỏi thăm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SendMail(saveFileDialog1.FileName.ToString(), txbMailAddressReport.Text);
                }
            }
        }

        private void txbSearchItem_TextChanged(object sender, EventArgs e)
        {
            // dùng Listitem là do đang dùng bidding với nó
            ListItem.DataSource = ItemDAO.Instance.SearchItemByName(txbSearchItem.Text);
        }
    }
}
