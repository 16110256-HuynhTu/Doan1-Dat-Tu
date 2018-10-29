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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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
       
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        BLLNhanVien nv = new BLLNhanVien();
        BLLQuyenNV quyen = new BLLQuyenNV();
        BLLPhanQuyen pq = new BLLPhanQuyen();

        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            nv.LayQuyenNVvsPQvsCV(quyen.LayQuyenNV(), pq.LayPQ(), quyen.LayCV(), dgvNV);
            int i = dgvNV.CurrentCell.RowIndex;
            dgvNV.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            cmbMQ.DataSource = quyen.LayQuyenNV();
            cmbMQ.DisplayMember = "MaQuyen";
            cmbMQ.ValueMember = "MaQuyen";
            cmbPQ.DataSource = pq.LayPQ();
            cmbPQ.DisplayMember = "MaPQ";
            cmbPQ.ValueMember = "MaPQ";
            cmbCV.DataSource = quyen.LayCV(); ;
            cmbCV.DisplayMember = "TenCV";
            cmbCV.ValueMember = "MaCV";
        }
        //
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                nv.ThemNV(int.Parse(txtMaNV.Text), txtHoTen.Text, DateTime.Parse(txtNS.Text), txtGioiTinh.Text,
                    txtCMND.Text, txtSDT.Text, txtDC.Text, txtEmail.Text,
                    Int32.Parse(cmbMQ.SelectedValue.ToString()),
                    Int32.Parse(cmbPQ.SelectedValue.ToString()),
                    Int32.Parse(cmbCV.SelectedValue.ToString()));
                nv.LayQuyenNVvsPQvsCV(quyen.LayQuyenNV(), pq.LayPQ(), quyen.LayCV(), dgvNV);
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
            txtMaNV.Focus();
        }
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int pi = Convert.ToInt32(dgvNV.CurrentRow.Cells[0].Value.ToString());
            try
            {
                DialogResult dt;
                dt = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dt == DialogResult.OK)
                {
                    nv.XoaNV(pi);
                    nv.LayQuyenNVvsPQvsCV(quyen.LayQuyenNV(), pq.LayPQ(), quyen.LayCV(), dgvNV);

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
                nv.SuaNV(int.Parse(txtMaNV.Text), txtHoTen.Text, DateTime.Parse(txtNS.Text), txtGioiTinh.Text,
                    txtCMND.Text, txtSDT.Text, txtDC.Text, txtEmail.Text,
                    Int32.Parse(cmbMQ.SelectedValue.ToString()),
                    Int32.Parse(cmbPQ.SelectedValue.ToString()),
                    Int32.Parse(cmbCV.SelectedValue.ToString()));
                nv.LayQuyenNVvsPQvsCV(quyen.LayQuyenNV(), pq.LayPQ(), quyen.LayCV(), dgvNV);
                MessageBox.Show("Đã lưu!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lưu được!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
            this.txtNS.Text = dgvNV.Rows[r].Cells[2].Value.ToString();
            this.txtGioiTinh.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
            this.txtCMND.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
            this.txtSDT.Text = dgvNV.Rows[r].Cells[5].Value.ToString();
            this.txtDC.Text = dgvNV.Rows[r].Cells[6].Value.ToString();
            this.txtEmail.Text = dgvNV.Rows[r].Cells[7].Value.ToString();
            this.cmbMQ.Text = dgvNV.Rows[r].Cells[8].Value.ToString();
            this.cmbPQ.Text = dgvNV.Rows[r].Cells[9].Value.ToString();
            this.cmbCV.Text = dgvNV.Rows[r].Cells[10].Value.ToString();
        }


    }
}
