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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetToolTip();
        }

        void SetToolTip()
        {
            toolTip1.SetToolTip(txbUserName, "Tên đăng nhập");
            toolTip1.SetToolTip(txbPassWord, "Mật khẩu");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;

            if (login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username);

                Form2 f = new Form2(loginAccount);
                this.Hide();

                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }

        
    }
}
