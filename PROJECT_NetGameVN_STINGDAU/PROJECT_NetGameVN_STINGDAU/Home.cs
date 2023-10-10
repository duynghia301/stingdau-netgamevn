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
        public frmMayChu()
        {
            InitializeComponent();
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMayChu_Load(object sender, EventArgs e)
        {

        }
    }
}
