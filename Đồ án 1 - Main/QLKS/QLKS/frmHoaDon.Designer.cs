namespace QLKS
{
    partial class frmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvCTDichVu = new System.Windows.Forms.DataGridView();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbMaDP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbHoTenKH = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbNgayNhan = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTienDV = new System.Windows.Forms.Label();
            this.lbTienPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDichVu)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 50);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(218, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 30);
            this.label14.TabIndex = 9;
            this.label14.Text = "Hóa Đơn  ";
            // 
            // dgvCTDichVu
            // 
            this.dgvCTDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendichvu,
            this.SoLuong,
            this.GiaDV});
            this.dgvCTDichVu.Location = new System.Drawing.Point(0, 359);
            this.dgvCTDichVu.Name = "dgvCTDichVu";
            this.dgvCTDichVu.RowHeadersVisible = false;
            this.dgvCTDichVu.RowTemplate.Height = 24;
            this.dgvCTDichVu.Size = new System.Drawing.Size(611, 215);
            this.dgvCTDichVu.TabIndex = 11;
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "_tenDichVu";
            this.tendichvu.Frozen = true;
            this.tendichvu.HeaderText = "Tên loại DV";
            this.tendichvu.Name = "tendichvu";
            this.tendichvu.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "_soLuong";
            this.SoLuong.Frozen = true;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "_gia";
            this.GiaDV.Frozen = true;
            this.GiaDV.HeaderText = "Giá";
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.Width = 150;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.LightCoral;
            this.btnInHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Location = new System.Drawing.Point(358, 829);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(228, 61);
            this.btnInHoaDon.TabIndex = 14;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(12, 829);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(228, 61);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(375, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Loại Phòng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(176, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã DP :";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbLoaiPhong.Location = new System.Drawing.Point(504, 46);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(44, 23);
            this.lbLoaiPhong.TabIndex = 18;
            this.lbLoaiPhong.Text = "null";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTenPhong.Location = new System.Drawing.Point(304, 46);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(44, 23);
            this.lbTenPhong.TabIndex = 19;
            this.lbTenPhong.Text = "null";
            // 
            // lbMaDP
            // 
            this.lbMaDP.AutoSize = true;
            this.lbMaDP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMaDP.Location = new System.Drawing.Point(104, 46);
            this.lbMaDP.Name = "lbMaDP";
            this.lbMaDP.Size = new System.Drawing.Size(44, 23);
            this.lbMaDP.TabIndex = 20;
            this.lbMaDP.Text = "null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(13, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ Tên KH:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDiaChi.Location = new System.Drawing.Point(106, 218);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(44, 23);
            this.lbDiaChi.TabIndex = 24;
            this.lbDiaChi.Text = "null";
            // 
            // lbHoTenKH
            // 
            this.lbHoTenKH.AutoSize = true;
            this.lbHoTenKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbHoTenKH.Location = new System.Drawing.Point(128, 161);
            this.lbHoTenKH.Name = "lbHoTenKH";
            this.lbHoTenKH.Size = new System.Drawing.Size(44, 23);
            this.lbHoTenKH.TabIndex = 25;
            this.lbHoTenKH.Text = "null";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGioiTinh.Location = new System.Drawing.Point(477, 161);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(44, 23);
            this.lbGioiTinh.TabIndex = 26;
            this.lbGioiTinh.Text = "null";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMaKH.Location = new System.Drawing.Point(465, 97);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(44, 23);
            this.lbMaKH.TabIndex = 27;
            this.lbMaKH.Text = "null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(375, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "Giới Tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(375, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã KH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(176, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã NV :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMaNV.Location = new System.Drawing.Point(270, 97);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(44, 23);
            this.lbMaNV.TabIndex = 20;
            this.lbMaNV.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã HD :";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMaHD.Location = new System.Drawing.Point(104, 97);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(44, 23);
            this.lbMaHD.TabIndex = 20;
            this.lbMaHD.Text = "null";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.lbNgayTra);
            this.gbThongTin.Controls.Add(this.lbNgayNhan);
            this.gbThongTin.Controls.Add(this.lbDiaChi);
            this.gbThongTin.Controls.Add(this.label16);
            this.gbThongTin.Controls.Add(this.label11);
            this.gbThongTin.Controls.Add(this.label12);
            this.gbThongTin.Controls.Add(this.lbMaDP);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.lbGioiTinh);
            this.gbThongTin.Controls.Add(this.lbHoTenKH);
            this.gbThongTin.Controls.Add(this.label15);
            this.gbThongTin.Controls.Add(this.label9);
            this.gbThongTin.Controls.Add(this.lbTenPhong);
            this.gbThongTin.Controls.Add(this.label10);
            this.gbThongTin.Controls.Add(this.lbLoaiPhong);
            this.gbThongTin.Controls.Add(this.lbMaKH);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.lbMaHD);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.lbMaNV);
            this.gbThongTin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbThongTin.Location = new System.Drawing.Point(0, 56);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(611, 297);
            this.gbThongTin.TabIndex = 30;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNgayTra.Location = new System.Drawing.Point(437, 260);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(44, 23);
            this.lbNgayTra.TabIndex = 24;
            this.lbNgayTra.Text = "null";
            // 
            // lbNgayNhan
            // 
            this.lbNgayNhan.AutoSize = true;
            this.lbNgayNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNgayNhan.Location = new System.Drawing.Point(141, 260);
            this.lbNgayNhan.Name = "lbNgayNhan";
            this.lbNgayNhan.Size = new System.Drawing.Size(44, 23);
            this.lbNgayNhan.TabIndex = 24;
            this.lbNgayNhan.Text = "null";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(334, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Ngày Trả:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(13, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ngày Nhận:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.lbTienDV);
            this.groupBox1.Controls.Add(this.lbTienPhong);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(0, 589);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 234);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(33, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 40);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tổng Tiền :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(35, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tiền Dịch Vụ :        ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(35, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tiền Phòng :       ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTongTien.Location = new System.Drawing.Point(257, 166);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(69, 40);
            this.lbTongTien.TabIndex = 26;
            this.lbTongTien.Text = "null";
            // 
            // lbTienDV
            // 
            this.lbTienDV.AutoSize = true;
            this.lbTienDV.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTienDV.Location = new System.Drawing.Point(259, 106);
            this.lbTienDV.Name = "lbTienDV";
            this.lbTienDV.Size = new System.Drawing.Size(55, 30);
            this.lbTienDV.TabIndex = 26;
            this.lbTienDV.Text = "null";
            // 
            // lbTienPhong
            // 
            this.lbTienPhong.AutoSize = true;
            this.lbTienPhong.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTienPhong.Location = new System.Drawing.Point(259, 66);
            this.lbTienPhong.Name = "lbTienPhong";
            this.lbTienPhong.Size = new System.Drawing.Size(55, 30);
            this.lbTienPhong.TabIndex = 26;
            this.lbTienPhong.Text = "null";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(612, 903);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.dgvCTDichVu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDichVu)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvCTDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbMaDP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbHoTenKH;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTienDV;
        private System.Windows.Forms.Label lbTienPhong;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbNgayNhan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
    }
}