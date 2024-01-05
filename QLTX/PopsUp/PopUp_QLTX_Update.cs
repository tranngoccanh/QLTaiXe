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
    public partial class PopUp_QLTX_Update : Form
    {
        public PopUp_QLTX_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_TaiXe order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("update tb_TaiXe set TenTX = '{1}', NgaySinh = '{2}', GioiTinh = '{3}', SDT = '{4}', CCCD = '{5}', DiaChi = '{6}', NgayKyHD = '{7}', NgayHetHD = '{8}', TrangThai = '{9}' where MaTX = '{0}'",
               txtMaTaiXe.Text, txtTenTaiXe.Text, dateTimePicker1.Value.ToString("yyyyMMdd"), txtGioiTinh.Text, txtSDT.Text, txtCCCD.Text, txtDiaChi.Text, dateTimePicker2.Value.ToString("yyyyMMdd"), dateTimePicker3.Value.ToString("yyyyMMdd"), cbTrangThai.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                getData();


            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopUp_QLTX_Update_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
