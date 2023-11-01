using System;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void loadTheLoai()
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string sql = "select distinct theLoai from Sach";
            theLoaiInput.DisplayMember = "theLoai";
            theLoaiInput.DataSource = dp.executeQuery(sql);

            DataProvider.CloseConnect();
        }

        public void loadData()
        {
            DataProvider.OpenConnect();

            string sql = "select maSach as N'Mã Sách', tenSach as N'Tên Sách', theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach";
            DataProvider dp = new DataProvider();
            dtgv.DataSource = dp.executeQuery(sql);
            loadTheLoai();

            dtgv.Columns[0].Width = 97;
            dtgv.Columns[1].Width = 140;
            dtgv.Columns[4].Width = 50;

            DataProvider.CloseConnect();
        }

        private void Reset()
        {
            timKiemInput.Text = "";
            tacGiaInput.Text = "";
            maSachInput.Text = "";
            theLoaiInput.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            loadData();
            Reset();

            DataProvider.CloseConnect();
        }

        private void timBtn_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string query = "select tenSach as N'Tên Sách', theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach where tenSach like N'%" + timKiemInput.Text + "%'";
            dtgv.DataSource = dp.executeQuery(query);

            DataProvider.CloseConnect();
        }

        private void timBtnTM_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string query = "select tenSach as N'Tên Sách', theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach where maSach like N'%" + maSachInput.Text + "%'";
            dtgv.DataSource = dp.executeQuery(query);

            DataProvider.CloseConnect();
        }

        private void timBtnTG_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string query = "select tenSach as N'Tên Sách', theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach where tacGia like N'%" + tacGiaInput.Text + "%'";
            dtgv.DataSource = dp.executeQuery(query);

            DataProvider.CloseConnect();
        }

        private void timBtnTL_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string query = "select tenSach as N'Tên Sách', theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach where theLoai like N'%" + theLoaiInput.Text + "%'";
            dtgv.DataSource = dp.executeQuery(query);

            DataProvider.CloseConnect();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadData();
            Reset();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            LoginForm lgForm = new LoginForm();
            lgForm.Show();
            this.Hide();
        }
    }
}
