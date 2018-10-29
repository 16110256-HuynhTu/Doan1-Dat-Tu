using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace BusinessLayer
{
    public class BLLHoaDon
    {
        QLKSDataContext db = null;
        public BLLHoaDon()
        {
            db = new QLKSDataContext();
        }

        public int LayMaHD()
        {
            int kq = (from p in db.HoaDons
                      select p.MaHD).Max();
            return kq;
        }

        public List<LoaiPhong> LayGiaPhong(string tenphong)
        {
            var kq = from l in db.LoaiPhongs
                     where l.TenLP == tenphong
                     select l;
            return kq.ToList();
        }

        //form thong tin hoa don 
        public class HOADON
        {
            public int _mahd { get; set; }
            public int _tienphong { get; set; }
            public int _tiendv { get; set; }
            public int _tongtien { get; set; }
            public DateTime _ngaylap { get; set; }
            public string _nv { get; set; }
            public string _kh { get; set; } 
            public int _madp { get; set; }
        }

        public List<HOADON> LayDanhSachHD()
        {
            var kq = from h in db.HoaDons
                     join n in db.NhanViens on h.MaNV equals n.MaNV
                     join k in db.KhachHangs on h.MaKH equals k.MaKH
                     select new HOADON
                     {
                         _mahd = h.MaHD,
                         _tienphong = Convert.ToInt32(h.TienPhong),
                         _tiendv = Convert.ToInt32(h.TienDV),
                         _tongtien = Convert.ToInt32(h.TongTien),
                         _ngaylap = Convert.ToDateTime(h.NgayLap),
                         _nv = n.HoTen,
                         _kh = k.HoTen,
                         _madp = Convert.ToInt32(h.MaDP)
                     };
            return kq.ToList();
        }

        public void ThemHoaDon(int mahd , string httt, int tienphong , int tiendv , int tongtien , DateTime ngaylap , string tinhtrang , int manv , int makh , int madp)
        {
            db.spInsertHoaDon(mahd, httt, tienphong, tiendv, tongtien, ngaylap, tinhtrang, manv, makh, madp);
        }
    }
}
