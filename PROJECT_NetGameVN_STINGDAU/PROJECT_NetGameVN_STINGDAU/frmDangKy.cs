using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_NetGameVN_STINGDAU
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public bool Saveuser(user user)
        {
            bool result = false;
            using (quanlynetEntities _entity = new quanlynetEntities())
            {
                _entity.users.Add(user);
                _entity.SaveChanges();
                result = true;
            }
            return result;
                
         }


        private void btnRegister_Click(object sender, EventArgs e)
        {

            user st = new user() ;
            
            st.ten_dang_nhap = txtUser.Text;
            st.mat_khau = txtpassword.Text;
            st.so_dien_thoai = txtPhone.Text;
            st.ho_ten = txtName.Text;
            st.naptien = Convert.ToInt32(txtAmount.Text);
            bool result = Saveuser(st);
            if ( result == true )
            {
                MessageBox.Show("Tạo tài khoản thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thấtbại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
