﻿
namespace PJ_For_Wang_Test.Forms
{
    partial class FormQLPT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoKhung = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtDongXe = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.dgvQLPT = new System.Windows.Forms.DataGridView();
            this.maPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKhungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPhuongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTXDataSet1 = new PJ_For_Wang_Test.QLTXDataSet1();
            this.tb_PhuongTienTableAdapter = new PJ_For_Wang_Test.QLTXDataSet1TableAdapters.tb_PhuongTienTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhuongTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quản lý / Phương Tiện";
            // 
            // txtSoKhung
            // 
            this.txtSoKhung.ForeColor = System.Drawing.Color.LightGray;
            this.txtSoKhung.Location = new System.Drawing.Point(262, 112);
            this.txtSoKhung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.Size = new System.Drawing.Size(112, 26);
            this.txtSoKhung.TabIndex = 18;
            this.txtSoKhung.Text = "Số Khung";
            this.txtSoKhung.Enter += new System.EventHandler(this.txtSoKhung_Enter);
            this.txtSoKhung.Leave += new System.EventHandler(this.txtSoKhung_Leave);
            // 
            // txtMaPT
            // 
            this.txtMaPT.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaPT.Location = new System.Drawing.Point(12, 112);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(126, 26);
            this.txtMaPT.TabIndex = 17;
            this.txtMaPT.Text = "Mã Phương Tiện";
            this.txtMaPT.Enter += new System.EventHandler(this.txtMaPT_Enter);
            this.txtMaPT.Leave += new System.EventHandler(this.txtMaPT_Leave);
            // 
            // txtDongXe
            // 
            this.txtDongXe.ForeColor = System.Drawing.Color.LightGray;
            this.txtDongXe.Location = new System.Drawing.Point(144, 112);
            this.txtDongXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(112, 26);
            this.txtDongXe.TabIndex = 16;
            this.txtDongXe.Text = "Dòng Xe";
            this.txtDongXe.Enter += new System.EventHandler(this.txtDongXe_Enter);
            this.txtDongXe.Leave += new System.EventHandler(this.txtDongXe_Leave);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(1, 60);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(255, 25);
            this.lblThongTin.TabIndex = 15;
            this.lblThongTin.Text = "Danh sách phương tiện";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1017, 96);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 59);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm Phương Tiện";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1001, 449);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 29);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1091, 449);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 29);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem2
            // 
            this.btnThem2.Location = new System.Drawing.Point(901, 449);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(94, 29);
            this.btnThem2.TabIndex = 24;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // dgvQLPT
            // 
            this.dgvQLPT.AutoGenerateColumns = false;
            this.dgvQLPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLPT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLPT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQLPT.ColumnHeadersHeight = 30;
            this.dgvQLPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPTDataGridViewTextBoxColumn,
            this.maTXDataGridViewTextBoxColumn,
            this.dongXeDataGridViewTextBoxColumn,
            this.mauXeDataGridViewTextBoxColumn,
            this.bienSoDataGridViewTextBoxColumn,
            this.namSXDataGridViewTextBoxColumn,
            this.soKhungDataGridViewTextBoxColumn});
            this.dgvQLPT.DataSource = this.tbPhuongTienBindingSource;
            this.dgvQLPT.EnableHeadersVisualStyles = false;
            this.dgvQLPT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dgvQLPT.Location = new System.Drawing.Point(4, 163);
            this.dgvQLPT.Name = "dgvQLPT";
            this.dgvQLPT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLPT.RowHeadersVisible = false;
            this.dgvQLPT.RowHeadersWidth = 62;
            this.dgvQLPT.RowTemplate.Height = 28;
            this.dgvQLPT.Size = new System.Drawing.Size(1171, 279);
            this.dgvQLPT.TabIndex = 25;
            // 
            // maPTDataGridViewTextBoxColumn
            // 
            this.maPTDataGridViewTextBoxColumn.DataPropertyName = "MaPT";
            this.maPTDataGridViewTextBoxColumn.HeaderText = "Mã Phương Tiện";
            this.maPTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maPTDataGridViewTextBoxColumn.Name = "maPTDataGridViewTextBoxColumn";
            // 
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.HeaderText = "Mã Tài Xế";
            this.maTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            // 
            // dongXeDataGridViewTextBoxColumn
            // 
            this.dongXeDataGridViewTextBoxColumn.DataPropertyName = "DongXe";
            this.dongXeDataGridViewTextBoxColumn.HeaderText = "Dòng Xe";
            this.dongXeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongXeDataGridViewTextBoxColumn.Name = "dongXeDataGridViewTextBoxColumn";
            // 
            // mauXeDataGridViewTextBoxColumn
            // 
            this.mauXeDataGridViewTextBoxColumn.DataPropertyName = "MauXe";
            this.mauXeDataGridViewTextBoxColumn.HeaderText = "Màu Xe";
            this.mauXeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mauXeDataGridViewTextBoxColumn.Name = "mauXeDataGridViewTextBoxColumn";
            // 
            // bienSoDataGridViewTextBoxColumn
            // 
            this.bienSoDataGridViewTextBoxColumn.DataPropertyName = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.HeaderText = "Biển Số";
            this.bienSoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bienSoDataGridViewTextBoxColumn.Name = "bienSoDataGridViewTextBoxColumn";
            // 
            // namSXDataGridViewTextBoxColumn
            // 
            this.namSXDataGridViewTextBoxColumn.DataPropertyName = "NamSX";
            this.namSXDataGridViewTextBoxColumn.HeaderText = "Năm SX ";
            this.namSXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namSXDataGridViewTextBoxColumn.Name = "namSXDataGridViewTextBoxColumn";
            // 
            // soKhungDataGridViewTextBoxColumn
            // 
            this.soKhungDataGridViewTextBoxColumn.DataPropertyName = "SoKhung";
            this.soKhungDataGridViewTextBoxColumn.HeaderText = "Số Khung";
            this.soKhungDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soKhungDataGridViewTextBoxColumn.Name = "soKhungDataGridViewTextBoxColumn";
            // 
            // tbPhuongTienBindingSource
            // 
            this.tbPhuongTienBindingSource.DataMember = "tb_PhuongTien";
            this.tbPhuongTienBindingSource.DataSource = this.qLTXDataSet1;
            // 
            // qLTXDataSet1
            // 
            this.qLTXDataSet1.DataSetName = "QLTXDataSet1";
            this.qLTXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_PhuongTienTableAdapter
            // 
            this.tb_PhuongTienTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 26);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormQLPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvQLPT);
            this.Controls.Add(this.btnThem2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoKhung);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.txtDongXe);
            this.Controls.Add(this.lblThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQLPT";
            this.Text = "Quản Lý Phương Tiện";
            this.Load += new System.EventHandler(this.FormQLPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhuongTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoKhung;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtDongXe;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.DataGridView dgvQLPT;
        private QLTXDataSet1 qLTXDataSet1;
        private System.Windows.Forms.BindingSource tbPhuongTienBindingSource;
        private QLTXDataSet1TableAdapters.tb_PhuongTienTableAdapter tb_PhuongTienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKhungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
    }
}