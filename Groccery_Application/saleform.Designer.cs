namespace Groccery_Application
{
    partial class saleform
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
            this.lb_hiendongia = new System.Windows.Forms.Label();
            this.lb_hientensp = new System.Windows.Forms.Label();
            this.bt_Themvaogiohang = new System.Windows.Forms.Button();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.lb_Masp = new System.Windows.Forms.Label();
            this.txt_Masp = new System.Windows.Forms.TextBox();
            this.lb_Dongia = new System.Windows.Forms.Label();
            this.lb_Tensp = new System.Windows.Forms.Label();
            this.lb_Soluong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_hiendongia
            // 
            this.lb_hiendongia.AutoSize = true;
            this.lb_hiendongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hiendongia.Location = new System.Drawing.Point(246, 194);
            this.lb_hiendongia.Name = "lb_hiendongia";
            this.lb_hiendongia.Size = new System.Drawing.Size(0, 23);
            this.lb_hiendongia.TabIndex = 18;
            // 
            // lb_hientensp
            // 
            this.lb_hientensp.AutoSize = true;
            this.lb_hientensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hientensp.Location = new System.Drawing.Point(246, 120);
            this.lb_hientensp.Name = "lb_hientensp";
            this.lb_hientensp.Size = new System.Drawing.Size(0, 23);
            this.lb_hientensp.TabIndex = 17;
            // 
            // bt_Themvaogiohang
            // 
            this.bt_Themvaogiohang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Themvaogiohang.Location = new System.Drawing.Point(368, 360);
            this.bt_Themvaogiohang.Name = "bt_Themvaogiohang";
            this.bt_Themvaogiohang.Size = new System.Drawing.Size(164, 38);
            this.bt_Themvaogiohang.TabIndex = 16;
            this.bt_Themvaogiohang.Text = "Thêm vào giỏ hàng";
            this.bt_Themvaogiohang.UseVisualStyleBackColor = true;
            this.bt_Themvaogiohang.Click += new System.EventHandler(this.bt_Themvaogiohang_Click);
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Soluong.Location = new System.Drawing.Point(246, 272);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(162, 30);
            this.txt_Soluong.TabIndex = 15;
            // 
            // lb_Masp
            // 
            this.lb_Masp.AutoSize = true;
            this.lb_Masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Masp.Location = new System.Drawing.Point(70, 53);
            this.lb_Masp.Name = "lb_Masp";
            this.lb_Masp.Size = new System.Drawing.Size(121, 23);
            this.lb_Masp.TabIndex = 14;
            this.lb_Masp.Text = "Mã sản phẩm";
            // 
            // txt_Masp
            // 
            this.txt_Masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Masp.Location = new System.Drawing.Point(246, 53);
            this.txt_Masp.Name = "txt_Masp";
            this.txt_Masp.Size = new System.Drawing.Size(162, 30);
            this.txt_Masp.TabIndex = 13;
            this.txt_Masp.TextChanged += new System.EventHandler(this.txt_Masp_TextChanged_1);
            // 
            // lb_Dongia
            // 
            this.lb_Dongia.AutoSize = true;
            this.lb_Dongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dongia.Location = new System.Drawing.Point(70, 194);
            this.lb_Dongia.Name = "lb_Dongia";
            this.lb_Dongia.Size = new System.Drawing.Size(75, 23);
            this.lb_Dongia.TabIndex = 12;
            this.lb_Dongia.Text = "Đơn giá";
            // 
            // lb_Tensp
            // 
            this.lb_Tensp.AutoSize = true;
            this.lb_Tensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tensp.Location = new System.Drawing.Point(70, 120);
            this.lb_Tensp.Name = "lb_Tensp";
            this.lb_Tensp.Size = new System.Drawing.Size(125, 23);
            this.lb_Tensp.TabIndex = 11;
            this.lb_Tensp.Text = "Tên sản phẩm";
            // 
            // lb_Soluong
            // 
            this.lb_Soluong.AutoSize = true;
            this.lb_Soluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Soluong.Location = new System.Drawing.Point(70, 279);
            this.lb_Soluong.Name = "lb_Soluong";
            this.lb_Soluong.Size = new System.Drawing.Size(84, 23);
            this.lb_Soluong.TabIndex = 10;
            this.lb_Soluong.Text = "Số lượng";
            // 
            // saleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 504);
            this.Controls.Add(this.lb_hiendongia);
            this.Controls.Add(this.lb_hientensp);
            this.Controls.Add(this.bt_Themvaogiohang);
            this.Controls.Add(this.txt_Soluong);
            this.Controls.Add(this.lb_Masp);
            this.Controls.Add(this.txt_Masp);
            this.Controls.Add(this.lb_Dongia);
            this.Controls.Add(this.lb_Tensp);
            this.Controls.Add(this.lb_Soluong);
            this.Name = "saleform";
            this.Text = "saleform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hiendongia;
        private System.Windows.Forms.Label lb_hientensp;
        private System.Windows.Forms.Button bt_Themvaogiohang;
        private System.Windows.Forms.TextBox txt_Soluong;
        private System.Windows.Forms.Label lb_Masp;
        private System.Windows.Forms.TextBox txt_Masp;
        private System.Windows.Forms.Label lb_Dongia;
        private System.Windows.Forms.Label lb_Tensp;
        private System.Windows.Forms.Label lb_Soluong;
    }
}