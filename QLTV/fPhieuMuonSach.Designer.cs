
namespace QLTV
{
    partial class fPhieuMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMpm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(533, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu mượn sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đọc giả";
            // 
            // txtMpm
            // 
            this.txtMpm.Enabled = false;
            this.txtMpm.Location = new System.Drawing.Point(174, 89);
            this.txtMpm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMpm.Name = "txtMpm";
            this.txtMpm.ReadOnly = true;
            this.txtMpm.Size = new System.Drawing.Size(290, 26);
            this.txtMpm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mượn";
            // 
            // dtpMuon
            // 
            this.dtpMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMuon.Location = new System.Drawing.Point(603, 151);
            this.dtpMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpMuon.Name = "dtpMuon";
            this.dtpMuon.Size = new System.Drawing.Size(175, 26);
            this.dtpMuon.TabIndex = 7;
            // 
            // dtpTra
            // 
            this.dtpTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTra.Location = new System.Drawing.Point(603, 209);
            this.dtpTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(175, 26);
            this.dtpTra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(909, 151);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(349, 26);
            this.txtTimKiem.TabIndex = 11;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEU,
            this.HOTEN,
            this.NGAYMUON,
            this.NGAYTRA});
            this.dgvPhieuMuon.Location = new System.Drawing.Point(20, 317);
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(1263, 478);
            this.dgvPhieuMuon.TabIndex = 12;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.HeaderText = "MÃ PHIẾU";
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "HỌ TÊN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // NGAYMUON
            // 
            this.NGAYMUON.HeaderText = "NGÀY MƯỢN";
            this.NGAYMUON.Name = "NGAYMUON";
            this.NGAYMUON.ReadOnly = true;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.HeaderText = "NGÀY TRẢ";
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(174, 151);
            this.cbMaDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(290, 28);
            this.cbMaDG.TabIndex = 13;
            // 
            // cbTenSach
            // 
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(174, 206);
            this.cbTenSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(290, 28);
            this.cbTenSach.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 258);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(198, 258);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(352, 258);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(909, 263);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 30);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(909, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 69);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc ngày mượn trong khoảng";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(7, 27);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(144, 26);
            this.dtpFrom.TabIndex = 19;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(198, 27);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(144, 26);
            this.dtpTo.TabIndex = 20;
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.Location = new System.Drawing.Point(1183, 263);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 30);
            this.btnLoc.TabIndex = 19;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // fPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 814);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbTenSach);
            this.Controls.Add(this.cbMaDG);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMpm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPhieuMuonSach";
            this.Text = "Phiếu mượn sách";
            this.Load += new System.EventHandler(this.fPhieuMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMpm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMuon;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnLoc;
    }
}