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
    public partial class frmMayChu : Form
    {

        
        //tạo biến kiểm tra thoát
        bool isThoat = true;

        private static DateTime _startDateTime;
        public static void Start()
        {
            _startDateTime = DateTime.Now;
        }

        public static void Stop()
        {
            
            DateTime _endDateTime = DateTime.Now;
            TimeSpan _timeSpan = _endDateTime - _startDateTime;
 
        }

        

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
                    Note = x.Note,
                }).ToList();
                dvgList.DataSource = _ClientList;



            }
        }
        //public void Display()
        //{
        //    using (NetGameVNEntities _entity = new NetGameVNEntities())
        //    {
        //        List<Client> _ClientList = new List<Client>();
        //        _ClientList = _entity.tbClients.Select(x => new Client
        //        {
        //            ClientName = x.ClientName,
        //            GroupClientName = x.GroupClientName,
        //            StatusClient = x.StatusClient,
        //            Note = x.Note,
        //        }).ToList();
        //        dvgList.DataSource = _ClientList;



        //    }
        //}
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
            

        }


        //void ResizeTabs()
        //{
        //    int numTabs = tabControl1.TabCount;

        //    float totLen = 0;
        //    using (Graphics g = CreateGraphics())
        //    {
        //        // Get total length of the text of each Tab name
        //        for (int i = 0; i < numTabs; i++)
        //            totLen += g.MeasureString(tabControl1.TabPages[i].Text, tabControl1.Font).Width;
        //    }

        //    int newX = (int)((tabControl1.Width - totLen) / numTabs) / 2;
        //    tabControl1.Padding = new Point(newX, tabControl1.Padding.Y);
        //}

      


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
        //private void frmMayChu_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (isThoat)
        //        Application.Exit();

        //}

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



        public bool DeleteMembers(int id)
        {
            bool result = false;
            try
            {
                using (NetGameVNEntities _entity = new NetGameVNEntities())
                {
                    tbMember _member = _entity.tbMembers.Find(id);
                    if (_member != null)
                    {
                        _entity.tbMembers.Remove(_member);
                        _entity.SaveChanges();
                        result = true;

                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }












        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                
                    if (dgvListTaiKhoan.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn tài khoản từ danh sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DataGridViewRow selectedRow = dgvListTaiKhoan.SelectedRows[0];


                    // Lấy ra member cần xóa
                    int memberID = (int)selectedRow.Cells["MemberID"].Value;


                    {
                        try
                        {
                            // Lấy ra tài khoản cần xóa từ nguồn dữ liệu thực tế (ví dụ: danh sách tài khoản).
                            tbMember selectedMember = _entity.tbMembers.SingleOrDefault(m => m.MemberID == memberID);

                            if (selectedMember != null)
                            {
                                DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result == DialogResult.OK)
                                {
                                    // Xóa tài khoản khỏi nguồn dữ liệu.
                                    _entity.tbMembers.Remove(selectedMember);

                                    // Lưu các thay đổi vào cơ sở dữ liệu.
                                    _entity.SaveChanges();

                                    
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
                           
                            DateTime now = DateTime.Now;
                            _startDateTime = DateTime.Now;
                           
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

        public void Display_Member(string _ttkusername)
        {

            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Members> _MembersList = new List<Members>();
                _MembersList = _entity.tbMembers.Where(s => s.UserName.Equals(_ttkusername) ).Select(x => new Members
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

        public void Display_pMember(string _ttkphone)
        {

            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Members> _MembersList = new List<Members>();
                _MembersList = _entity.tbMembers.Where(s => s.Phone.Equals(_ttkphone)).Select(x => new Members
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

       

        
        private void bnttimkiem_Click(object sender, EventArgs e)
        {
            string _username = txttimkiem.Text;
            if (cbxTimTk.Text == "UserName")
            {
             
                Display_Member(_username);
            }
            else  
            {

                Display_pMember(_username);
            }
           
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu();
            frm.ShowDialog();
        }

        private void tabDichVu_Click(object sender, EventArgs e)
        {

        }

        private void frmMayChu_Resize(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500,"Thông báo", "NetGameVN", ToolTipIcon.Info);
                this.Hide();
            }
            
        }

        private void frmMayChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = true;
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                notifyIcon1.ShowBalloonTip(500, "Thông báo", "NetGameVN", ToolTipIcon.Info);
                this.Hide();
            }

        }

        private void frmMayChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
        }
    }
}
