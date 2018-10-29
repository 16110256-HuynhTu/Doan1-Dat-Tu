namespace QLKS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelPhong = new System.Windows.Forms.Panel();
            this.btnLoadphong = new System.Windows.Forms.Button();
            this.lbGiaDinh = new System.Windows.Forms.Label();
            this.lbDoiVIP = new System.Windows.Forms.Label();
            this.lbDoi = new System.Windows.Forms.Label();
            this.lbDonVip = new System.Windows.Forms.Label();
            this.lbDon = new System.Windows.Forms.Label();
            this.lvGiaDinh = new System.Windows.Forms.ListView();
            this.lvDoiVIP = new System.Windows.Forms.ListView();
            this.lvDoi = new System.Windows.Forms.ListView();
            this.lvDonVIP = new System.Windows.Forms.ListView();
            this.lvDon = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 57);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(1057, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 57);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCEANHILL";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, -3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.White;
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Controls.Add(this.btnHoaDon);
            this.panelChucNang.Controls.Add(this.btnDichVu);
            this.panelChucNang.Controls.Add(this.btnKhachHang);
            this.panelChucNang.Controls.Add(this.btnNhanVien);
            this.panelChucNang.Controls.Add(this.btnPhong);
            this.panelChucNang.Controls.Add(this.btnDatPhong);
            this.panelChucNang.Controls.Add(this.panel2);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucNang.Location = new System.Drawing.Point(0, 57);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(295, 805);
            this.panelChucNang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(3, 550);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(290, 52);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(2, 492);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(290, 52);
            this.btnHoaDon.TabIndex = 1;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.Transparent;
            this.btnDichVu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(3, 434);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(290, 52);
            this.btnDichVu.TabIndex = 1;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 376);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(290, 52);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 318);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(290, 52);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.Black;
            this.btnPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong.Image")));
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(3, 260);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(290, 52);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(3, 202);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(290, 52);
            this.btnDatPhong.TabIndex = 1;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 187);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01");
            this.imageList1.Images.SetKeyName(1, "02");
            // 
            // panelPhong
            // 
            this.panelPhong.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPhong.Controls.Add(this.btnLoadphong);
            this.panelPhong.Controls.Add(this.lbGiaDinh);
            this.panelPhong.Controls.Add(this.lbDoiVIP);
            this.panelPhong.Controls.Add(this.lbDoi);
            this.panelPhong.Controls.Add(this.lbDonVip);
            this.panelPhong.Controls.Add(this.lbDon);
            this.panelPhong.Controls.Add(this.lvGiaDinh);
            this.panelPhong.Controls.Add(this.lvDoiVIP);
            this.panelPhong.Controls.Add(this.lvDoi);
            this.panelPhong.Controls.Add(this.lvDonVIP);
            this.panelPhong.Controls.Add(this.lvDon);
            this.panelPhong.Location = new System.Drawing.Point(302, 57);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(802, 805);
            this.panelPhong.TabIndex = 2;
            // 
            // btnLoadphong
            // 
            this.btnLoadphong.BackColor = System.Drawing.Color.Salmon;
            this.btnLoadphong.FlatAppearance.BorderSize = 0;
            this.btnLoadphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadphong.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadphong.Location = new System.Drawing.Point(658, 6);
            this.btnLoadphong.Name = "btnLoadphong";
            this.btnLoadphong.Size = new System.Drawing.Size(132, 31);
            this.btnLoadphong.TabIndex = 13;
            this.btnLoadphong.Text = "Load";
            this.btnLoadphong.UseVisualStyleBackColor = false;
            this.btnLoadphong.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbGiaDinh
            // 
            this.lbGiaDinh.AutoSize = true;
            this.lbGiaDinh.BackColor = System.Drawing.Color.Gray;
            this.lbGiaDinh.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaDinh.ForeColor = System.Drawing.Color.Transparent;
            this.lbGiaDinh.Location = new System.Drawing.Point(3, 647);
            this.lbGiaDinh.Name = "lbGiaDinh";
            this.lbGiaDinh.Size = new System.Drawing.Size(124, 28);
            this.lbGiaDinh.TabIndex = 3;
            this.lbGiaDinh.Text = "Gia đình";
            // 
            // lbDoiVIP
            // 
            this.lbDoiVIP.AutoSize = true;
            this.lbDoiVIP.BackColor = System.Drawing.Color.Gray;
            this.lbDoiVIP.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiVIP.ForeColor = System.Drawing.Color.Transparent;
            this.lbDoiVIP.Location = new System.Drawing.Point(3, 496);
            this.lbDoiVIP.Name = "lbDoiVIP";
            this.lbDoiVIP.Size = new System.Drawing.Size(110, 28);
            this.lbDoiVIP.TabIndex = 4;
            this.lbDoiVIP.Text = "Đôi VIP";
            // 
            // lbDoi
            // 
            this.lbDoi.AutoSize = true;
            this.lbDoi.BackColor = System.Drawing.Color.Gray;
            this.lbDoi.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoi.ForeColor = System.Drawing.Color.Transparent;
            this.lbDoi.Location = new System.Drawing.Point(3, 336);
            this.lbDoi.Name = "lbDoi";
            this.lbDoi.Size = new System.Drawing.Size(54, 28);
            this.lbDoi.TabIndex = 5;
            this.lbDoi.Text = "Đôi";
            // 
            // lbDonVip
            // 
            this.lbDonVip.AutoSize = true;
            this.lbDonVip.BackColor = System.Drawing.Color.Gray;
            this.lbDonVip.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVip.ForeColor = System.Drawing.Color.Transparent;
            this.lbDonVip.Location = new System.Drawing.Point(3, 176);
            this.lbDonVip.Name = "lbDonVip";
            this.lbDonVip.Size = new System.Drawing.Size(110, 28);
            this.lbDonVip.TabIndex = 6;
            this.lbDonVip.Text = "Đơn VIP";
            // 
            // lbDon
            // 
            this.lbDon.AutoSize = true;
            this.lbDon.BackColor = System.Drawing.Color.Gray;
            this.lbDon.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDon.ForeColor = System.Drawing.Color.Transparent;
            this.lbDon.Location = new System.Drawing.Point(3, 14);
            this.lbDon.Name = "lbDon";
            this.lbDon.Size = new System.Drawing.Size(54, 28);
            this.lbDon.TabIndex = 7;
            this.lbDon.Text = "Đơn";
            // 
            // lvGiaDinh
            // 
            this.lvGiaDinh.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvGiaDinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvGiaDinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGiaDinh.LargeImageList = this.imageList1;
            this.lvGiaDinh.Location = new System.Drawing.Point(0, 678);
            this.lvGiaDinh.Name = "lvGiaDinh";
            this.lvGiaDinh.Size = new System.Drawing.Size(802, 105);
            this.lvGiaDinh.SmallImageList = this.imageList1;
            this.lvGiaDinh.TabIndex = 8;
            this.lvGiaDinh.UseCompatibleStateImageBehavior = false;
            this.lvGiaDinh.DoubleClick += new System.EventHandler(this.lvGiaDinh_DoubleClick);
            // 
            // lvDoiVIP
            // 
            this.lvDoiVIP.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvDoiVIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvDoiVIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDoiVIP.LargeImageList = this.imageList1;
            this.lvDoiVIP.Location = new System.Drawing.Point(0, 527);
            this.lvDoiVIP.Name = "lvDoiVIP";
            this.lvDoiVIP.Size = new System.Drawing.Size(802, 105);
            this.lvDoiVIP.SmallImageList = this.imageList1;
            this.lvDoiVIP.TabIndex = 9;
            this.lvDoiVIP.UseCompatibleStateImageBehavior = false;
            this.lvDoiVIP.DoubleClick += new System.EventHandler(this.lvDoiVIP_DoubleClick);
            // 
            // lvDoi
            // 
            this.lvDoi.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvDoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvDoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDoi.LargeImageList = this.imageList1;
            this.lvDoi.Location = new System.Drawing.Point(3, 367);
            this.lvDoi.Name = "lvDoi";
            this.lvDoi.Size = new System.Drawing.Size(799, 105);
            this.lvDoi.SmallImageList = this.imageList1;
            this.lvDoi.TabIndex = 10;
            this.lvDoi.UseCompatibleStateImageBehavior = false;
            this.lvDoi.DoubleClick += new System.EventHandler(this.lvDoi_DoubleClick);
            // 
            // lvDonVIP
            // 
            this.lvDonVIP.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvDonVIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvDonVIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDonVIP.LargeImageList = this.imageList1;
            this.lvDonVIP.Location = new System.Drawing.Point(3, 207);
            this.lvDonVIP.Name = "lvDonVIP";
            this.lvDonVIP.Size = new System.Drawing.Size(799, 105);
            this.lvDonVIP.SmallImageList = this.imageList1;
            this.lvDonVIP.TabIndex = 11;
            this.lvDonVIP.UseCompatibleStateImageBehavior = false;
            this.lvDonVIP.DoubleClick += new System.EventHandler(this.lvDonVIP_DoubleClick);
            // 
            // lvDon
            // 
            this.lvDon.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvDon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDon.LargeImageList = this.imageList1;
            this.lvDon.Location = new System.Drawing.Point(3, 45);
            this.lvDon.Name = "lvDon";
            this.lvDon.Size = new System.Drawing.Size(799, 105);
            this.lvDon.SmallImageList = this.imageList1;
            this.lvDon.TabIndex = 12;
            this.lvDon.UseCompatibleStateImageBehavior = false;
            this.lvDon.DoubleClick += new System.EventHandler(this.lvDon_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1104, 862);
            this.Controls.Add(this.panelPhong);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPhong.ResumeLayout(false);
            this.panelPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.Label lbGiaDinh;
        private System.Windows.Forms.Label lbDoiVIP;
        private System.Windows.Forms.Label lbDoi;
        private System.Windows.Forms.Label lbDonVip;
        private System.Windows.Forms.Label lbDon;
        private System.Windows.Forms.ListView lvGiaDinh;
        private System.Windows.Forms.ListView lvDoiVIP;
        private System.Windows.Forms.ListView lvDoi;
        private System.Windows.Forms.ListView lvDonVIP;
        private System.Windows.Forms.ListView lvDon;
        private System.Windows.Forms.Button btnLoadphong;
    }
}

