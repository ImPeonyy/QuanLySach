using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();
            
            string sql = "select count(*) from Admin where taiKhoan = " +
            "'"+userInput.Text+"' and matKhau = '"+passInput.Text+"'";

            if(DataProvider.executeScalar(sql) == 1) 
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
                else
                {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}

