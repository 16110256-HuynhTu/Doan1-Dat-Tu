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
using DataProvider;

namespace QLKS
{
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }

        //di chuyển form
        Boolean flag; int x, y;

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            GioiTinh();
            LoaiPhong();
            //LoadPhong();
            //ma khach hang
            BLLKhachHang kh = new BLLKhachHang();
            int _makh = kh.LayMaKH();
            txtMaKH.Text = Convert.ToString(_makh + 1);
            //ma phong 
            BLLPhong p = new BLLPhong();
            int _madatdp = p.LayMaDatPhong();
            txtMaDatPhong.Text = Convert.ToString(_madatdp + 1);

        }

        private void rtbGhiChu_Click(object sender, EventArgs e)
        {
            rtbGhiChu.Clear();
            if(rtbGhiChu.Text=="")
            {
                rtbGhiChu.Text = "NULL";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //combobox 
        void GioiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedItem= "Nam";
        }

        void LoaiPhong()
        {
            BLLPhong p = new BLLPhong();
            var lp = p.LayDanhSachLoaiPhong();
            cbbLoaiPhong.ValueMember = "TenLP";
            cbbLoaiPhong.DisplayMember = "TenLP";
            cbbLoaiPhong.DataSource = lp;
        }

        // lay thong tin phong len listview
        void LayPhongTheoLoaiPhong(string a)
        {
            BLLPhong p = new BLLPhong();
            var lp = p.LayPhongTheoLoaiPhong(a);
            lvChonPhong.Clear();
            lvChonPhong.View = View.LargeIcon;
            for (int i = 0; i < lp.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = Convert.ToString(lp[i].MaPhong);
                lvChonPhong.Items.Add(item);
            }
        }

        // thay đổi phòng khi chọn thể loại phòng 
        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayPhongTheoLoaiPhong(cbbLoaiPhong.Text);

        }
        //
        public int _tenphong;
        public int _manv;
        private void lvChonPhong_Click(object sender, EventArgs e)
        {
            _tenphong = Convert.ToInt32(lvChonPhong.SelectedItems[0].Text);
            
        }

        // các chức năng
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // về khách hàng
            int _makh = Convert.ToInt32(txtMaKH.Text);
            BLLKhachHang kh = new BLLKhachHang();
            kh.ThemKH(_makh, txtHoTenKH.Text, cbbGioiTinh.Text, txtCMND.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
            // về đặt phòng 
            BLLPhong p = new BLLPhong();
            int _madatphong = Convert.ToInt32(txtMaDatPhong.Text);
            DateTime _ngaynhan = DateTime.Parse(dtpNhan.Text);
            DateTime _ngaytra = DateTime.Parse(dtpTra.Text);
            DateTime _ngaylap = DateTime.Parse(dtpLap.Text);
            p.ThemDatPhong(_madatphong, _ngaynhan, _ngaytra, _ngaylap, rtbGhiChu.Text, _manv, _tenphong, _makh);
            // update tình trạng phòng
            var l = p.LayMaDatPhongTheoMaPhong(_madatphong);
            int _maphong = l[0].MaPhong;
            string tinhtrang="False";
            p.CapNhapPhong(_maphong, tinhtrang);
            MessageBox.Show("Đặt Phòng Thành công ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dtpNhan_ValueChanged(object sender, EventArgs e)
        {
            //LoadPhong();
        }

        //public void LoadPhong()
        //{
        //    BLLPhong p = new BLLPhong();
        //    DateTime _ngaynhan = DateTime.Parse(dtpNhan.Text);
        //    DateTime _ngaytra = DateTime.Parse(dtpTra.Text);
        //    string result = DateTime.Now.ToString("yyyy.MM.dd");
        //    DateTime mydate = DateTime.Parse(result);
        //    int a = DateTime.Compare(mydate, _ngaynhan);
        //    int b = DateTime.Compare(mydate, _ngaytra);
        //    string tinhtrang="True";
        //    if (a >= 0 && b <= 0)
        //    {
        //        tinhtrang = "False";
        //    }
        //    BLLPhong.LoadPhong(tinhtrang);
        //}




    }
}
