using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace BusinessLayer
{
    public class BLLPhanQuyen
    {
        QLKSDataContext db = null;
        public BLLPhanQuyen()
        {
            db = new QLKSDataContext();
        }

        public  bool DangNhap(string id , string pass)
        {
            var kq = (from n in db.NhanViens
                      join q in db.QuyenNVs on n.MaNV equals q.MaQuyen
                      where q.ID == id && q.MatKhau == pass
                      select q).Count();
            if(kq>0)
                return true;
            else
                return false;
        }
       
        public  List<NhanVien> QuyenNhanVien(string id , string pass)
        {
            var kq = from n in db.NhanViens
                      join q in db.QuyenNVs on n.MaNV equals q.MaQuyen
                      where q.ID == id && q.MatKhau == pass
                      select n;
            return kq.ToList();
        }

        public List<PhanQuyen> LayPQ()
        {
            return db.PhanQuyens.ToList();
        }

    }
}
