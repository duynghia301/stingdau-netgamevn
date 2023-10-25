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
    public partial class frmNapTien : Form
    {
        public static TimeSpan GetTimeFromMoney(int money)
        {
            const int costPerHour = 10000;
            double hours = (double)money / costPerHour;
            return TimeSpan.FromHours(hours);
        }
        public frmNapTien()
        {
            InitializeComponent();
        }



        private void btnNapTien_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                tbMember st = _entity.tbMembers.FirstOrDefault(m => m.UserName == txtUserName.Text);
                if (txtUserName == null )
                {
                    MessageBox.Show("không được để trống tk  ");
                    return;
                }
                
                else
                {

             
                   
                    if (int.TryParse(txtTienNap.Text, out int money) && money >= 10000)
                    {
                        float mn = Convert.ToInt32(txtTienNap.Text);

                         st.CurrentMoney += mn;
                        
                        int moneys = (int) st.CurrentMoney;



                        TimeSpan timeSpan = GetTimeFromMoney(moneys);
                        st.CurrentTime = timeSpan;

                        _entity.SaveChanges();

                        MessageBox.Show("Nạp tiền thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Số tiền phải nạp phải lớn hơn hoặc bằng 10,000 đồng.");
                    }


                }

               







            }
        }
    } 


   
}
