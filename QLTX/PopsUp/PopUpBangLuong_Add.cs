using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test.PopsUp
{
    public partial class PopUpBangLuong_Add : Form
    {
        public PopUpBangLuong_Add()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien order by MaPT";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into tb_BangLuong(MaBangLuong,MaTX, LuongCB,Thang,Nam,HSLuong, BHYT, BHXH) values('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')",
               txtMaBL.Text, txtMaTX.Text,txtLuongCB.Text, txtThang.Text, txtNam.Text, txtBHYT.Text, txtBHXH.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Them thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }
    }
}
