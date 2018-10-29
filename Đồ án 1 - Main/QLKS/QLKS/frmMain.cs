using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace QLKS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        //id va pass
        public string id;
        public string pass;
        //lay ma nhan vien 


        //di chuyển form
        Boolean flag; int x, y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        // ẩn hoặc hiện menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelChucNang.Width >= 221)
            {
                panelChucNang.Width = 60;
                panelPhong.Location = new Point(65, 47);
                panelPhong.Width = 800;
                lvDon.Width = 760;
                lvDonVIP.Width = 760;
                lvDoi.Width = 760;
                lvDoiVIP.Width = 760;
                lvGiaDinh.Width = 760;
            }
            else
            {
                panelChucNang.Width = 221;
                panelPhong.Location = new Point(225, 47);
                lvDon.Width = 600;
                lvDonVIP.Width = 600;
                lvDoi.Width = 600;
                lvDoiVIP.Width = 600;
                lvGiaDinh.Width = 600;
            }
        }
        // ẩn chương trình 
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Main
        private void frmMain_Load(object sender, EventArgs e)
        {
            Quyen();
            LayPhongDon();
            LayPhongDonVip();
            LayPhongDoi();
            LayPhongDoiVip();
            LayPhongGiaDinh();
            
        }
        //lấy phòng đơn
        void LayPhongDon()
        {
            BLLPhong p = new BLLPhong();
            var a = p.LayDanhSachPhong("Đơn");
            lvDon.Clear();
            lvDon.View = View.LargeIcon;
            for (int i = 0; i < a.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                if (a[i].TinhTrang == "True")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.Text = Convert.ToString(a[i].MaPhong);
                lvDon.Items.Add(item);
            }
        }
        //lấy phòng đơn VIP
        void LayPhongDonVip()
        {
            BLLPhong p = new BLLPhong();
            var a = p.LayDanhSachPhong("Đơn VIP");
            lvDonVIP.Clear();
            lvDon.View = View.LargeIcon;
            for(int i=0;i<a.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                if(a[i].TinhTrang=="True")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.Text = Convert.ToString(a[i].MaPhong);
                lvDonVIP.Items.Add(item);
            }
        }
        //lấy phòng Đôi 
        void LayPhongDoi()
        {
            BLLPhong p = new BLLPhong();
            var a = p.LayDanhSachPhong("Đôi");
            lvDoi.Clear();
            lvDoi.View = View.LargeIcon;
            for (int i = 0; i < a.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                if (a[i].TinhTrang == "True")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.Text = Convert.ToString(a[i].MaPhong);
                lvDoi.Items.Add(item);
            }
        }
        //lấy phòng Đôi VIP
        void LayPhongDoiVip()
        {
            BLLPhong p = new BLLPhong();
            var a = p.LayDanhSachPhong("Đôi VIP");
            lvDoiVIP.Clear();
            lvDoiVIP.View = View.LargeIcon;
            for(int i=0;i<a.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                if(a[i].TinhTrang=="True")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.Text = Convert.ToString(a[i].MaPhong);
                lvDoiVIP.Items.Add(item);
            }
        }
        //lấy phòng Gia đình
        void LayPhongGiaDinh()
        {
            BLLPhong p = new BLLPhong();
            var a = p.LayDanhSachPhong("Gia đình");
            lvGiaDinh.Clear();
            lvGiaDinh.View = View.LargeIcon;
            for(int i=0;i<a.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                if(a[i].TinhTrang=="True")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.Text = Convert.ToString(a[i].MaPhong);
                lvGiaDinh.Items.Add(item);
            }
        }
        //Phòng
        //bien ten phong
        public int _tenphong;
        public int _makh;
        private void lvDon_DoubleClick(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvDon.SelectedItems[0].Text.Trim());
            LayThongTin(lvDon,lbDon);
        }

        private void lvDonVIP_DoubleClick(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvDonVIP.SelectedItems[0].Text.Trim());
            LayThongTin(lvDonVIP,lbDonVip);
        }

        private void lvDoi_DoubleClick(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvDoi.SelectedItems[0].Text.Trim());
            LayThongTin(lvDoi,lbDoi);
        }

        private void lvDoiVIP_DoubleClick(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvDoiVIP.SelectedItems[0].Text.Trim());
            LayThongTin(lvDoiVIP,lbDoiVIP);
        }

        private void lvGiaDinh_DoubleClick(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvGiaDinh.SelectedItems[0].Text.Trim());
            LayThongTin(lvGiaDinh,lbGiaDinh);
        }

        
        // chuc nang 
        //
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong dp = new frmDatPhong();
            BLLNhanVien n = new BLLNhanVien();
            var nv = n.LayMaNV(id, pass);
            int Manv = nv[0].MaQuyen;
            dp._manv = Manv;
            dp.ShowDialog();
        }
        //
        private void btnPhong_Click(object sender, EventArgs e)
        {
            frmPhong p = new frmPhong();
            p.ShowDialog();
        }
        //
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu d = new frmDichVu();
            d.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmThongKeHoaDon h = new frmThongKeHoaDon();
            h.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }
        // phân quyền admin và nhân viên 
        void Quyen()
        {
            BLLPhanQuyen p = new BLLPhanQuyen();
            var quyen = p.QuyenNhanVien(id, pass);
            int flag =Convert.ToInt32(quyen[0].MaPQ);
            if(flag==2)  // nhân viên
            {
                btnNhanVien.Enabled = false;
                btnHoaDon.Enabled = false;
            }
        }
        // load phòng
        private void button1_Click(object sender, EventArgs e)
        {
            XetTrangThaiPhong();
            LoadPhong();
            XoaListViewCu();
            LayPhongDon();
            LayPhongDonVip();
            LayPhongDoi();
            LayPhongDoiVip();
            LayPhongGiaDinh();
        }
        //  
        void LoadPhong()
        {
            BLLPhong p = new BLLPhong();
            var dp = p.ListDatPhong();
            string result = DateTime.Now.ToString("yyyy.MM.dd");
            DateTime mydate = DateTime.Parse(result);
            for (int i = 0; i < dp.Count(); i++)
            {
                string tinhtrang = "True";
                if (dp[i].flag==1)   // phiếu đặt phòng chưa xài.
                {
                    int a = DateTime.Compare(mydate, dp[i].NgayDen);
                    int b = DateTime.Compare(mydate, dp[i].NgayDi);
                    if (a >= 0 && b <= 0)
                    {
                        tinhtrang = "False";
                    }
                }
                p.CapNhapPhong(dp[i].MaPhong, tinhtrang);
            }
        }

        // xét trạng thái phiếu đặt phòng ( 0: đã hoành thành / 1: chưa hoàn thành )
        void XetTrangThaiPhong()
        {
            BLLPhong p = new BLLPhong();
            var dp = p.ListDatPhong();
            string result = DateTime.Now.ToString("yyyy.MM.dd");
            DateTime mydate = DateTime.Parse(result);
            for (int i = 0; i < dp.Count(); i++)
            {
                int b = DateTime.Compare(mydate, dp[i].NgayDi);
                bool kq = p.DemHD(dp[i].MaDP);
                int flag = 0;
                if (b <= 0 && kq==false)
                {
                    flag = 1;
                }
                p.CapNhapFlagDatPhong(flag,dp[i].MaDP);
            }
        }
        // xóa các list phòng cũ
        void XoaListViewCu()
        {
            lvDon.Clear();
            lvDonVIP.Clear();
            lvDoi.Clear();
            lvDoiVIP.Clear();
            lvGiaDinh.Clear();
        }

        //lay  thong tin cho form thong tin phong
        void LayThongTin(ListView a , Label _loaiphong)
        {
            BLLKhachHang k = new BLLKhachHang();
            var b=k.ThongTinKhachHang(_tenphong);
           
            frmThongTinPhong t = new frmThongTinPhong();
            if (a.SelectedItems[0].ImageIndex == 1)
            {
                BLLPhong p = new BLLPhong();
                var c = p.LayMaDatPhongTheoMaKH(b[0].MaKH);
                //khach hang.
                t.makh = b[0].MaKH;
                t.hoten = b[0].HoTen;
                t.diachi = b[0].DiaChi;
                t.email = b[0].Email;
                t.gioitinh = b[0].GioiTinh;
                t.cmnd = b[0].CMND;
                t.sdt = b[0].SDT;
                //phong
                t.madatphong = c[0].MaDP;
                //nhan vien
                BLLNhanVien n = new BLLNhanVien();
                var nv = n.LayMaNV(id, pass);
                int Manv = nv[0].MaQuyen;
                t._manv = Manv;
            }
            t.tenphong = _tenphong;
            t.loaiphong = _loaiphong.Text;
            t.ShowDialog();
        }
    }
}
