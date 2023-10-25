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
        public frmNapTien()
        {
            InitializeComponent();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {



            }
        }
    } 


   
}
