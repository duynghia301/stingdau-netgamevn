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
using PROJECT_NetGameVN_STINGDAU.DPContext;

namespace PROJECT_NetGameVN_STINGDAU
{
    public partial class frmLogin : Form
    {
        NetGameVNEntities db = new NetGameVNEntities();

        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                                 
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                tbAdmin _user = db.tbAdmins.Where(s => s.UserName == tk && s.Password == mk).FirstOrDefault();

            if (_user != null)
            {
                if (_user.GroupUser == "Admin")
                {
                    this.Hide();
                    frmMayChu frm = new frmMayChu(_user);
                    frm.ShowDialog();
                    this.Close();

                }
                else if (_user.GroupUser == "Staff")
                {
                    this.Hide();
                    frmDichVu frm = new frmDichVu();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }

            }
      
        }


        
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
               
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

     

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += frmLogin_KeyDown;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
