using QLTV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmSach : Form
    {
        static QLTVDBContext context = new QLTVDBContext();

        List<SACH> bookList = context.SACHes.ToList();

        public frmSach()
        {
            InitializeComponent();
            //fillLoaiSachToCombobox(kindbookList);
            BingdingToGridView(bookList);
        }

        //public void fillLoaiSachToCombobox(List<LoaiSach> kindbookList)
        //{
        //    cmbTheLoai.DataSource = kindbookList;
        //    cmbTheLoai.ValueMember = "MaLoai";
        //    cmbTheLoai.DisplayMember = "TenLoai";
        //}

        public void BingdingToGridView(List<SACH> saches)
        {
            // xoa toan bi gridview
            dgvQLS.Rows.Clear();

            // do du lieu xuong 
            foreach (var item in saches)
            {
                int index = dgvQLS.Rows.Add(); // them 1 dong moi
                dgvQLS.Rows[index].Cells[0].Value = item.MaSach;
                dgvQLS.Rows[index].Cells[1].Value = item.TenSach;
                dgvQLS.Rows[index].Cells[2].Value = item.TacGia;
                dgvQLS.Rows[index].Cells[3].Value = item.NamXuatBan;
                dgvQLS.Rows[index].Cells[4].Value = item.NhaXuatBan;
                dgvQLS.Rows[index].Cells[5].Value = item.TriGia;
                dgvQLS.Rows[index].Cells[6].Value = item.NgayNhap;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
        }

        public bool checkNull()
        {
            if (txtNamXB.Text == "" || txtTenSach.Text == "" || txtNhaXB.Text == "" || txtTacGia.Text == "" || txtTriGia.Text == "")
                return true;
            return false;
        }

        //public bool checkMaSach()
        //{
        //    if (txtMaSach.Text.Length != 6)
        //        return false;
        //    return true;
        //}

        public void AddSach(SACH s)
        {
            context.SACHes.Add(s);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công Sách: " + s.TenSach, "Thông báo", MessageBoxButtons.OK);
        }

        public void Reset()
        {
            txtTenSach.Text = string.Empty;
            txtNamXB.Text = string.Empty;
            txtNhaXB.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            txtTriGia.Text = string.Empty;
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (checkNull())
        //        {
        //            MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        else
        //        {
        //                //if (!checkMaSach())
        //                //{
        //                //    MessageBox.Show("Mã sách phải có 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
        //                //    return;
        //                //}

        //                //var kt = context.SACHes.FirstOrDefault(s => s.MaSach.Equals(txtMaSach.Text));
        //                //if (kt != null)
        //                //{
        //                //    MessageBox.Show("Đã tồn tại mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                //    return;
        //                //}
        //                //else
        //                //{
        //                SACH s = new SACH()
        //                {
                            
        //                    TenSach = txtTenSach.Text,
        //                    TacGia = txtTacGia.Text,
        //                    NamXuatBan = int.Parse(txtNamXB.Text),
        //                    NhaXuatBan = txtNhaXB.Text,
        //                    TriGia = float.Parse(txtTriGia.Text),
        //                    NgayNhap = dtpNgayNhap.Value,
        //                };
        //                AddSach(s);
        //                var saches = context.SACHes.ToList();
        //                BingdingToGridView(saches);
        //                Reset();
        //                //}
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //        return;
        //    }
        //}

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkNull())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //if (!checkMaSach())
                    //{
                    //    MessageBox.Show("Mã sách phải có 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                    //    return;
                    //}

                    //var kt = context.SACHes.FirstOrDefault(s => s.MaSach.Equals(txtMaSach.Text));
                    //if (kt != null)
                    //{
                    //    MessageBox.Show("Đã tồn tại mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //else
                    //{
                    SACH s = new SACH()
                    {

                        TenSach = txtTenSach.Text,
                        TacGia = txtTacGia.Text,
                        NamXuatBan = int.Parse(txtNamXB.Text),
                        NhaXuatBan = txtNhaXB.Text,
                        TriGia = float.Parse(txtTriGia.Text),
                        NgayNhap = dtpNgayNhap.Value,
                    };
                    AddSach(s);
                    var saches = context.SACHes.ToList();
                    BingdingToGridView(saches);
                    Reset();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLS.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    DataGridViewRow selectedRow = dgvQLS.SelectedRows[0];
                    int maSach = (int)selectedRow.Cells["dgvMaSach"].Value; // Lấy mã sách từ hàng được chọn

                    var deletedBook = context.SACHes.FirstOrDefault(s => s.MaSach.Equals(maSach));
                    if (deletedBook != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            context.SACHes.Remove(deletedBook);
                            context.SaveChanges();
                            var books = context.SACHes.ToList();
                            BingdingToGridView(books);
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                            Reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sách cần xóa không tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần xóa trong danh sách!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void dgvQLS_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvQLS.SelectedCells[0].RowIndex;
            if (index >= 0 && index < dgvQLS.Rows.Count - 1 )
            {
                //txtMaSach.Text = dgvQLS.Rows[index].Cells[0].Value.ToString();
                txtTenSach.Text = dgvQLS.Rows[index].Cells[1].Value.ToString();
                txtTacGia.Text = dgvQLS.Rows[index].Cells[2].Value.ToString();
                txtNamXB.Text = dgvQLS.Rows[index].Cells[3].Value.ToString();
                txtNhaXB.Text = dgvQLS.Rows[index].Cells[4].Value.ToString();
                txtTriGia.Text = dgvQLS.Rows[index].Cells[5].Value.ToString();
                if (dgvQLS.Rows[index].Cells[6].Value  != null)
                {   
                   string ngayNhapStr = dgvQLS.Rows[index].Cells[6].Value.ToString();
                    DateTime ngayNhap;
                    if (DateTime.TryParse(ngayNhapStr, out ngayNhap))
                    {
                        dtpNgayNhap.Value = ngayNhap;
                    }
                }
            }
        }

        private void tbnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLS.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    DataGridViewRow selectedRow = dgvQLS.SelectedRows[0];
                    int maSach = (int)selectedRow.Cells["dgvMaSach"].Value; // Lấy mã sách từ hàng được chọn

                    var updateSach = context.SACHes.FirstOrDefault(s => s.MaSach.Equals(maSach));
                    if (updateSach != null)
                    {
                        if (checkNull())
                        {
                            MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            //if (!checkMaSach())
                            //{
                            //    MessageBox.Show("Mã sách phải có 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                            //    return;
                            //}
                        }
                       
                        if (updateSach != null)
                        {
                            //txtTenSach.Text = dgvQLS.Rows[index].Cells[1].Value.ToString();
                            //txtTacGia.Text = dgvQLS.Rows[index].Cells[2].Value.ToString();
                            //txtNamXB.Text = dgvQLS.Rows[index].Cells[3].Value.ToString();
                            //txtNhaXB.Text = dgvQLS.Rows[index].Cells[4].Value.ToString();
                            //txtTriGia.Text = dgvQLS.Rows[index].Cells[5].Value.ToString();

                            updateSach.TenSach = txtTenSach.Text;
                            updateSach.TacGia = txtTacGia.Text;
                            updateSach.NamXuatBan = int.Parse(txtNamXB.Text);
                            updateSach.NhaXuatBan = txtNhaXB.Text;
                            updateSach.TriGia = float.Parse(txtTriGia.Text);
                            updateSach.NgayNhap = dtpNgayNhap.Value;
                            context.SaveChanges();
                            var books = context.SACHes.ToList();
                            BingdingToGridView(books);
                            MessageBox.Show("Cập nhật thông tin thành công ", "Thông báo", MessageBoxButtons.OK);
                            Reset();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Sách cần sửa ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        //private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //     // Kiểm tra xem ký tự được nhấn có phải là số không
        //     if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //     {
        //        e.Handled = true; // Ngăn không cho ký tự được nhập vào
        //        MessageBox.Show("Chỉ được nhập số","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }

        //     // Kiểm tra xem số đã nhập có lớn hơn năm hiện tại không
        //     if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
        //     {
        //        int enteredYear = int.Parse(txtNamXB.Text + e.KeyChar);
        //        int currentYear = DateTime.Now.Year;

        //        if (enteredYear > currentYear)
        //        {
        //            e.Handled = true; // Ngăn không cho số được nhập vào
        //            MessageBox.Show("Năm được nhập phải bé hơn hoặc bằng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamXB.Text))
            {
                //txtNamXB.Text = "0";
                return;
            }

            int kt = 0;
            // Kiểm tra xem nội dung của TextBox có phải là số không
            if (!int.TryParse(txtNamXB.Text, out int enteredYear))
            {
                MessageBox.Show("Chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamXB.Text = "0"; // Xóa nội dung không hợp lệ
                txtNamXB.SelectAll();
                return;
            }
            // Kiểm tra xem số đã nhập có lớn hơn năm hiện tại không
            int currentYear = DateTime.Now.Year;

            if (enteredYear >= currentYear)
            {
                MessageBox.Show("Năm được nhập phải bé hơn năm hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kt = 1;
                txtNamXB.Text = "0"; // Xóa nội dung không hợp lệ
                txtNamXB.SelectAll();
                return;
            }
            //if(kt == 1)
            //{
            //    txtNamXB.Text = String.Empty; // Xóa nội dung không hợp lệ
            //}
        }

        private void txtTriGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTriGia.Text))
            {
                //txtNamXB.Text = "0";
                return;
            }

            //float tg = float.Parse(txtTriGia.Text);
            if (!float.TryParse(txtTriGia.Text, out float TriGia))
            {
                MessageBox.Show("Chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTriGia.Text = "0"; // Xóa nội dung không hợp lệ
                txtTriGia.SelectAll();
                return;
            }
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            DateTime ktNgay = dtpNgayNhap.Value;

            if (ktNgay > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayNhap.Value = DateTime.Now; // Đặt lại ngày hiện tại
            }
        }
    }
}
