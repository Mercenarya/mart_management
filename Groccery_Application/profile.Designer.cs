namespace Groccery_Application
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.manv_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.pos_cbbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.logout.ForeColor = System.Drawing.SystemColors.Control;
            this.logout.Location = new System.Drawing.Point(591, 405);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(289, 41);
            this.logout.TabIndex = 7;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // manv_txt
            // 
            this.manv_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.manv_txt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.manv_txt.Location = new System.Drawing.Point(637, 112);
            this.manv_txt.Multiline = true;
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(243, 30);
            this.manv_txt.TabIndex = 8;
            this.manv_txt.TextChanged += new System.EventHandler(this.manv_txt_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.name_txt.Location = new System.Drawing.Point(637, 157);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(243, 30);
            this.name_txt.TabIndex = 9;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // SDT
            // 
            this.SDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SDT.ForeColor = System.Drawing.SystemColors.Window;
            this.SDT.Location = new System.Drawing.Point(637, 262);
            this.SDT.Multiline = true;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(243, 30);
            this.SDT.TabIndex = 11;
            this.SDT.TextChanged += new System.EventHandler(this.SDT_TextChanged);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Highlight;
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(591, 358);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(289, 41);
            this.update.TabIndex = 12;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // pos_cbbox
            // 
            this.pos_cbbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pos_cbbox.ForeColor = System.Drawing.SystemColors.Window;
            this.pos_cbbox.FormattingEnabled = true;
            this.pos_cbbox.Location = new System.Drawing.Point(638, 213);
            this.pos_cbbox.Name = "pos_cbbox";
            this.pos_cbbox.Size = new System.Drawing.Size(242, 24);
            this.pos_cbbox.TabIndex = 13;
            this.pos_cbbox.SelectedIndexChanged += new System.EventHandler(this.pos_cbbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pos_cbbox);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox manv_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox pos_cbbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}