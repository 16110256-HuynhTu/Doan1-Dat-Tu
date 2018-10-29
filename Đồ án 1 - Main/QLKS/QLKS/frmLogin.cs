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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        // di chuyển form
        Boolean flag; int x, y;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        // thoát form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap(txtUserName.Text, txtPassword.Text);
        }

        void DangNhap(string id , string pass)
        {
            BLLPhanQuyen p = new BLLPhanQuyen();
            bool flag = p.DangNhap(id, pass);    
            if(flag==true)
            {
                frmMain main = new frmMain();
                main.id = txtUserName.Text;
                main.pass = txtPassword.Text;
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
