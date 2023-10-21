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


        private void btnRegister_Click(object sender, EventArgs e)
        {

            tbMember st = new tbMember();
            if (txtUser == null || txtUser.TextLength == 0 || txtpassword == null || txtpassword.TextLength ==0 )
            {
                MessageBox.Show("không được để trống tk hoặc mật khẩu ");
                return;
            }
            else
            {
                int money = int.Parse((txtAmount.Text));
                if (money <= 10000)
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
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thấtbại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

                

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }


    }

