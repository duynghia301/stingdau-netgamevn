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
                tbAdmin _user = db.tbAdmins.Where(s => s.UserName == tk  && s.Password == mk).FirstOrDefault();

                if (_user != null)
                {
                    if (_user.GroupUser == "Admin")
                    {
                        frmMayChu frm = new frmMayChu(_user);
                        frm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Vui long kiem tra lai!");
                    txtTaiKhoan.Focus();
                    return;
                }



            
            


        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
