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

namespace WindowsFormsApp5
{
    public partial class fAccountProfile : Form
    {
        private static ErrorProvider err = new ErrorProvider();

        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount); // mỗi khi loginacc đc khởi tạo thì hàm set chạy
            }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = acc.Username;
            txbDisPlayName.Text = acc.Displayname;

        }

        bool IsUnicode(string input)
        {
            var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
            var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
            return asciiBytesCount != unicodBytesCount;
        }

        void UpdateAccount()
        {
            string displayname = txbDisPlayName.Text;
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            string reenterpass = txbReEnterPass.Text;
            string newpass = txbNewPass.Text;

            if (IsUnicode(newpass))
            {
                err.Clear();
                err.SetError(txbNewPass, "Mật khẩu mới không được chứa ký tự có dấu hoặc ký tự đặc biệt");
                txbNewPass.Focus();
                return;
            }

            if (!newpass.Equals(reenterpass)) // kiểm tra reeEnterPass ngay lúc này luôn, nên ko cần kiểm tra lại trong sql
            {
                err.Clear();
                err.SetError(txbReEnterPass, "Nhập lại mật khẩu mới không chính xác");
                txbReEnterPass.Focus();
                return;
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, password, newpass, displayname) == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if(updateAccountEvent!=null) // nếu có sự kiện có đứa đăng kí thì gửi kq về
                    {
                        updateAccountEvent(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(username)));
                        // truyền vào this và tham số thứ 2 là class Account
                        // để Subcriber lấy đc thông tin từ class Account (form 2)
                    }
                }
                else
                    MessageBox.Show("Cập nhật thất bại!\nVui lòng nhập đúng Mật khẩu hiện tại và kiểm tra lại tất cả dữ liệu.");
            }
        }

        private event EventHandler<AccountEvent> updateAccountEvent; // tạo event updateAcc
        public event EventHandler<AccountEvent> UpdateAccountEvent
        {
            add { updateAccountEvent += value; }
            remove { updateAccountEvent -= value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAccount();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại tất cả dữ liệu.");
            }
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txbUserName, "Tên dùng để đăng nhập");
            toolTip1.SetToolTip(txbDisPlayName, "Tên dùng để hiển thị");
            toolTip1.SetToolTip(txbPassWord, "Nhập mật khẩu hiện tại");
            toolTip1.SetToolTip(txbNewPass, "Mật khẩu là chuỗi kí tự KHÔNG DẤU");
            toolTip1.SetToolTip(txbReEnterPass, "Nhập lại mật khẩu mới vừa đặt");
            toolTip1.SetToolTip(btnUpdate, "Cập nhật thông tin");
            toolTip1.SetToolTip(btnExit, "Thoát");
        }
    }

    public class AccountEvent : EventArgs // tạo class AccEvent để chứa Acc mới sau khi cập nhật
    { // class này phải kế thừa từ EventArgs
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEvent( Account acc)
        {
            this.Acc = acc;
        }
    }
}
