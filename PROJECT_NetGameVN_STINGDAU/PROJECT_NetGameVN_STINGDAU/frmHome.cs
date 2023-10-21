﻿using System;
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
    public partial class frmMayChu : Form
    {
        //tạo biến kiểm tra thoát
        bool isThoat = true;

       
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

       

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMayChu_Load(object sender, EventArgs e)
        {

        }
        private void LoadSourceToDRGV()
        {
            drgvFood.Columns[0].HeaderText = "Mã Định Danh";
            drgvFood.Columns[1].HeaderText = "Tên Món Ăn";
            drgvFood.Columns[2].HeaderText = "Thuộc Loại";
            drgvFood.Columns[3].HeaderText = "Đơn Giá";
            drgvFood.Columns[4].HeaderText = "Đơn Vị Tính";
            drgvFood.Columns[5].HeaderText = "Số Lượng Tồn";

            drgvDrink.Columns[0].HeaderText = "Mã Định Danh";
            drgvDrink.Columns[1].HeaderText = "Tên Món Ăn";
            drgvDrink.Columns[2].HeaderText = "Thuộc Loại";
            drgvDrink.Columns[3].HeaderText = "Đơn Giá";
            drgvDrink.Columns[4].HeaderText = "Đơn Vị Tính";
            drgvDrink.Columns[5].HeaderText = "Số Lượng Tồn";

            drgvCard.Columns[0].HeaderText = "Mã Định Danh";
            drgvCard.Columns[1].HeaderText = "Tên Món Ăn";
            drgvCard.Columns[2].HeaderText = "Thuộc Loại";
            drgvCard.Columns[3].HeaderText = "Đơn Giá";
            drgvCard.Columns[4].HeaderText = "Đơn Vị Tính";
            drgvCard.Columns[5].HeaderText = "Số Lượng Tồn";

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
            {
                isThoat = false;
                this.Close();
                frmLogin Login = new frmLogin();
                this.Hide();
                Login.ShowDialog();
            }
            
        }
        private void frmMayChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picCalculateMoney_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.Show();
        }
    }
}