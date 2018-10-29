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
    public partial class frmThongKeHoaDon : Form
    {
        public frmThongKeHoaDon()
        {
            InitializeComponent();
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            lbMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            DateTime ngaynhan =Convert.ToDateTime(dgvHoaDon.Rows[r].Cells[4].Value.ToString());
            lbNgayLap.Text = ngaynhan.ToString("mm/dd/yyyy");
            lbNV.Text = dgvHoaDon.Rows[r].Cells[6].Value.ToString();
            lbKH.Text = dgvHoaDon.Rows[r].Cells[7].Value.ToString();
            lbMaDP.Text = dgvHoaDon.Rows[r].Cells[8].Value.ToString();
        }



        //ham con 
        //
        //Load hoadon 
        void LoadHD()
        {
            BLLHoaDon h = new BLLHoaDon();
            dgvHoaDon.DataSource = h.LayDanhSachHD();
        }
    }
}
