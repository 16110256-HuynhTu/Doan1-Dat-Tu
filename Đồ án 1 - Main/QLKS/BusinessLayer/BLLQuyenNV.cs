using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace BusinessLayer
{
    public class BLLQuyenNV
    {
        QLKSDataContext db = null;
        public BLLQuyenNV()
        {
            db = new QLKSDataContext();
        }

        public List<PhanQuyen> LayPQ()
        {
            return db.PhanQuyens.ToList();
        }

        public List<ChucVu> LayCV()
        {
            return db.ChucVus.ToList();
        }

        public List<QuyenNV> LayQuyenNV()
        {
            return db.QuyenNVs.ToList();
        }

    }
}
