using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

using System.Windows.Forms;

namespace BusinessLayer
{
    public class BLLNhanVien
    {
        QLKSDataContext db = null;
        public BLLNhanVien()
        {
            db = new QLKSDataContext();
        }
        //
        public  List<QuyenNV> LayMaNV(string id , string pass)
        {
            var kq = from q in db.QuyenNVs
                     where q.ID == id && q.MatKhau == pass
                     select q;
            return kq.ToList();
        }
        //
        public List<NhanVien> LayNV()
        {
            return db.NhanViens.ToList();
        }
        //
        public void LayQuyenNVvsPQvsCV(List<QuyenNV> Quyen, List<PhanQuyen> pq, List<ChucVu> cv, DataGridView dgv)
        {
            var td = from p in LayNV()
                     join o in Quyen on p.MaQuyen equals o.MaQuyen

                     join s in pq on p.MaPQ equals s.MaPQ

                     join m in cv on p.MaCV equals m.MaCV
                     select new
                     {
                         MaNV = p.MaNV,
                         HoTen = p.HoTen,
                         NgaySinh = p.NgaySinh,
                         GioiTinh = p.GioiTinh,
                         CMND = p.CMND,
                         SDT = p.SDT,
                         DiaChi = p.DiaChi,
                         Email = p.Email,
                         MaQuyen = o.MaQuyen,
                         MaPQ = s.MaPQ,
                         TenCV = m.TenCV

                     };
            dgv.DataSource = td.ToList();
        }
        //
        public void XoaNV(int MaNV)
        {

            db.SubmitChanges();
        }
        //
        public void ThemNV(int MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string DiaChi, string Email, int MaQuyen, int MaPQ, int MaCV)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.HoTen = HoTen;
            nv.NgaySinh = NgaySinh;
            nv.GioiTinh = GioiTinh;
            nv.CMND = CMND;
            nv.SDT = SDT;
            nv.DiaChi = DiaChi;
            nv.Email = Email;
            nv.MaQuyen = MaQuyen;
            nv.MaPQ = MaPQ;
            nv.MaCV = MaCV;
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
        }
        //
        public void SuaNV(int MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string DiaChi, string Email, int MaQuyen, int MaPQ, int MaCV)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.HoTen = HoTen;
            nv.NgaySinh = NgaySinh;
            nv.GioiTinh = GioiTinh;
            nv.CMND = CMND;
            nv.SDT = SDT;
            nv.DiaChi = DiaChi;
            nv.Email = Email;
            nv.MaQuyen = MaQuyen;
            nv.MaPQ = MaPQ;
            nv.MaCV = MaCV;
            db.SubmitChanges();
        }



    }
}
