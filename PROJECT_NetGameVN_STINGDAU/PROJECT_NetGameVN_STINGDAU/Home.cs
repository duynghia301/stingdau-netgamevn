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
    public partial class frmMayChu : Form
    {
        private List<MayTinh> danhSachMayTinh;
        public frmMayChu()
        {
            InitializeComponent();
            danhSachMayTinh = new List<MayTinh>();
            dgvdanhsachmay.ColumnCount = 2;
            dgvdanhsachmay.Columns[0].Name = "Tên máy tính";

        }
        void ResizeTabs()
        {
            int numTabs = tabControl1.TabCount;

            float totLen = 0;
            using (Graphics g = CreateGraphics())
            {
                // Get total length of the text of each Tab name
                for (int i = 0; i < numTabs; i++)
                    totLen += g.MeasureString(tabControl1.TabPages[i].Text, tabControl1.Font).Width;
            }

            int newX = (int)((tabControl1.Width - totLen) / numTabs) / 2;
            tabControl1.Padding = new Point(newX, tabControl1.Padding.Y);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmomay_Click(object sender, EventArgs e)
        {

        }
        public class MayTinh
        {
            public string TenMayTinh { get; set; }
            public int SoLuongRam { get; set; }

            public MayTinh(string tenMayTinh)
            {
                TenMayTinh = tenMayTinh;
                
            }
        }
    }

    }
