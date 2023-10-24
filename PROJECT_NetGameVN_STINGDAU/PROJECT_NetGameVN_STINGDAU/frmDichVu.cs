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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        public void Display()
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<DichVu> _dvList = new List<DichVu>();
                _dvList = _entity.tbDichVus.Select(x => new DichVu
                {
                    MaDV = x.MaDV,
                    TenDV = x.TenDV,
                    GiaTien = x.GiaTien,

                }).ToList();
                dgvListDV.DataSource = _dvList;
            }
        }

        private void ClearFields()
        {
            // Xóa nội dung của các TextBox
            txtMaDV.Text = string.Empty;
            txtTenDV.Text = string.Empty;
            txtGiaTien.Text = string.Empty;
        }



        public bool Saveuser(tbDichVu user)
        {
            bool result = false;
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                _entity.tbDichVus.Add(user);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            tbDichVu st = new tbDichVu();
            if (txtMaDV == null || txtMaDV.TextLength == 0 || txtTenDV == null || txtTenDV.TextLength == 0)
            {
                MessageBox.Show("Mã hoặc tên dịch vụ chưa được nhập ");
                return;
            }
            else
            {
                int money = int.Parse((txtGiaTien.Text));
                if (money <= 0)
                {
                    MessageBox.Show("Nhập giá tiền ");
                    return;
                }
                st.MaDV = txtMaDV.Text;
                st.TenDV = txtTenDV.Text;
                st.GiaTien = Convert.ToInt32(txtGiaTien.Text);







                bool result = Saveuser(st);
                if (result == true)
                {
                    MessageBox.Show("Thêm dịch vụ thanh công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                }

            }
        }

        private void dgvListDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDV.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListDV.SelectedRows)
                {
                    txtMaDV.Text = row.Cells[0].Value.ToString();
                    txtTenDV.Text = row.Cells[1].Value.ToString();
                    txtGiaTien.Text = row.Cells[2].Value.ToString();


                }

            }
        }

        private void dgvListDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbDV_Enter(object sender, EventArgs e)
        {

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void picBDV_Click(object sender, EventArgs e)
        {
            RefreshData();

        }
        private void RefreshData()
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                List<DichVu> dichVusList = new List<DichVu>();
                dichVusList = _entity.tbDichVus.Select(x => new DichVu
                {
                    MaDV = x.MaDV,
                    TenDV = x.TenDV,
                    GiaTien = x.GiaTien,

                }).ToList();
                dgvListDV.DataSource = dichVusList;
                ClearFields();
            }
        }
        public bool UpdateDV(tbDichVu dv)

        {
            bool result = true;
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {
                tbDichVu _dichvu = _entity.tbDichVus.Where(x => x.MaDV == dv.MaDV).Select(x => x).FirstOrDefault();
                _dichvu.TenDV = dv.TenDV;
                _dichvu.GiaTien = dv.GiaTien;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbDichVu dv = new tbDichVu();
            dv.MaDV = txtMaDV.Text;
            dv.TenDV = txtTenDV.Text;
            dv.GiaTien = Convert.ToInt32(txtGiaTien.Text);

            bool result = UpdateDV(dv);
            if (result == true)
            {
                MessageBox.Show("Update Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Something went wrong!", "Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            ClearFields();
        }

        public bool DeleteDV(int dv)
        {
            bool result = false;
            try
            {
                using (NetGameVNEntities _entity = new NetGameVNEntities())
                {
                    tbDichVu _dichvu = _entity.tbDichVus.Find(dv);
                    if (_dichvu != null)
                    {
                        _entity.tbDichVus.Remove(_dichvu);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (NetGameVNEntities _entity = new NetGameVNEntities())
            {

                if (dgvListDV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataGridViewRow selectedRow = dgvListDV.SelectedRows[0];
                string iddv = (string)selectedRow.Cells["MaDV"].Value;
                tbDichVu selecteddv = _entity.tbDichVus.SingleOrDefault(m => m.MaDV == iddv);
                if (selecteddv != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // Xóa tài khoản khỏi nguồn dữ liệu.
                        _entity.tbDichVus.Remove(selecteddv);

                        // Lưu các thay đổi vào cơ sở dữ liệu.
                        _entity.SaveChanges();


                    }

                }
                ClearFields();
            }
        }
    }
}
