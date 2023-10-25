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
    public partial class frmDangKy : Form
    {
        public static TimeSpan GetTimeFromMoney(int money)
        {
            const int costPerHour = 10000;
            double hours = (double)money / costPerHour;
            return TimeSpan.FromHours(hours);
        }
     


        public frmDangKy()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {

                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;

            }
        }
       
       

        public bool Saveuser(tbMember user)
        {
            bool result = false;
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                _entity.tbMembers.Add(user);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void ClearFields()
        {
            // Xóa nội dung của các TextBox
            txtUser.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtName.Text = string.Empty;



        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                tbMember st = new tbMember();
                if (txtUser == null || txtUser.TextLength == 0 || txtpassword == null || txtpassword.TextLength == 0)
                {
                    MessageBox.Show("không được để trống tk hoặc mật khẩu ");
                    return;
                }
                else
                {
                    int money = int.Parse((txtAmount.Text));
                    if (money < 10000)
                    {
                        MessageBox.Show("số tiền phải nạp phải lớn hơn 10 nghìn đồng ");
                        return;
                    }
                    TimeSpan timeSpan = GetTimeFromMoney(money);
                    st.CurrentTime = timeSpan;
                    st.UserName = txtUser.Text;
                    st.Password = txtpassword.Text;
                    st.Phone = txtPhone.Text;
                    st.CurrentMoney = Convert.ToInt32(txtAmount.Text);







                    bool result = Saveuser(st);
                    if (result == true)
                    {
                        MessageBox.Show("Tạo tài khoản thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thấtbại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearFields();
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here, e.g., show an error message.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
            //if (txtPhone.TextLength != 10)
            //{
            //    MessageBox.Show("số điện thoại không đúng ! mời nhập lại  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            //}
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               
            }

        }



    }


    }

