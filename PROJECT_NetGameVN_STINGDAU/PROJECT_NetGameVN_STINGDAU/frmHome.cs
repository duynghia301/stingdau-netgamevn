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



        //Dlong
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



        //Nghia
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
                    Start = x.Start,
                    EndTime = x.Endtime
                }).ToList();
                dvgList.DataSource = _ClientList;



            }
        }


        // Hàm mới cần làm   mà không xuất dữ liệu ra dgv dc
        //public void Display1()
        //{
        //    using (NetGameVNEntities _entity = new NetGameVNEntities())
        //    {
        //        var query = from client in _entity.tbClients
        //                    join login in _entity.tbLoginUsers on client.ClientName equals login.ClientName
        //                    select new
        //                    {
        //                        login.MemberID,
        //                        client.ClientName,
        //                        client.GroupClientName,
        //                        client.StatusClient,
        //                        login.StartTime,
        //                        login.UseTime,
        //                        login.LeftTime,
        //                        client.Note
        //                    };

        //        dvgList.DataSource = query.ToList();
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
                    //GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    //StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    //Birthday = x.Birthday
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
            load();
            loadquesion(0);

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
                    //GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    //StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    //Birthday = x.Birthday
                }).ToList();
                dgvListTaiKhoan.DataSource = _MembersList;
            }
        }


        //refrest data Client
        //private void RefreshClient()
        //{
        //    using (NetGameVNEntities _entity = new NetGameVNEntities())
        //    {
        //        List<Client> _ClientList = new List<Client>();
        //        _ClientList = _entity.tbClients.Select(x => new Client
        //        {
        //            ClientName = x.ClientName,
        //            GroupClientName = x.GroupClientName,
        //            StatusClient = x.StatusClient,
        //            Note = x.Note
        //        }).ToList();
        //        dvgList.DataSource = _ClientList;



        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadClient();
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









        //tải lại client
        public void LoadClient()
        {

            dvgList.DataSource = (from tbClient in db.tbClients select new { ClientName = tbClient.ClientName, GroupClientName = tbClient.GroupClientName, StatusClient = tbClient.StatusClient, Note = tbClient.Note, StartTime = tbClient.Start, EndTime = tbClient.Endtime }).ToArray();
        }






        // mo may
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




                            // Láy thời gian hiện tại
                            DateTime currentTime = DateTime.Now;
                            selectedClient.Start = currentTime;
                            selectedClient.Endtime = null;



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




        //tat may
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



                            DateTime currentTime = DateTime.Now;
                            selectedClient.Endtime = currentTime;
                            // Lưu các thay đổi vào cơ sở dữ liệu.
                            _entity.SaveChanges();
                            LoadClient(); // Nạp lại dữ liệu sau khi đã cập nhật thành công.
                        }


                    }
                    else
                    {
                        if (selectedClient.StatusClient == "DISCONNECT")
                        {
                            MessageBox.Show("Máy khách đang trạng thái tắt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        //Dlong
        public void Display_Member(string _ttkusername)
        {

            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<Members> _MembersList = new List<Members>();
                _MembersList = _entity.tbMembers.Where(s => s.UserName.Equals(_ttkusername)).Select(x => new Members
                {
                    MemberID = x.MemberID,
                    UserName = x.UserName,
                    Password = x.Password,
                    Phone = x.Phone,
                    //GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    //StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    //Birthday = x.Birthday
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
                    //GroupUser = x.GroupUser,
                    CurrentTime = x.CurrentTime,
                    CurrentMoney = x.CurrentMoney,
                    //StatusAccount = x.StatusAccount,
                    Fullname = x.Fullname,
                    //Birthday = x.Birthday
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




        //VInh
        private void btnQLDV_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu();
            frm.ShowDialog();
        }






        private void tabDichVu_Click(object sender, EventArgs e)
        {

        }


















        //Dnghia chua xong



        private void frmMayChu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500, "Thông báo", "NetGameVN", ToolTipIcon.Info);
                this.Hide();
            }

        }

        //private void frmMayChu_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (rs == DialogResult.OK)
        //    {
        //        isThoat = false;
        //        this.Close();
        //        notifyIcon1.Visible = true;
        //        notifyIcon1.ShowBalloonTip(500, "Thông báo", "NetGameVN", ToolTipIcon.Info);
        //        this.Hide();    
        //    }
        //}

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
        }

        private void frmMayChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (rs == DialogResult.OK)
            //{        
            //    this.Close();
            //    notifyIcon1.Visible = true;
            //    notifyIcon1.ShowBalloonTip(500, "Thông báo", "NetGameVN", ToolTipIcon.Info);
            //    this.Hide();
            //}
        }


        // nạp tiền
        private void pictureBox6_Click(object sender, EventArgs e)
        {
         
            
               

                frmNapTien NapTien = new frmNapTien();
                NapTien.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                if (dvgList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn máy khách từ danh sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = dvgList.SelectedRows[0].Index;
                string computerName = dvgList.Rows[index].Cells["ClientName"].Value.ToString();
                tbClient selectedClient = _entity.tbClients.SingleOrDefault(c => c.ClientName == computerName);

                if (selectedClient != null)
                {
                    DateTime? starttime = selectedClient.Start;
                    DateTime? endtime = selectedClient.Endtime;
                    TimeSpan? usageTime = endtime - starttime;

                    // Define your cost per unit of time (e.g., per minute)
                    const double costPerHour = 10000; // Replace with your actual cost

                    // Calculate the total cost
                    double sotien = Math.Round(usageTime.Value.TotalHours * costPerHour);

                    MessageBox.Show("Thời gian sử dụng: " + usageTime.Value.TotalMinutes + " phút\nTiền cần thanh toán: " + sotien + " đồng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotal.Text = sotien.ToString();
                    selectedClient.Endtime = null;
                    selectedClient.Start = null;
                    _entity.SaveChanges();
                    LoadClient();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin máy khách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        }

        private void load()
        {
            List<tbDichVu> list = new List<tbDichVu>();
            list = db.tbDichVus.ToList();
            cbluachon.DataSource = list;
            cbluachon.DisplayMember = "Tendv";
            cbluachon.ValueMember = "Madv";
        }
        private void loadquesion(int quesiontype  )
        {
            List<quessionmodel> list = new List<quessionmodel>();
            list = (from qt in db.tbDichVus
                    where qt.Madv == quesiontype
                    select new quessionmodel
                    {
                        Tendv = qt.Tendv ,
                        Madv =qt.Madv,
                        ngaynhap = qt.ngaynhap,
                        Giatien = qt.Giatien,
                        soluong = qt.soluong,
                    }
                    ).ToList();
            dgvdichvu.DataSource = list ;
        }



        private void drgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbluachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbluachon.SelectedIndex;
            tbDichVu item  = (tbDichVu) cbluachon.Items[index];
            int idquessiontype = Convert.ToInt32(item.Madv.ToString());
            loadquesion(item.Madv);

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("soluong") == -1)
            {
                chart1.Series.Add("soluong");
            }

            chart1.Titles.Add("Report so luong");
            List<tbDichVu> list = db.tbDichVus.ToList();

            
            foreach (var item in list)
            {
                chart1.Series["soluong"].Points.AddXY(item.Tendv, item.soluong);
            }

          }
    }
}