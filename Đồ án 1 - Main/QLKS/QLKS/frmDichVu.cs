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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
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

        //main
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDV();
            btnSave.Enabled=false;
            btnCancel.Enabled = false;
        }

        //chuc nang 
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btnSetting_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSetting.Enabled = false;
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            BLLDichVu d = new BLLDichVu();
            d.themDV(Convert.ToInt32(txtMaLoaiDV.Text), txtTenDV.Text, Convert.ToInt32(txtGiaDV.Text));
            LoadDV();
        }
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLLDichVu d = new BLLDichVu();
            d.xoaDV(Convert.ToInt32(txtMaLoaiDV.Text));
            LoadDV();
        }
        //
        private void btnSave_Click(object sender, EventArgs e)
        {
            BLLDichVu d = new BLLDichVu();
            d.capNhapDV(Convert.ToInt32(txtMaLoaiDV.Text), txtTenDV.Text, Convert.ToInt32(txtGiaDV.Text));
            LoadDV();
        }
        //
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSetting.Enabled = true;
        }


        //ham con
        //
        void LoadDV()
        {
            BLLDichVu d = new BLLDichVu();
            dgvDichVu.DataSource = d.LayLoaiDichVu();
        }
         //
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDichVu.CurrentCell.RowIndex;
            txtMaLoaiDV.Text = dgvDichVu.Rows[r].Cells[0].Value.ToString();
            txtTenDV.Text = dgvDichVu.Rows[r].Cells[1].Value.ToString();
            txtGiaDV.Text = dgvDichVu.Rows[r].Cells[2].Value.ToString();
        }

    }
}
