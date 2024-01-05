using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test.Forms
{
    public partial class FormQLPT : Form
    {
        public FormQLPT()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
            dgvQLPT.DataSource = ds.Tables["tb_PhuongTien"];
        }
        //private DataTable dataTable = new DataTable();
        //private BindingSource bindingSource = new BindingSource();
        


        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Add popup = new PopsUp.PopUp_QLPT_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void dgvQLPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtMaPT.Text = dgvQLPT.Rows[row].Cells["MaPT"].Value.ToString();
                txtDongXe.Text = dgvQLPT.Rows[row].Cells["DongXe"].Value.ToString();
                txtSoKhung.Text = dgvQLPT.Rows[row].Cells["SoKhung"].Value.ToString();

                txtMaPT.Enabled = false;
                txtDongXe.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Update popup = new PopsUp.PopUp_QLPT_Update())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Delete popup = new PopsUp.PopUp_QLPT_Delete())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Add popup = new PopsUp.PopUp_QLPT_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }

        }

        private void dgvQLPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLPT_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from tb_PhuongTien where MaPT = '{0}' OR DongXe = '{1}' OR SoKhung = '{2}'", txtMaPT.Text, txtDongXe.Text, txtSoKhung.Text);
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
            dgvQLPT.DataSource = ds.Tables["tb_PhuongTien"];
        }

        private void txtMaPT_Enter(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "Mã Phương Tiện")
            {
                txtMaPT.Text = "";
                txtMaPT.ForeColor = Color.Black;
            }
        }

        private void txtMaPT_Leave(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "")
            {
                txtMaPT.Text = "Mã Phương Tiện";
                txtMaPT.ForeColor = Color.LightGray;
            }
        }

        private void txtDongXe_Enter(object sender, EventArgs e)
        {
            if (txtDongXe.Text == "Dòng Xe")
            {
                txtDongXe.Text = "";
                txtDongXe.ForeColor = Color.Black;
            }
        }

        private void txtDongXe_Leave(object sender, EventArgs e)
        {
            if (txtDongXe.Text == "")
            {
                txtDongXe.Text = "Dòng Xe";
                txtDongXe.ForeColor = Color.LightGray;
            }
        }

        private void txtSoKhung_Enter(object sender, EventArgs e)
        {
            if (txtSoKhung.Text == "Số Khung")
            {
                txtSoKhung.Text = "";
                txtSoKhung.ForeColor = Color.Black;
            }
        }

        private void txtSoKhung_Leave(object sender, EventArgs e)
        {
            if (txtSoKhung.Text == "")
            {
                txtSoKhung.Text = "Số Khung";
                txtSoKhung.ForeColor = Color.LightGray;
            }
        }
    }
}
