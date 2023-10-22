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

        NetGameVNEntities db = new NetGameVNEntities();
        public frmMayChu(tbAdmin _user)
        {
            InitializeComponent();
        }

        //Máy trạm

        public void Display()
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Client> _ClientList = new List<Client>();
                _ClientList = _entity.tbClients.Select(x => new Client
                {
                    ClientName = x.ClientName,
                    GroupClientName = x.GroupClientName,
                    StatusClient = x.StatusClient,
                    Note = x.Note
                }).ToList();
                dvgList.DataSource = _ClientList;



            }
        }
        public void DisplayMember()
        {

            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Members> _MembersList = new List<Members>();
                _MembersList = _entity.tbMembers.Select(x => new Members
                {
                    MemberID = x.MemberID,
                    UserName = x.UserName,
                    Password = x.Password,
                    Phone = x.Phone,
                    GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    Birthday = x.Birthday
                }).ToList();
                dgvListTaiKhoan.DataSource = _MembersList;
            }


        }


        private void frmMayChu_Load(object sender, EventArgs e)
        {
            Display();
            DisplayMember();



            cbxTimTk.Items.Add("UserName");
            cbxTimTk.Items.Add("Phone");
            cbxTimTk.Items.Add("GroupUser");

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
            if (tb == DialogResult.OK)
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

        private void dvgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        //refrest data members
        private void RefreshData()
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Members> _MembersList = new List<Members>();
                _MembersList = _entity.tbMembers.Select(x => new Members
                {
                    MemberID = x.MemberID,
                    UserName = x.UserName,
                    Password = x.Password,
                    Phone = x.Phone,
                    GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    Birthday = x.Birthday
                }).ToList();
                dgvListTaiKhoan.DataSource = _MembersList;
            }
        }


        //refrest data Client
        private void RefreshClient()
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Client> _ClientList = new List<Client>();
                _ClientList = _entity.tbClients.Select(x => new Client
                {
                    ClientName = x.ClientName,
                    GroupClientName = x.GroupClientName,
                    StatusClient = x.StatusClient,
                    Note = x.Note
                }).ToList();
                dvgList.DataSource = _ClientList;



            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }


        public bool DeleteStudentDetails(int id)
        {
            bool result = false;
            try
            {
                using (NetGameVNEntities _entity = new NetGameVNEntities())
                {
                    tbMember _user = _entity.tbMembers.Find(id);
                    if (_user != null)
                    {
                        _entity.tbMembers.Remove(_user);
                        _entity.SaveChanges();
                        result = true;

                    }
                    else
                        result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;

        }

        public void ClearFields()
        {
            tbMember st = new tbMember();

            st.UserName = "";
            st.Password = "";
            st.Phone = "";
            st.CurrentMoney = Convert.ToInt32("");
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMember st = new tbMember();
            int idstudent = Convert.ToInt32(st.MemberID);
            bool result = DeleteStudentDetails(idstudent);
            if (result == true)
            {
                MessageBox.Show("Delete Succesfully!.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        private void tabHoiVien_Click(object sender, EventArgs e)
        {


        }

        private void dgvListTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {



        }

        public void LoadClient()
        {

            dvgList.DataSource = (from tbClient in db.tbClients select new { ClientName = tbClient.ClientName, GroupClientName = tbClient.GroupClientName, StatusClient = tbClient.StatusClient, Note = tbClient.Note }).ToArray();
        }

        private void PicOpenClientEventHandler_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                try
                {
                    
                     if (dvgList.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn máy khách từ danh sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int index = dvgList.SelectedRows[0].Index;
                   
                    // Lấy ra Client cần cập nhật trạng thái.
                    string computerName = dvgList.Rows[index].Cells["ClientName"].Value.ToString();
                    tbClient selectedClient = _entity.tbClients.SingleOrDefault(c => c.ClientName == computerName);

                    if (selectedClient.StatusClient == "DISCONNECT")
                    {
                        DialogResult tb = MessageBox.Show("Bạn có mở máy này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tb == DialogResult.OK)
                        { 
                            selectedClient.StatusClient = "USING";
                        // Lưu các thay đổi vào cơ sở dữ liệu.
                        _entity.SaveChanges();
                        LoadClient(); // Nạp lại dữ liệu sau khi đã cập nhật thành công.
                        }
                    }
                    else
                    {
                        if (selectedClient.StatusClient == "USING")
                        {
                            MessageBox.Show("Máy khách đang được sử dụng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                   
                    


                }
                catch (Exception ex)
                {
                    // Handle any exceptions here, e.g., show an error message.
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picShutdownClient_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                try
                {
                    if (dvgList.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn máy khách từ danh sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int index = dvgList.SelectedRows[0].Index;
                   
                        // Lấy ra Client cần cập nhật trạng thái.
                        string computerName = dvgList.Rows[index].Cells["ClientName"].Value.ToString();
                        tbClient selectedClient = _entity.tbClients.SingleOrDefault(c => c.ClientName == computerName);




                        if (selectedClient.StatusClient == "USING")
                        {

                            DialogResult tb = MessageBox.Show("Bạn có muốn tắt máy này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (tb == DialogResult.OK)
                            {
                                selectedClient.StatusClient = "DISCONNECT";
                                // Lưu các thay đổi vào cơ sở dữ liệu.
                                _entity.SaveChanges();
                                LoadClient(); // Nạp lại dữ liệu sau khi đã cập nhật thành công.
                            }
                            

                        }
                        else
                        {
                            if (selectedClient.StatusClient == "DISCONNECT")
                            {
                                MessageBox.Show("Máy khách đang trạng thái tắt.","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here, e.g., show an error message.
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
