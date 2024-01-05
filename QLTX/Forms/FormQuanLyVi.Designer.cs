
namespace PJ_For_Wang_Test.Forms
{
    partial class FormQuanLyVi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.txtMaTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.dgvQLVi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDuViTrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDuViDuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbViTXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTXDataSet5 = new PJ_For_Wang_Test.QLTXDataSet5();
            this.tb_ViTXTableAdapter = new PJ_For_Wang_Test.QLTXDataSet5TableAdapters.tb_ViTXTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.qLTXDataSet10 = new PJ_For_Wang_Test.QLTXDataSet10();
            this.tbViTXBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ViTXTableAdapter1 = new PJ_For_Wang_Test.QLTXDataSet10TableAdapters.tb_ViTXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbViTXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbViTXBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(583, 41);
            this.btnWithDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(84, 51);
            this.btnWithDraw.TabIndex = 57;
            this.btnWithDraw.Text = "Rút tiền";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(463, 41);
            this.btnRecharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(84, 51);
            this.btnRecharge.TabIndex = 56;
            this.btnRecharge.Text = "Nạp tiền";
            this.btnRecharge.UseVisualStyleBackColor = true;
            // 
            // txtMaTx
            // 
            this.txtMaTx.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaTx.Location = new System.Drawing.Point(18, 83);
            this.txtMaTx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTx.Name = "txtMaTx";
            this.txtMaTx.Size = new System.Drawing.Size(112, 26);
            this.txtMaTx.TabIndex = 54;
            this.txtMaTx.Text = "Mã Tài Xế";
            this.txtMaTx.Enter += new System.EventHandler(this.txtMaTx_Enter);
            this.txtMaTx.Leave += new System.EventHandler(this.txtMaTx_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Danh sách tài xế";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(-56, -49);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(150, 25);
            this.lblThongTin.TabIndex = 51;
            this.lblThongTin.Text = "Quản lý / Tài xế";
            // 
            // dgvQLVi
            // 
            this.dgvQLVi.AutoGenerateColumns = false;
            this.dgvQLVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLVi.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLVi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLVi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLVi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLVi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLVi.ColumnHeadersHeight = 30;
            this.dgvQLVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maTXDataGridViewTextBoxColumn,
            this.soDuViTrenDataGridViewTextBoxColumn,
            this.soDuViDuoiDataGridViewTextBoxColumn});
            this.dgvQLVi.DataSource = this.tbViTXBindingSource1;
            this.dgvQLVi.EnableHeadersVisualStyles = false;
            this.dgvQLVi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvQLVi.Location = new System.Drawing.Point(5, 116);
            this.dgvQLVi.Name = "dgvQLVi";
            this.dgvQLVi.RowHeadersVisible = false;
            this.dgvQLVi.RowHeadersWidth = 62;
            this.dgvQLVi.RowTemplate.Height = 28;
            this.dgvQLVi.Size = new System.Drawing.Size(662, 401);
            this.dgvQLVi.TabIndex = 59;
            this.dgvQLVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLVi_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.HeaderText = "Mã Tài Xế";
            this.maTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            // 
            // soDuViTrenDataGridViewTextBoxColumn
            // 
            this.soDuViTrenDataGridViewTextBoxColumn.DataPropertyName = "SoDuViTren";
            this.soDuViTrenDataGridViewTextBoxColumn.HeaderText = "Số Dư Ví Trên";
            this.soDuViTrenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDuViTrenDataGridViewTextBoxColumn.Name = "soDuViTrenDataGridViewTextBoxColumn";
            // 
            // soDuViDuoiDataGridViewTextBoxColumn
            // 
            this.soDuViDuoiDataGridViewTextBoxColumn.DataPropertyName = "SoDuViDuoi";
            this.soDuViDuoiDataGridViewTextBoxColumn.HeaderText = "Số Dư Ví Dưới";
            this.soDuViDuoiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDuViDuoiDataGridViewTextBoxColumn.Name = "soDuViDuoiDataGridViewTextBoxColumn";
            // 
            // tbViTXBindingSource
            // 
            this.tbViTXBindingSource.DataMember = "tb_ViTX";
            this.tbViTXBindingSource.DataSource = this.qLTXDataSet5;
            // 
            // qLTXDataSet5
            // 
            this.qLTXDataSet5.DataSetName = "QLTXDataSet5";
            this.qLTXDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ViTXTableAdapter
            // 
            this.tb_ViTXTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(151, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // qLTXDataSet10
            // 
            this.qLTXDataSet10.DataSetName = "QLTXDataSet10";
            this.qLTXDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbViTXBindingSource1
            // 
            this.tbViTXBindingSource1.DataMember = "tb_ViTX";
            this.tbViTXBindingSource1.DataSource = this.qLTXDataSet10;
            // 
            // tb_ViTXTableAdapter1
            // 
            this.tb_ViTXTableAdapter1.ClearBeforeFill = true;
            // 
            // FormQuanLyVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvQLVi);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.txtMaTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLyVi";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbViTXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbViTXBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.TextBox txtMaTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridView dgvQLVi;
        private QLTXDataSet5 qLTXDataSet5;
        private System.Windows.Forms.BindingSource tbViTXBindingSource;
        private QLTXDataSet5TableAdapters.tb_ViTXTableAdapter tb_ViTXTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDuViTrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDuViDuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private QLTXDataSet10 qLTXDataSet10;
        private System.Windows.Forms.BindingSource tbViTXBindingSource1;
        private QLTXDataSet10TableAdapters.tb_ViTXTableAdapter tb_ViTXTableAdapter1;
    }
}