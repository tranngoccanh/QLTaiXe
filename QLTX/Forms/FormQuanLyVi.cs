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
    public partial class FormQuanLyVi : Form
    {
        public FormQuanLyVi()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_ViTX";
            DataSet ds = kn.laydulieu(query, "tb_ViTX");
            dgvQLVi.DataSource = ds.Tables["tb_ViTX"];
        }



        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTXDataSet10.tb_ViTX' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLTXDataSet5.tb_ViTX' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTXDataSet3.tb_ViTX' table. You can move, or remove it, as needed.

            getData();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtMaTx.Text = dgvQLVi.Rows[row].Cells["MaTX"].Value.ToString();
                txtMaTx.Enabled = false;
                btnRecharge.Enabled = true;
                btnWithDraw.Enabled = true;
            }
        }

        private void txtMaTx_Enter(object sender, EventArgs e)
        {
            if (txtMaTx.Text == "Mã Tài Xế")
            {
                txtMaTx.Text = "";
                txtMaTx.ForeColor = Color.Black;
            }
        }

        private void txtMaTx_Leave(object sender, EventArgs e)
        {
            if (txtMaTx.Text == "")
            {
                txtMaTx.Text = "Mã Phương Tiện";
                txtMaTx.ForeColor = Color.LightGray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from tb_ViTX where MaTX = '{0}'", txtMaTx.Text);
            DataSet ds = kn.laydulieu(query, "tb_ViTX");
            dgvQLVi.DataSource = ds.Tables["tb_ViTX"];
        }
    }
}
