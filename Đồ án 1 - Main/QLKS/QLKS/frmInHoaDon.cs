using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        public int mahd;
        public int madp;
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'QLKSDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.QLKSDataSet.HoaDon,mahd);
            // TODO: This line of code loads data into the 'QLKSDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.QLKSDataSet.KhachHang,mahd);
            // TODO: This line of code loads data into the 'QLKSDataSet.DatPhong_LoaiDV' table. You can move, or remove it, as needed.
            this.DatPhong_LoaiDVTableAdapter.Fill(this.QLKSDataSet.DatPhong_LoaiDV,madp);


            this.reportViewer1.RefreshReport();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}
