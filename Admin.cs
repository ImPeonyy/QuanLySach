using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void LoadTheLoai()
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string sql = "select distinct theLoai from Sach";
            theLoaiInput.DisplayMember = "theLoai";
            theLoaiInput.DataSource = dp.executeQuery(sql);

            DataProvider.CloseConnect();
        }

        public void LoadData()
        {
            DataProvider.OpenConnect();

            string sql = "select id as N'ID', maSach as N'Mã Sách', tenSach as N'Tên Sách'," +
                " theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach";
            DataProvider dp = new DataProvider();
            dtgvData.DataSource= dp.executeQuery(sql);
            LoadTheLoai();
            timKiemInput.Focus();

            dtgvData.Columns[0].Width = 30;
            dtgvData.Columns[1].Width = 82;
            dtgvData.Columns[2].Width = 140;
            dtgvData.Columns[5].Width = 50;

            DataProvider.CloseConnect();
        }

        private void Reset()
        {
            idInput.Text = "";
            tenSachInput.Text = "";
            maSachInput.Text = "";
            tacGiaInput.Text = "";
            viTriInput.Text = "";
            theLoaiInput.Text = "";
            timKiemInput.Text = "";
        }

        public void Admin_Load(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            LoadData();
            Reset();

            DataProvider.CloseConnect();
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }   

        public bool KTThongTin()
        {
            if (tenSachInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tenSachInput.Focus();
                return false;
            }

            if (maSachInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                maSachInput.Focus();
                return false;
            }

            if (tacGiaInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tác giả", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tacGiaInput.Focus();
                return false;
            }

            if (viTriInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                viTriInput.Focus();
                return false;
            }

            if (viTriInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                viTriInput.Focus();
                return false;
            }
            
            if (theLoaiInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                theLoaiInput.Focus();
                return false;
            }

            return true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if(KTThongTin())
            {
                try
                {
                    string sql = "insert into Sach (maSach, tenSach," +
                        " tacGia, theLoai, viTri) values (@ma, @ten, @tg," +
                        " @tl, @vt)";
                    string[] name = { "@ma", "@ten", "@tg", "@tl", "@vt" };
                    object[] values = { maSachInput.Text, tenSachInput.Text,
                        tacGiaInput.Text, 
                        theLoaiInput.Text, viTriInput.Text };
                    DataProvider.OpenConnect();

                    string ktViTri = "select count(*) from Sach where viTri = " +
                        "'" + viTriInput.Text + "'";
                    if (DataProvider.executeScalar(ktViTri) == 0)
                    {
                        DataProvider.UpdateData(sql, name, values);
                        LoadData();
                        Reset();
                        MessageBox.Show("Đã thêm mới sách thành công !", "Thông " +
                        "báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        {
                            MessageBox.Show("Vị trí này đã có sách !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    DataProvider.CloseConnect();
                    
                }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }    
        }

        private void TimKiemBtn_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            DataProvider dp = new DataProvider();
            string query = "select id as N'ID', maSach as N'Mã Sách', tenSach as N'Tên Sách'," +
            " theLoai as N'Thể Loại', tacGia as N'Tác Giả', viTri as N'Vị Trí' from Sach where" +
            " maSach like N'%"+ timKiemInput.Text + "%'";

            
            dtgvData.DataSource = dp.executeQuery(query);

            DataProvider.CloseConnect();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            string sql = "delete from Sach where maSach = " +
            "'"+maSachInput.Text+"' and tenSach = '"+tenSachInput.Text+"'" +
            " and viTri = '"+viTriInput.Text+"'";
            DataProvider.executeNonQuery(sql);
            LoadData();
            Reset();
            MessageBox.Show("Đã xoá sách thành công !", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataProvider.CloseConnect();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnect();

            LoadData();
            Reset();

            DataProvider.CloseConnect();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lgForm = new LoginForm();
            lgForm.Show();
            this.Hide();
        }

        private void DtgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvData.CurrentCell.RowIndex;
            idInput.Text = dtgvData.Rows[i].Cells[0].Value.ToString();
            tenSachInput.Text = dtgvData.Rows[i].Cells[2].Value.ToString();
            maSachInput.Text = dtgvData.Rows[i].Cells[1].Value.ToString();
            tacGiaInput.Text = dtgvData.Rows[i].Cells[4].Value.ToString();
            viTriInput.Text = dtgvData.Rows[i].Cells[5].Value.ToString();
            theLoaiInput.Text = dtgvData.Rows[i].Cells[3].Value.ToString();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                { 
                    string sql = "update Sach set maSach = @ma, tenSach = @ten, " +
                        "tacGia = @tg, theLoai = @tl, viTri = @vt where id = " +
                        "'"+idInput.Text+"'";

                    string[] name = { "@ma", "@ten", "@tg", "@tl", "@vt" };
                    object[] values = { maSachInput.Text, tenSachInput.Text, 
                      tacGiaInput.Text, theLoaiInput.Text, viTriInput.Text };

                    string ktViTri = "select count(*) from Sach where viTri = " +
                        "'" + viTriInput.Text + "'";

                    DataProvider.OpenConnect();

                    int i = dtgvData.CurrentCell.RowIndex;
                    string vt = dtgvData.Rows[i].Cells[5].Value.ToString();
                    if (vt == viTriInput.Text)
                    {
                        DataProvider.UpdateData(sql, name, values);
                        LoadData();
                        Reset();
                        MessageBox.Show("Đã sửa sách thành công", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        {
                            if (DataProvider.executeScalar(ktViTri) == 0)
                            {
                                DataProvider.UpdateData(sql, name, values);
                                LoadData();
                                Reset();
                                MessageBox.Show("Đã sửa sách thành công", 
                                    "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }else
                                {
                                    MessageBox.Show("Vị trí này đã có sách !",
                                        "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                    }    

                    DataProvider.CloseConnect();
                    
                }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }
    }
}
