
namespace PJ_For_Wang_Test.Forms
{
    partial class FormBaoCao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDriverTM = new System.Windows.Forms.Button();
            this.btnRPV = new System.Windows.Forms.Button();
            this.btnExpContract = new System.Windows.Forms.Button();
            this.btnRPDriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản Lý / Báo Cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "BÁO CÁO";
            // 
            // btnDriverTM
            // 
            this.btnDriverTM.Location = new System.Drawing.Point(30, 282);
            this.btnDriverTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDriverTM.Name = "btnDriverTM";
            this.btnDriverTM.Size = new System.Drawing.Size(279, 62);
            this.btnDriverTM.TabIndex = 9;
            this.btnDriverTM.Text = "Báo cáo tổng tiền nạp rút của tài xế";
            this.btnDriverTM.UseVisualStyleBackColor = true;
            // 
            // btnRPV
            // 
            this.btnRPV.Location = new System.Drawing.Point(30, 215);
            this.btnRPV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRPV.Name = "btnRPV";
            this.btnRPV.Size = new System.Drawing.Size(279, 60);
            this.btnRPV.TabIndex = 8;
            this.btnRPV.Text = "Báo cáo biến động phương tiện";
            this.btnRPV.UseVisualStyleBackColor = true;
            // 
            // btnExpContract
            // 
            this.btnExpContract.Location = new System.Drawing.Point(30, 352);
            this.btnExpContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExpContract.Name = "btnExpContract";
            this.btnExpContract.Size = new System.Drawing.Size(279, 60);
            this.btnExpContract.TabIndex = 7;
            this.btnExpContract.Text = "Danh sách các tài xế hết hạn hợp đồng vào tháng [n]";
            this.btnExpContract.UseVisualStyleBackColor = true;
            // 
            // btnRPDriver
            // 
            this.btnRPDriver.Location = new System.Drawing.Point(30, 146);
            this.btnRPDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRPDriver.Name = "btnRPDriver";
            this.btnRPDriver.Size = new System.Drawing.Size(279, 61);
            this.btnRPDriver.TabIndex = 6;
            this.btnRPDriver.Text = "Báo cáo biến động tài xế";
            this.btnRPDriver.UseVisualStyleBackColor = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDriverTM);
            this.Controls.Add(this.btnRPV);
            this.Controls.Add(this.btnExpContract);
            this.Controls.Add(this.btnRPDriver);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDriverTM;
        private System.Windows.Forms.Button btnRPV;
        private System.Windows.Forms.Button btnExpContract;
        private System.Windows.Forms.Button btnRPDriver;
    }
}