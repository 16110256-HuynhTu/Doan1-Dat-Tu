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
    public partial class frmPhong : Form
    {
        public frmPhong()
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
        //
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            txtMaPhong.Text = dgvPhong.Rows[r].Cells[0].Value.ToString();
            cbbLoaiPhong.SelectedValue = dgvPhong.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiPhong.CurrentCell.RowIndex;
            txtMaLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvLoaiPhong.Rows[r].Cells[2].Value.ToString();
            txtGiaPhong.Text = dgvLoaiPhong.Rows[r].Cells[3].Value.ToString();
        }
        //Main
        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadLoaiPhong();
           
            
        }

        //chuc nang
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            BLLPhong p = new BLLPhong();
            var a = p.layMaLP(cbbLoaiPhong.SelectedValue.ToString());
            p.themPhong(Convert.ToInt32(txtMaPhong.Text), a[0].MaLP, "True");
            p.capNhapLoaiPhong(a[0].MaLP, a[0].SoLuong + 1);
            LoadPhong();
            LoadLoaiPhong();
            txtMaPhong.ResetText();
        }
        //
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            BLLPhong p = new BLLPhong();
            p.xoaPhong(Convert.ToInt32(txtMaPhong.Text));
            LoadPhong();
        }
        //
        private void btnThemLoaiP_Click(object sender, EventArgs e)
        {
            BLLPhong p = new BLLPhong();
            p.themLoaiPhong(Convert.ToInt32(txtMaLoaiPhong.Text), txtTenLoaiPhong.Text, 0, Convert.ToInt32(txtGiaPhong.Text));
            LoadLoaiPhong();
            LoadPhong();
            txtMaLoaiPhong.ResetText();
            txtSoLuong.ResetText();
            txtTenLoaiPhong.ResetText();
            txtGiaPhong.ResetText();
        }
        //
        private void btnXoaLoaiP_Click(object sender, EventArgs e)
        {
            BLLPhong p = new BLLPhong();
            p.xoaLoaiPhong(Convert.ToInt32(txtMaLoaiPhong.Text));
            LoadLoaiPhong();
            LoadPhong();
        }
        // ham con 
        //
        void LoadPhong()
        {
            BLLPhong p = new BLLPhong();
            // datagirdview cua phong
            dgvPhong.DataSource = p.layListMaPhongVaTenLP();
            //combobox cua phong 
            cbbLoaiPhong.ValueMember = "TenLP";
            cbbLoaiPhong.DisplayMember = "TenLP";
            cbbLoaiPhong.DataSource = p.layListLoaiPhong();
        }

        //
        void LoadLoaiPhong()
        {
            BLLPhong p = new BLLPhong();
            //datagirdview cua loai phong
            dgvLoaiPhong.DataSource = p.layListLoaiPhong();
            //dem phong trong
            lbSoPhongTrong.Text = p.DemPhongTrong().ToString();
        }

    }
}
