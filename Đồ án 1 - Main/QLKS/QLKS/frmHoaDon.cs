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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        //di chuyển form
        Boolean flag; int x, y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            
        }    
        //
        public int _madp;
        public int _manv;
        public int _tenphong;
        public string _loaiphong;
        public int _makh;
        public string _gioitinh;
        public string _hoten;
        public string _diachi;
        public string _sdt;
        public int _mahd;

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            BLLPhong p = new BLLPhong();
            var n = p.LayNgayTraTheoMaDP(_madp);
            BLLHoaDon h = new BLLHoaDon();
            lbMaDP.Text =Convert.ToString(_madp);
            lbTenPhong.Text =Convert.ToString(_tenphong);
            lbLoaiPhong.Text = _loaiphong;
            _mahd = h.LayMaHD();
            lbMaHD.Text = Convert.ToString(_mahd + 1);
            lbMaNV.Text = Convert.ToString(_manv);
            lbMaKH.Text = Convert.ToString(_makh);
            lbHoTenKH.Text = _hoten;
            lbGioiTinh.Text = _gioitinh;
            lbDiaChi.Text = _diachi;
            lbNgayNhan.Text = n[0].NgayDen.ToString("MM/dd/yyyy");
            lbNgayTra.Text = n[0].NgayDi.ToString("MM/dd/yyyy");
            //
            LoadDV();
            //tính tiền
            //tien phong
            var g = h.LayGiaPhong(_loaiphong);
            int giaphong =Convert.ToInt32(g[0].GiaPhong);
            lbTienPhong.Text = Convert.ToString(giaphong);

            //tien dich vu
            int tiendv = LayTienDichVu();
            lbTienDV.Text = tiendv.ToString();
            //tong tien
            
            int soGioSuDung = (n[0].NgayDi - n[0].NgayDen).Days;
            int tongtien = tiendv + (giaphong * soGioSuDung);
            lbTongTien.Text = tongtien.ToString();
        }

        //Load dich vu
        void LoadDV()
        {
            BLLDichVu d = new BLLDichVu();
            dgvCTDichVu.DataSource = d.LayDanhSachDichVu(_madp);
        }

        //tien dich vu 
        int LayTienDichVu()
        {
            BLLDichVu d = new BLLDichVu();
            var s =d.LayDanhSachDichVu(_madp);
            int tiendv = 0;
            for(int i=0;i<s.Count;i++)
            {
                int soluong = s[i]._soLuong;
                int giatien = s[i]._gia;
                tiendv = tiendv + (soluong * giatien);
            }
            return tiendv;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = DateTime.Now;
            BLLHoaDon h = new BLLHoaDon();
            h.ThemHoaDon(Convert.ToInt32(lbMaHD.Text), "Tiền mặt", Convert.ToInt32(lbTienPhong.Text), Convert.ToInt32(lbTienDV.Text), Convert.ToInt32(lbTongTien.Text), ngaylap, "True", _manv, _makh, _madp);
            BLLPhong p = new BLLPhong();
            p.CapNhapPhong(_madp, "True");
            frmInHoaDon i = new frmInHoaDon();
            i.mahd = _mahd;
            i.madp = _madp;
            i.ShowDialog();
        }

        //chuc nang
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
