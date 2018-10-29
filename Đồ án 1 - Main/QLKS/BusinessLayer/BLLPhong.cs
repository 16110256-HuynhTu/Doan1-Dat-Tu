using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace BusinessLayer
{
    public class BLLPhong
    {
        QLKSDataContext db = null;
        public BLLPhong()
        {
            db = new QLKSDataContext();
        }

        public  List<Phong> LayDanhSachPhong(string loaiphong)
        {
            var td =
                    from s in db.Phongs
                    join r in db.LoaiPhongs on s.MaLP equals r.MaLP
                    where r.TenLP == loaiphong
                    select s;
            return td.ToList();

        }

        public  List<LoaiPhong> LayDanhSachLoaiPhong()
        {
            var kq = from p in db.LoaiPhongs
                     select p;
            return kq.ToList();
        }

        public  List<Phong> LayPhongTheoLoaiPhong(string a)
        {
            var kq = from p in db.Phongs
                     join lp in db.LoaiPhongs on p.MaLP equals lp.MaLP
                     where lp.TenLP == a && p.TinhTrang == "True"
                     select p;
            return kq.ToList();
        }

        public int LayMaDatPhong()
        {
            int kq = (from p in db.DatPhongs
                      select p.MaDP).Max();
            return kq;
        }

        public  void ThemDatPhong(int madp , DateTime ngayden , DateTime ngaydi , DateTime ngaylap , string ghichu , int manv , int maphong , int makh)
        {
            db.spInsertDatPhong(madp, ngayden, ngaydi, ngaylap, ghichu, manv, maphong, makh);
        }

        public  List<DatPhong> LayMaDatPhongTheoMaPhong(int madatphong)
        {
            var kq = from p in db.DatPhongs
                     where p.MaDP == madatphong
                     select p;
            return kq.ToList();
        }

        public  void CapNhapPhong(int maphong , string tinhtrang)
        {
            db.spUpdatePhong(maphong, tinhtrang);
        }

        public  void LoadPhong(string tinhtrang)
        {
            db.spLoadPhong(tinhtrang);
        }

        public  List<DatPhong> ListDatPhong()
        {
            var kq = from p in db.DatPhongs
                     select p;
            return kq.ToList();
        }

        public void CapNhapFlagDatPhong(int flag ,int madatphong )
        {
            db.spUpdateFlagDatPhong(flag, madatphong);
        }

        public List<DatPhong> LayMaDatPhongTheoMaKH(int makh)
        {
            var kq = from d in db.DatPhongs
                     where d.MaKH == makh
                     select d;
            return kq.ToList();
        }

        public List<DatPhong> LayNgayTraTheoMaDP(int madatphong)
        {
            var kq = from d in db.DatPhongs
                     where d.MaDP == madatphong
                     select d;
            return kq.ToList();
        }


        // form Phong
        public class PHONG
        {
            public int _maphong { get; set; }
            public string _loaiphong { get; set; }
        }

        public List<PHONG> layListMaPhongVaTenLP()
        {
            var kq = from p in db.Phongs
                     join l in db.LoaiPhongs on p.MaLP equals l.MaLP
                     select new PHONG
                     {
                         _maphong = p.MaPhong,
                         _loaiphong = l.TenLP
                     };
            return kq.ToList();
        }

        public List<LoaiPhong> layListLoaiPhong()
        {
            var kq = from l in db.LoaiPhongs
                     select l;
            return kq.ToList();
        }

        public int DemPhongTrong()
        {
            int kq = (from p in db.Phongs
                      where p.TinhTrang == "True"
                      select p).Count();
            return kq;
        }

        public void xoaPhong(int maphong)
        {
            db.spDeletePhong(maphong);
        }

        public void xoaLoaiPhong(int malp)
        {
            db.spDeleteLoaiPhong(malp);
        }

        public void themPhong(int maphong,int malp,string tinhtrang)
        {
            db.spInsertPhong(maphong, malp, tinhtrang);
        }

        public void themLoaiPhong(int malp, string tenlp , int soluong , int giaphong)
        {
            db.spInsertLoaiPhong(malp, tenlp, soluong, giaphong);
        }

        public List<LoaiPhong> layMaLP(string tenlp)
        {
            var kq = from l in db.LoaiPhongs
                     where l.TenLP == tenlp
                     select l;
            return kq.ToList();
        }

        public void capNhapLoaiPhong(int malp , int soluong)
        {
            db.spUpdateLoaiPhong(malp, soluong);
        }

        public class HOADON
        {
            public int _mahd { get; set; }
        }

        public bool DemHD(int madp)
        {
            int kq = (from h in db.HoaDons
                      where h.MaDP == madp
                      select h).Count();
            if(kq>0)
            {
                return true;
            }
            return false;
        }

    }
}
