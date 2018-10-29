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
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
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

        BLLKhachHang kh = new BLLKhachHang();
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //int i = dgvKH.CurrentCell.RowIndex;
            dgvKH.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgvKH.DataSource = kh.LayKH();
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                kh.ThemKH(Int32.Parse(txtMaKH.Text), txtHoTen.Text, txtGioiTinh.Text,
                    txtCMND.Text, txtSDT.Text, txtEmail.Text, txtDC.Text);

                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();
        }
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int pi = Convert.ToInt32(dgvKH.CurrentRow.Cells[0].Value.ToString());
            try
            {
                DialogResult dt;
                dt = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dt == DialogResult.OK)
                {
                    kh.XoaKH(pi);


                    MessageBox.Show("Đã xoá xong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không xoá được! Lỗi rồi!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                kh.ThemKH(Int32.Parse(txtMaKH.Text), txtHoTen.Text, txtGioiTinh.Text,
                    txtCMND.Text, txtSDT.Text, txtEmail.Text, txtDC.Text);

                MessageBox.Show("Đã lưu!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lưu được!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        //
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            this.txtMaKH.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
            this.txtGioiTinh.Text = dgvKH.Rows[r].Cells[2].Value.ToString();
            this.txtCMND.Text = dgvKH.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvKH.Rows[r].Cells[4].Value.ToString();
            this.txtEmail.Text = dgvKH.Rows[r].Cells[5].Value.ToString();
            this.txtDC.Text = dgvKH.Rows[r].Cells[6].Value.ToString();
        }
        
    }
}
