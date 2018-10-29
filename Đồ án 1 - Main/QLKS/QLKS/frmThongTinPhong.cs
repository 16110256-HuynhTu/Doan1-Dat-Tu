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
    public partial class frmThongTinPhong : Form
    {
        public frmThongTinPhong()
        {
            InitializeComponent();
        }

        //di chuyển form
        Boolean flag; int x, y;
        private void frmThongTinPhong_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmThongTinPhong_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void frmThongTinPhong_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
       
        //main
        private void frmThongTinPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadKH();
            DichVu();
        }
        // chuc nang
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //khach hang
        public int makh;
        public string gioitinh;
        public string hoten;
        public string email;
        public string diachi;
        public string cmnd;
        public string sdt;
        //load thohng tin khach hang
        void LoadKH()
        {
            lbMaKH.Text = Convert.ToString(makh);
            lbGioiTinh.Text = gioitinh;
            lbHoTenKH.Text = hoten;
            lbEmail.Text = email;
            lbDiaChi.Text = diachi;
            lbCMND.Text = cmnd;
            lbSDT.Text = sdt;
        }


        //phong
        public int madatphong;
        public int tenphong;
        public string loaiphong;
        //load thong tin phong
        void LoadPhong()
        {
            lbTenPhong.Text = Convert.ToString(tenphong);
            lbLoaiPhong.Text = loaiphong;
            lbMaDP.Text = Convert.ToString(madatphong);
        }

        //Load dichvu
        void DichVu()
        {
            //combobox
            BLLDichVu d = new BLLDichVu();
            var lp = d.LayLoaiDichVu();
            cbbDichVu.ValueMember = "TenLoaiDV";
            cbbDichVu.DisplayMember = "TenLoaiDV";
            cbbDichVu.DataSource = lp;
            //datagridview
            dgvCTDichVu.DataSource = d.LayDanhSachDichVu(madatphong);
        }

        // chuc nang
        private void btnThem_Click(object sender, EventArgs e)
        {
            BLLDichVu d = new BLLDichVu();
            var a = d.LayMaDichVu(cbbDichVu.SelectedValue.ToString());
            int maloaidv = a[0].MaLoaiDV;
            bool kq = d.KiemTraCTDichVu(madatphong, maloaidv);
            if(kq==true)
            {
                var s = d.LaySoLuong(madatphong, maloaidv);
                int soluong = Convert.ToInt32(nudSoLuong.Value) +s[0].SoLuong;
                d.CapNhapCTDichVu(madatphong,maloaidv, soluong);
            }
            else
            {
                d.ThemCTDichVu(madatphong, maloaidv, Convert.ToInt32(nudSoLuong.Value));
            }
            DichVu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvCTDichVu.CurrentCell.RowIndex;
            string tendv = dgvCTDichVu.Rows[r].Cells[0].Value.ToString().Trim();
            BLLDichVu d = new BLLDichVu();
            var a = d.LayMaDichVu(tendv);
            int maloaidv = a[0].MaLoaiDV;
            d.XoaCTDichVu(madatphong, maloaidv);
            DichVu();
        }
        //nhan vien
        public int _manv;
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon h = new frmHoaDon();
            h._madp = madatphong;
            h._tenphong = tenphong;
            h._loaiphong = loaiphong;
            h._makh = makh;
            h._hoten = hoten;
            h._diachi = diachi;
            h._gioitinh = gioitinh;
            h._sdt = sdt;
            h._manv = _manv;
            h.ShowDialog();
        }

        

        
    }
}
