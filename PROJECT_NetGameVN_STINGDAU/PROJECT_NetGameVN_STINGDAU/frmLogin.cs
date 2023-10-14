using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_NetGameVN_STINGDAU
{
    public partial class frmLogin : Form
    {
        private object dta;

        public frmLogin()
        {
            InitializeComponent();
        }

    

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Khởi tạo lớp Sql connection
            SqlConnection conn = new SqlConnection(@"Data Source=TAI_VO_02\DUYNGHIA;Initial Catalog=QuanLyPhongNet;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from Member where AccountName= '"+tk+"' and Password = '"+mk+"'";  
                SqlCommand cmd = new SqlCommand(sql, conn); //Lớp SQL xác định các thao tác xử lý dữ liệu  2 tham số sql và cái kết nối
                SqlDataReader data= cmd.ExecuteReader();    //Lớp lấy dữ liệu  từ câu lệnh đọc kết quả
                if (data.Read()==true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmMayChu home = new frmMayChu();   //mở form máy chủ
                    home.ShowDialog();                  // hàm show from
                    this.Hide();                        // ẩn from đăng nhập
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết nối");
            }

            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
