using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BLLKhachHang
    {
        QLKSDataContext db = null;
        public BLLKhachHang()
        {
            db = new QLKSDataContext();
        }
        //
        public  int LayMaKH()
        {
            int kq = (from p in db.KhachHangs
                      select p.MaKH).Max();
            return kq;
        }
        //
        public  void themKH(int makh , string hoten , string gioitinh , string cmnd , string sdt , string email , string diachi)
        {
            db.spInsertKhachHang(makh,hoten,gioitinh,cmnd,sdt,email,diachi);
        }
        //
        public List<KhachHang> ThongTinKhachHang(int tenphong)
        {
            var kq = from k in db.KhachHangs
                     join d in db.DatPhongs on k.MaKH equals d.MaKH
                     where d.MaPhong==tenphong && d.flag==1
                     select k;
            return kq.ToList();
        }
        //
        public List<KhachHang> LayKH()
        {
            return db.KhachHangs.ToList();
        }
        //
        public void XoaKH(int MaKH)
        {
            QLKSDataContext db = new QLKSDataContext();
            KhachHang kh = db.KhachHangs.Single(p => p.MaKH == MaKH);
            db.KhachHangs.DeleteOnSubmit(kh);
            db.SubmitChanges();
        }
        //
        public void ThemKH(int MaKH, string HoTen, string GioiTinh, string CMND, string SDT, string Email, string DiaChi)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.HoTen = HoTen;
            kh.GioiTinh = GioiTinh;
            kh.CMND = CMND;
            kh.SDT = SDT;
            kh.DiaChi = DiaChi;
            kh.Email = Email;
            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        //
        public void SuaKH(int MaKH, string HoTen, string GioiTinh, string CMND, string SDT, string Email, string DiaChi)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.HoTen = HoTen;
            kh.GioiTinh = GioiTinh;
            kh.CMND = CMND;
            kh.SDT = SDT;
            kh.DiaChi = DiaChi;
            kh.Email = Email;
            db.SubmitChanges();
        }
    }
}
