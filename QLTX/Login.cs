using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from tb_User where TaiKhoan = '{0}' and MatKhau = '{1}'", txtTaiKhoan.Text, txtMatKhau.Text);
            DataSet ds = kn.laydulieu(query, "tb_User");
            if (ds.Tables["tb_User"].Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
