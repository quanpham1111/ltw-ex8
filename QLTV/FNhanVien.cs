using DevExpress.ClipboardSource.SpreadsheetML;
using QLTV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FNhanVien : Form

    {
        List<NHANVIEN> listnv = context.NHANVIENs.ToList();
        List<BANGCAP> BangCapList = context.BANGCAPs.ToList();
        public FNhanVien()
        {
            InitializeComponent();
        }

       

        static QLTVDBContext context = new QLTVDBContext();
     
        //Them du lieu tu sql vao DataGridview
        public void BindNhanVienToGridView(List<NHANVIEN> listnhanvien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listnhanvien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MaNhanVien;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HoTenNhanVien;
                dgvNhanVien.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvNhanVien.Rows[index].Cells[3].Value = item.DiaChi;
                dgvNhanVien.Rows[index].Cells[4].Value = item.DienThoai;
                dgvNhanVien.Rows[index].Cells[5].Value = item.BANGCAP.TenBangCap;
            }
        }

        void BindBangCaptoGridView(List<BANGCAP> listbc)
        {
            this.comboBox1.DataSource = listbc;
            this.comboBox1.DisplayMember = "TenBangCap";
            this.comboBox1.ValueMember = "MaBangCap";

        }
        //Rang buoc
        private int RangBuoc()
        {
            if (txtTenNV.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
                return -1;
            return 0;
        }
        // kiem tra ton tai sinh vien
        private NHANVIEN KiemTraTonTai(int MaNhanVien)
        {
            NHANVIEN timNV = context.NHANVIENs.FirstOrDefault(nv => nv.MaNhanVien == MaNhanVien);
            return timNV;
        }
        //Reload 
        private void ReloadDSSV()
        {
            List<NHANVIEN> listStudent = context.NHANVIENs.ToList();
            BindNhanVienToGridView(listStudent);
        }

        
        //Thêm sinh viên
        private void button1_Click(object sender, EventArgs e)
        {
            //nếu để trống
            if (RangBuoc() == -1)
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Trường hợp tồn tại
            NHANVIEN kiemtra = KiemTraTonTai(int.Parse(txtMaNV.Text));
            if (kiemtra != null)
            {
                MessageBox.Show("Sinh Viên Đã Tồn tại,Nhập sinh viên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                NHANVIEN nv = new NHANVIEN
                {
                    MaNhanVien = int.Parse(txtMaNV.Text.ToString()),
                    HoTenNhanVien = txtTenNV.Text,
                    NgaySinh = DateTime.Parse(txtNgaySinh.Text),
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    MaBangCap = int.Parse(comboBox1.SelectedValue.ToString()),
                };
                context.NHANVIENs.Add(nv);
                context.SaveChanges();
                MessageBox.Show("Đã thêm thông tin thành công!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ràng buộc
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtMaNV.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
                ReloadDSSV();
            }
        }

       

      
        //ràng buộc ko cho nhập chữ ô Mã 
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng nhập số", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        //ràng buộc người dùng ko cho nhập chữ ô tên

        
        //Đổ dữ liệu ngược lại text box

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvNhanVien[e.ColumnIndex, e.RowIndex].Value != null)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = selectedRow.Cells["HoTenNhanVien"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = selectedRow.Cells["DienThoai"].Value.ToString();
                string TenBangCap = selectedRow.Cells["MaBangCap"].Value.ToString();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.GetItemText(comboBox1.Items[i]) == TenBangCap)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                    int MaNhanVien = (int)selectedRow.Cells["MaNhanVien"].Value; // Lấy mã Nhân VIên từ hàng được chọn

                    var deleteNhanVien = context.NHANVIENs.FirstOrDefault(s => s.MaNhanVien.Equals(MaNhanVien));
                    //Xác nhận người nhập
                    if (deleteNhanVien != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            context.NHANVIENs.Remove(deleteNhanVien);
                            context.SaveChanges();
                            var Nhanvien = context.NHANVIENs.ToList();
                            BindNhanVienToGridView(Nhanvien);
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân Viên cần xóa không tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                //phòng trường hợp bấm nhầm 1 ô dữ liệu rồi xóa,buộc phải chọn full hàng
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng nhân viên cần xóa trong danh sách!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        // ràng buộc người dùng nhập năm nhỏ hơn năm hiện tại
        private void txtNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = txtNgaySinh.Value;
            int currentYear = DateTime.Now.Year;

            if (selectedDate.Year > currentYear)
            {
                MessageBox.Show("Vui lòng không chọn năm sinh nhỏ hơn năm hiện tại.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Value = new DateTime(currentYear, 1, 1);
            }
        }
        //ngăn nhập chữ vào ô số điện thoại
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không phải số được thêm vào TextBox.
                MessageBox.Show("Vui lòng chỉ nhập số!.", "Lỗi Ký Tự", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // tìm kiếm thông tin theo tên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();
            var TimKiem = context.NHANVIENs.Where(emp => emp.HoTenNhanVien.Contains(searchName)).ToList();
            BindNhanVienToGridView(TimKiem);
        }
        //Quan


        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNV.Text)) // Kiểm tra xem có hàng nào được chọn hay không
            {
                int rowIndex = dgvNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[rowIndex];
                int MaNhanVien = (int)selectedRow.Cells["MaNhanVien"].Value; // Lấy mã Nhân Viên từ hàng được chọn

                //var selectedRow = dgvQLS.SelectedRows[rowIndex];

                var updateNhanVien = context.NHANVIENs.FirstOrDefault(s => s.MaNhanVien.Equals(MaNhanVien));
                if (updateNhanVien != null)
                {
                    if (RangBuoc() == -1)
                    {
                        MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        updateNhanVien.MaNhanVien = int.Parse(txtMaNV.Text);
                        updateNhanVien.HoTenNhanVien = txtTenNV.Text;
                        updateNhanVien.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                        updateNhanVien.DiaChi = txtDiaChi.Text;
                        updateNhanVien.DienThoai = txtDienThoai.Text;
                        updateNhanVien.MaBangCap = int.Parse(comboBox1.SelectedValue.ToString());
                        context.SaveChanges();
                        var NhanVien = context.NHANVIENs.ToList();
                        BindNhanVienToGridView(NhanVien);
                        MessageBox.Show("Cập nhật thông tin thành công ", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

     
        //Reload text box
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        //Lọc theo bằng cấp
        private void button4_Click_1(object sender, EventArgs e)
        {
            List<NHANVIEN> Loc = listnv;

            List<NHANVIEN> kq = Loc.Where(s => s.BANGCAP.TenBangCap == comboBox1.Text).ToList();
            BindNhanVienToGridView(kq);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            BindNhanVienToGridView(listnv);
            BindBangCaptoGridView(BangCapList);
        }
    }
}

