using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.data;
using WindowsFormsApp5.dataClass;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount.Type); // mỗi khi loginacc đc khởi tạo thì hàm set chạy, chạy luôn hàm này để set enable cho Admin
            }
        }

        public Form2(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            
        }

        void ChangeAccount(int type)
        {
            // nếu là type là 1 thì Enable = true
            btnAdmin.Enabled = type == 1;
            lbDisplayname.Text = loginAccount.Displayname;
            lbUsername.Text = loginAccount.Username; 
        }
        
        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccountEvent += F_UpdateAccountEvent; // đăng ký sự kiện updateAcc
            f.ShowDialog();
        }

        private void F_UpdateAccountEvent(object sender, AccountEvent e) // hàm thực hiện
        {
            lbDisplayname.Text = e.Acc.Displayname; // nhận về e là Acc sau khi đc cập nhật
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
            {
            fAdmin f = new fAdmin();
            f.loginAccount = loginAccount;
            f.ShowDialog();

            loadItem();
            if(btnInsertBill.Enabled == false)
                ShowBill(BillDAO.Instance.GetMaxBill());
        }

        void loadItem()
        {         
            IEnumerable<Item> items = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44358/");

            var response = client.GetAsync("api/Item");
            response.Wait();
            var readdata = response.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var display = readdata.Content.ReadAsAsync<IList<Item>>();
                display.Wait();
                items = display.Result;
                dtgvItem.DataSource = items;
            }
        }
        

        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            loadItem();
            BillDAO.Instance.insertBill(LoginAccount.Username);

            txbIDBill.Text = BillDAO.Instance.GetMaxBill().ToString();
            btnInsertBill.Enabled = false;
            btnPay.Enabled = true;
            btnDeleteBill.Enabled = true;
            btnAddItemBill.Enabled = true;

        }

        void DeleteStatus0()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDBILL FROM BILL WHERE STATUS = 0");
            foreach(DataRow item in data.Rows)
            {
                int idbill = (int)item["IDBILL"];
                BillInfoDAO.Instance.deleteBillinfo(idbill);
                BillDAO.Instance.deleteBill(idbill);
            }
        }

        private void btnAddItemBill_Click(object sender, EventArgs e)
        {
            if((int)dtgvItem.CurrentRow.Cells[2].Value >= (int)nmItem.Value)
            {
                BillInfoDAO.Instance.insertBillinfo(BillDAO.Instance.GetMaxBill(), dtgvItem.CurrentRow.Cells[0].Value.ToString(), (int)nmItem.Value);
                ShowBill(BillDAO.Instance.GetMaxBill());
                nmItem.Value = 1;
                loadItem();
            }
            else
            {
                int total = (int)dtgvItem.CurrentRow.Cells[2].Value;
                MessageBox.Show("Số lượng tồn kho không đủ!\nSố lượng còn "+total);
            }
        }
        void ShowBill(int id)
        {
            listViewBill.Items.Clear();
            List<Billinfo> listBillInfo = BillInfoDAO.Instance.getListBillInfo(id);
            float totalPrice = 0;
            foreach (Billinfo item in listBillInfo)
            {
                ListViewItem lvitem = new ListViewItem(item.IDItem.ToString());
                lvitem.SubItems.Add(ItemDAO.Instance.getNameItemById(item.IDItem).ToString());
                lvitem.SubItems.Add(item.Count1.ToString());
                lvitem.SubItems.Add(ItemDAO.Instance.getPriceItemById(item.IDItem).ToString());
                totalPrice += ItemDAO.Instance.getPriceItemById(item.IDItem) * item.Count1;
                listViewBill.Items.Add(lvitem);
            }
            txbTotalPrice.Text = totalPrice.ToString();

        }


        void Report()
        {
            try
            {
                // khới tạo
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                excelApp.DisplayAlerts = false;
                string filePath = @"E:\QLBH_Report\Report.xlsx";
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = excelApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets workSheet = xlWorkBook.Worksheets;

                // Report 3 in SQL Day

                DataTable data3 = BillDAO.Instance.Report3();

                // ghi từng row từ trái sang
                
                for (int i = 0, r = 2; i < 1; i++)
                {
                    foreach (DataRow item in data3.Rows) // save vào excel theo từng row với column = 1
                    {
                        workSheet[3].Cells[r, 1] = item[i].ToString() + "/" + item[i + 1].ToString() + "/" + item[i + 2].ToString(); // bắt đầu hàng 2 cột 1 excel, tăng lên [3,1]

                        r++;
                    }
                    r--;
                    // xoa row da ton tai truoc do
                    Microsoft.Office.Interop.Excel.Range range = workSheet[3].UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible, Type.Missing);
                    int row = range.Rows.Count;
                    while (row - r > 0)
                    {
                        Microsoft.Office.Interop.Excel.Range cells = (Microsoft.Office.Interop.Excel.Range)workSheet[3].Range["A"+ row.ToString(), Type.Missing];
                        Microsoft.Office.Interop.Excel.Range del = cells.EntireRow;
                        del.Delete();
                        row--;
                    }
                }
                // add DOANHTHU
                int n = 2;
                foreach (DataRow item in data3.Rows)
                {
                    workSheet[3].Cells[n, 2] = item[3].ToString();
                    n++;
                }

                // Report 4
                int data4 = BillDAO.Instance.Report4();

                workSheet[3].Cells[2, 3] = data4.ToString();
                
                workSheet[3].Select();
                
                // Report 1 in SQL BillInfo

                DataTable data1 = BillDAO.Instance.Report1();

                // ghi từng row từ trái sang
                for (int i = 1; i < 6; i++)
                {
                    int r = 2;
                    foreach (DataRow item in data1.Rows)
                    {
                        workSheet[2].Cells[r, i] = item[i - 1].ToString();
                        r++;
                    }
                    r--;
                    // xoa row da ton tai truoc do
                    Microsoft.Office.Interop.Excel.Range range = workSheet[2].UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible, Type.Missing);
                    int row = range.Rows.Count;
                    while (row - r > 0)
                    {
                        Microsoft.Office.Interop.Excel.Range cells = (Microsoft.Office.Interop.Excel.Range)workSheet[2].Range["A" + row.ToString(), Type.Missing];
                        Microsoft.Office.Interop.Excel.Range del = cells.EntireRow;
                        del.Delete();
                        row--;
                    }
                }
                //
                workSheet[2].Select();

                // Report 2 in SQL Bill

                DataTable data2 = BillDAO.Instance.Report2();

                // ghi từng row từ trái sang

                for (int i = 1; i < 6; i++)
                {
                    int r = 2;
                    foreach (DataRow item in data2.Rows)
                    {
                        workSheet[1].Cells[r, i] = item[i - 1].ToString();
                        r++;
                    }

                    r--;
                    // xoa row da ton tai truoc do
                    Microsoft.Office.Interop.Excel.Range range = workSheet[1].UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible, Type.Missing);
                    int row = range.Rows.Count;
                    while (row - r > 0)
                    {
                        Microsoft.Office.Interop.Excel.Range cells = (Microsoft.Office.Interop.Excel.Range)workSheet[1].Range["A" + row.ToString(), Type.Missing];
                        Microsoft.Office.Interop.Excel.Range del = cells.EntireRow;
                        del.Delete();
                        row--;
                    }

                }
                //
                workSheet[1].Select();

                xlWorkBook.Save();
                xlWorkBook.Close();

                excelApp.Quit();
                Marshal.ReleaseComObject(workSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excelApp);
                
                // thử 3 dòng này xem app đang chạy thì excel.exe có còn ko, nhưng vẫn còn khoảng 15 20s mới tắt
                // còn cũng ko ảnh hưởng gì (cho đến hiện tại) nhưng tốt nhất nên tắt sau khi dùng
                MessageBox.Show("Thanh toán thành công!");
            }
            catch
            {
                MessageBox.Show("Error: Report");
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            try
            {
                int idbill = BillDAO.Instance.GetMaxBill();
                if (MessageBox.Show(string.Format("Bạn có chắc muốn hủy hóa đơn ({0}) này?", idbill), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillInfoDAO.Instance.deleteBillinfo(idbill);
                    BillDAO.Instance.deleteBill(idbill);
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    btnDeleteBill.Enabled = false;
                    btnPay.Enabled = false;
                    btnAddItemBill.Enabled = false;
                    btnInsertBill.Enabled = true;
                    listViewBill.Items.Clear();
                    txbTotalPrice.Text = "0";
                    nmDiscount.Value = 0;
                    txbIDBill.Text = "";
                    
                }

            }
            catch
            {
                MessageBox.Show("Xóa hóa đơn thất bại!");
            }
        }

        

        private void btnPay_Click(object sender, EventArgs e)
        {
            int id = BillDAO.Instance.GetMaxBill();
            int discount = (int)nmDiscount.Value;
            double price = Convert.ToDouble(txbTotalPrice.Text);
            //double price = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0].Replace('.',','));
            double totalPrice = price - discount;

            if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn số: {0}\n Tổng tiền - Giảm giá = {1} - {2} = {3}", id, price, discount, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.PayBill(id, discount, (float)totalPrice);
                ShowBill(id);
                // bai 12

                txbIDBill.Text = "";
                nmDiscount.Value = 0;
                btnPay.Enabled = false;
                btnDeleteBill.Enabled = false;
                btnInsertBill.Enabled = true;
                btnAddItemBill.Enabled = false;
            }

            if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn số: {0}\nTổng tiền = {1}", id, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.PayBill(id, discount, (float)totalPrice);
                ShowBill(id);
                //12

                txbIDBill.Text = "";
                nmDiscount.Value = 0;
                btnPay.Enabled = false;
                btnDeleteBill.Enabled = false;
                btnInsertBill.Enabled = true;
                btnAddItemBill.Enabled = false;

                Report();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listViewBill.FullRowSelect = true;
            loadItem();
            DeleteStatus0();

            btnInsertBill.Enabled = true;
            btnPay.Enabled = false;
            btnDeleteBill.Enabled = false;
            btnAddItemBill.Enabled = false;
            SetToolTip();
        }

        void SetToolTip()
        {
            toolTip1.SetToolTip(lbDisplayname, "Tên hiển thị");
            toolTip1.SetToolTip(lbUsername, "Tên đăng nhập");
            toolTip1.SetToolTip(btnAccount, "Cập nhật thông tin tài khoản");
            toolTip1.SetToolTip(btnAdmin, "Quản lý");
            toolTip1.SetToolTip(btnInsertBill, "Tạo hóa đơn mới");
            toolTip1.SetToolTip(btnPay, "Thanh toán hóa đơn");
            toolTip1.SetToolTip(btnDeleteBill, "Hủy hóa đơn");
            toolTip1.SetToolTip(txbSearchNameItem, "Tìm tên hoặc mã sản phẩm");
            toolTip1.SetToolTip(nmItem, "Số lượng sản phẩm cần thêm vào hóa đơn");
            toolTip1.SetToolTip(btnAddItemBill, "Thêm sản phẩm vào hóa đơn");
            toolTip1.SetToolTip(btnLoadItem, "Load lại bảng sản phẩm");
        }

        private void deleteBill(int idbill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDITEM, COUNT FROM BILLINFO WHERE IDBILL = " + idbill);
            foreach (DataRow item in data.Rows)
            {
                int count = (int)item["COUNT"];
                string iditem = item["IDITEM"].ToString();
                DataProvider.Instance.ExecuteQuery("UPDATE ITEM SET TOTAL = TOTAL + WHERE IDITEM = 'K1'");
                // chọn ra iditem và count của nó để trừ vào total ở bảng ITEM dựa vào iditem
            }
        }

        private void btnLoadItem_Click(object sender, EventArgs e)
        {
            //loadItem();
            
        }

        private void listViewBill_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Xóa mã hàng "+ listViewBill.SelectedItems[0].SubItems[0].Text + "?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idbill = BillDAO.Instance.GetMaxBill();
                string iditem = listViewBill.SelectedItems[0].SubItems[0].Text;
                BillInfoDAO.Instance.deleteBillInfoByIdBillAndIdItem(idbill, iditem);
                ShowBill(idbill);
            }
        }

        private void txbSearchNameItem_TextChanged(object sender, EventArgs e)
        {
            dtgvItem.DataSource = ItemDAO.Instance.SearchItemByName(txbSearchNameItem.Text);
            dtgvItem.Columns[0].HeaderText = "Mã hàng";
            dtgvItem.Columns[1].HeaderText = "Tên hàng";
            dtgvItem.Columns[3].HeaderText = "Đơn giá";
            dtgvItem.Columns[2].Visible = false;
        }

        private void dtgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
