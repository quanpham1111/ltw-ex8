namespace QLTV
{
    partial class frmSach
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
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLS
            // 
            this.dgvQLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvTenSach,
            this.dgvTacGia,
            this.dgvNamXB,
            this.dgvNhaXB,
            this.dgvTriGia,
            this.dgvNgayNhap});
            this.dgvQLS.Location = new System.Drawing.Point(12, 503);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.ReadOnly = true;
            this.dgvQLS.RowHeadersWidth = 82;
            this.dgvQLS.RowTemplate.Height = 33;
            this.dgvQLS.Size = new System.Drawing.Size(1909, 545);
            this.dgvQLS.TabIndex = 0;
            this.dgvQLS.DoubleClick += new System.EventHandler(this.dgvQLS_DoubleClick);
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.HeaderText = "Mã Sách";
            this.dgvMaSach.MinimumWidth = 10;
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.ReadOnly = true;
            // 
            // dgvTenSach
            // 
            this.dgvTenSach.HeaderText = "Tên Sách";
            this.dgvTenSach.MinimumWidth = 10;
            this.dgvTenSach.Name = "dgvTenSach";
            this.dgvTenSach.ReadOnly = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.HeaderText = "Tác Giả";
            this.dgvTacGia.MinimumWidth = 10;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            // 
            // dgvNamXB
            // 
            this.dgvNamXB.HeaderText = "Năm XB";
            this.dgvNamXB.MinimumWidth = 10;
            this.dgvNamXB.Name = "dgvNamXB";
            this.dgvNamXB.ReadOnly = true;
            // 
            // dgvNhaXB
            // 
            this.dgvNhaXB.HeaderText = "Nhà XB";
            this.dgvNhaXB.MinimumWidth = 10;
            this.dgvNhaXB.Name = "dgvNhaXB";
            this.dgvNhaXB.ReadOnly = true;
            // 
            // dgvTriGia
            // 
            this.dgvTriGia.HeaderText = "Trị Giá";
            this.dgvTriGia.MinimumWidth = 10;
            this.dgvTriGia.Name = "dgvTriGia";
            this.dgvTriGia.ReadOnly = true;
            // 
            // dgvNgayNhap
            // 
            this.dgvNgayNhap.HeaderText = "Ngày Nhập";
            this.dgvNgayNhap.MinimumWidth = 10;
            this.dgvNgayNhap.Name = "dgvNgayNhap";
            this.dgvNgayNhap.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(647, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Sách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(39, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 55);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm XB";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(807, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Nhập";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(807, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhà XB";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(807, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 55);
            this.label7.TabIndex = 2;
            this.label7.Text = "Trị Giá";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(289, 86);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(341, 50);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(289, 160);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(341, 50);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(1054, 160);
            this.txtTriGia.Multiline = true;
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(341, 50);
            this.txtTriGia.TabIndex = 3;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(1054, 86);
            this.txtNhaXB.Multiline = true;
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(341, 50);
            this.txtNhaXB.TabIndex = 3;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(289, 238);
            this.txtNamXB.Multiline = true;
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(341, 50);
            this.txtNamXB.TabIndex = 3;
            this.txtNamXB.TextChanged += new System.EventHandler(this.txtNamXB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhaXB);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtTriGia);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(207, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1475, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(1054, 232);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(341, 56);
            this.dtpNgayNhap.TabIndex = 6;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(255, 423);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(235, 57);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(602, 423);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(235, 57);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbnSua
            // 
            this.tbnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbnSua.Location = new System.Drawing.Point(1023, 423);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(235, 57);
            this.tbnSua.TabIndex = 5;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.UseVisualStyleBackColor = true;
            this.tbnSua.Click += new System.EventHandler(this.tbnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1367, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(235, 57);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 1060);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLS);
            this.Name = "frmSach";
            this.Text = "Thông Tin Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    }
}