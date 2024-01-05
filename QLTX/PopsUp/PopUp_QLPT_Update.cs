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
    public partial class PopUp_QLPT_Update : Form
    {
        public PopUp_QLPT_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien order by MaPT";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("update tb_PhuongTien set DongXe = '{1}', MauXe = '{2}', BienSo = '{3}', NamSX = '{4}', SoKhung = '{5}' where MaPT = '{0}'",
               txtMaPT.Text,txtDongXe.Text, txtMauXe.Text, txtBienSoXe.Text, txtNSX.Text, txtSoKhung.Text);
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUp_QLPT_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
