using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace BusinessLayer
{
    public class CTDichVu
    {
        public string _tenDichVu { get; set; }
        public int _soLuong { get; set; }
        public int _gia { get; set; }
    }

    public class BLLDichVu
    {
        QLKSDataContext db = null;
        public BLLDichVu()
        {
            db = new QLKSDataContext();
        }

        public List<LoaiDV> LayLoaiDichVu()
        {
            var kq = from l in db.LoaiDVs
                     select l;
            return kq.ToList();
        }
        //lay ma dich vu 
        public List<LoaiDV> LayMaDichVu(string tendichvu)
        {
            var kq = from l in db.LoaiDVs
                     where l.TenLoaiDV == tendichvu
                     select l;
            return kq.ToList();
        }
        // thong tin dua len datagridview
        public List<CTDichVu> LayDanhSachDichVu(int madatphong)
        {
            var kq = from l in db.LoaiDVs
                     join d in db.DatPhong_LoaiDVs on l.MaLoaiDV equals d.MaLoaiDV
                     where d.MaDP == madatphong
                     select new CTDichVu
                     {
                         _tenDichVu = l.TenLoaiDV,
                         _soLuong = d.SoLuong,
                         _gia = l.GiaDV
                     };
            return kq.ToList();
        }

        //them dich vu
        public void ThemCTDichVu(int madp , int maloaidv , int soluong)
        {
            db.spInsertCTDichVU(madp, maloaidv, soluong);
        }

        //delete
        public void XoaCTDichVu(int madp , int maloaidv)
        {
            db.spDeleteCTDichVu(madp,maloaidv);
        }

        //cap nhap
        public void CapNhapCTDichVu(int madp,int maloaidv,int soluong )
        {
            db.spUpdateCTDichVu(madp,maloaidv, soluong);
        }
        
        //kiem tra
        public bool KiemTraCTDichVu(int madp , int maloaidv)
        {
            var kq = (from d in db.DatPhong_LoaiDVs
                      where d.MaDP == madp && d.MaLoaiDV == maloaidv
                      select d).Count();

            if (kq > 0)
                return true;
            else
                return false;
        }

        //lay so luong phong theo  madatphong va maloaidv

        public List<DatPhong_LoaiDV> LaySoLuong(int madp , int maloaidv)
        {
            var kq = from d in db.DatPhong_LoaiDVs
                     where d.MaDP == madp && d.MaLoaiDV == maloaidv
                     select d;
            return kq.ToList();
        }

        //form DichVu
        //
        
        public void themDV(int maloaidv , string tenloaidv , int giadv)
        {
            db.spInsertDichVu(maloaidv, tenloaidv, giadv);
        }

        public void xoaDV(int maloaidv)
        {
            db.spDeleteDichVu(maloaidv);
        }

        public void capNhapDV(int maloaidv, string tenloaidv, int giadv)
        {
            db.spUpdateDichVu(maloaidv, tenloaidv, giadv);
        }
    }
}
