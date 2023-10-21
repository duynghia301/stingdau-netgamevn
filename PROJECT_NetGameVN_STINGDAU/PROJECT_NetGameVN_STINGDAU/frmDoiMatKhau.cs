using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_NetGameVN_STINGDAU.DPContext;
namespace PROJECT_NetGameVN_STINGDAU
{
    public partial class frmDoiMatKhau : Form
    {
        NetGameVNEntities db = new NetGameVNEntities();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string OldPassword = txtOldPass.Text;
            string NewPassword = txtNewPass.Text;
            string ConfPass = txtConfirm.Text;

            // Tìm người dùng dựa trên tên người dùng
            tbMember user = db.tbMembers.FirstOrDefault(s => s.UserName == UserName);

            if (user != null)
            {
                if (user.Password == OldPassword)
                {
                    if (NewPassword == ConfPass)
                    {
                        // Cập nhật mật khẩu mới cho người dùng
                        user.Password = NewPassword;
                        db.SaveChanges();

                        lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                        lblShowInfor.Text = "Mật khẩu đã được thay đổi thành công!";
                        txtConfirm.Text = "";
                        txtOldPass.Text = "";
                        txtNewPass.Text = "";
                        txtOldPass.Focus();
                    }
                    else
                    {
                        lblShowConf.ForeColor = System.Drawing.Color.Red;
                        lblShowConf.Text = "Mật khẩu xác nhận không khớp!";
                        txtConfirm.Focus();
                        txtConfirm.SelectAll();
                    }
                }
                else
                {
                    lblShowOld.ForeColor = System.Drawing.Color.Red;
                    lblShowOld.Text = "Mật khẩu cũ không đúng!";
                    txtOldPass.Focus();
                    txtOldPass.SelectAll();
                }
            }
            else
            {
                lblShowUser.ForeColor = System.Drawing.Color.Red;
                lblShowUser.Text = "Tên người dùng không tồn tại!";
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose(); // Giải phóng tài nguyên DbContext khi form đóng
        }
    }
}