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
    public partial class fPhieuMuonSach : Form
    {
        static QLTVDBContext context = new QLTVDBContext();
        List<SACH> bookList = context.SACHes.ToList();
        List<DOCGIA> DgList = context.DOCGIAs.ToList();
        List<PHIEUMUONSACH> list = context.PHIEUMUONSACHes.ToList();
        public fPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void fPhieuMuonSach_Load(object sender, EventArgs e)
        {
            FillCBTenSach(bookList);
            FillCBDocGia(DgList);
            BingdingToGridView(list);

            dtpMuon.MinDate = DateTime.Now;
            dtpTra.MinDate = DateTime.Now;
        }

        public void FillCBTenSach(List<SACH> bookList)
        {
            cbTenSach.DataSource = bookList;
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
        }

        public void FillCBDocGia(List<DOCGIA> DgList)
        {
            cbMaDG.DataSource = DgList;
            cbMaDG.DisplayMember = "HoTenDocGia";
            cbMaDG.ValueMember = "MaDocGia";
        }

        public void BingdingToGridView(List<PHIEUMUONSACH> pms)
        {
            // xoa toan bi gridview
            dgvPhieuMuon.Rows.Clear();

            // do du lieu xuong 
            foreach (var item in pms)
            {
                int index = dgvPhieuMuon.Rows.Add(); // them 1 dong moi
                dgvPhieuMuon.Rows[index].Cells[0].Value = item.MaPhieuMuon;
                dgvPhieuMuon.Rows[index].Cells[1].Value = item.DOCGIA.HoTenDocGia;
                dgvPhieuMuon.Rows[index].Cells[2].Value = item.NgayMuon;
                dgvPhieuMuon.Rows[index].Cells[3].Value = item.NgayTra;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (false)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    PHIEUMUONSACH pms = new PHIEUMUONSACH()
                    {
                        MaDocGia = int.Parse(cbMaDG.SelectedValue.ToString()),
                        NgayMuon = DateTime.Parse(dtpMuon.Text),
                        NgayTra = DateTime.Parse(dtpTra.Text)
                    };
                    
                    context.PHIEUMUONSACHes.Add(pms);
                    context.SaveChanges();
                    List<PHIEUMUONSACH> list = context.PHIEUMUONSACHes.ToList();
                    BingdingToGridView(list);
                    Reset();
                    MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                

                if (dgvPhieuMuon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPhieuMuon.CurrentRow.Selected = true;
                    txtMpm.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells["MAPHIEU"].FormattedValue.ToString();
                    cbMaDG.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells["HOTEN"].FormattedValue.ToString();
                    dtpMuon.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells["NGAYMUON"].FormattedValue.ToString();
                    dtpTra.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells["NGAYTRA"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuMuon.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    DataGridViewRow selectedRow = dgvPhieuMuon.SelectedRows[0];
                    int mp = (int)selectedRow.Cells["MAPHIEU"].Value; // Lấy mã sách từ hàng được chọn

                    var updatemp = context.PHIEUMUONSACHes.FirstOrDefault(p => p.MaPhieuMuon.Equals(mp));
                    if (updatemp != null)
                    {

                        {
                            updatemp.MaDocGia = int.Parse(cbMaDG.SelectedValue.ToString());
                            updatemp.NgayMuon = DateTime.Parse(dtpMuon.Text);
                            updatemp.NgayTra = DateTime.Parse(dtpTra.Text);
                            context.SaveChanges();
                            var listUp = context.PHIEUMUONSACHes.ToList();
                            BingdingToGridView(listUp);
                            Reset();
                            MessageBox.Show("Cập nhật thông tin thành công ", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
          
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu cần sửa ", "Thông báo", MessageBoxButtons.OK);
                    return;
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
                if (dgvPhieuMuon.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    DataGridViewRow selectedRow = dgvPhieuMuon.SelectedRows[0];
                    int mp = (int)selectedRow.Cells["MAPHIEU"].Value; // Lấy mã sách từ hàng được chọn

                    var deletedmp = context.PHIEUMUONSACHes.FirstOrDefault(p => p.MaPhieuMuon.Equals(mp));
                    if (deletedmp != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            context.PHIEUMUONSACHes.Remove(deletedmp);
                            context.SaveChanges();
                            var listUp = context.PHIEUMUONSACHes.ToList();
                            BingdingToGridView(listUp);
                            Reset();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phiếu cần xóa không tồn tại!", "Thông Báo", MessageBoxButtons.OK);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                var dg = context.DOCGIAs.FirstOrDefault(d => d.HoTenDocGia.Contains(txtTimKiem.Text));
                if (dg != null)
                {
                    var kq = context.PHIEUMUONSACHes.Where(p => p.MaDocGia == dg.MaDocGia).ToList();
                    if (kq != null)
                    {
                        BingdingToGridView(kq);
                    }
                    else
                    {
                        MessageBox.Show("Không có kết quả tìm kiếm nào", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không có kết quả tìm kiếm nào", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập từ tìm kiếm nào", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        public void Reset()
        {
            txtMpm.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpFrom.Value;
            DateTime d2 = dtpTo.Value;
            var kq = context.PHIEUMUONSACHes.Where(p => p.NgayMuon <= d2 && p.NgayMuon >= d1).ToList();
            if (kq != null)
            {
                BingdingToGridView(kq);
            }
            else
            {
                MessageBox.Show("Không có kết quả tìm kiếm nào", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
