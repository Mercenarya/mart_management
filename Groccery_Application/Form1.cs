using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Groccery_Application
{
    public partial class Form1 : Form
    {
        
        MainConnection con = new MainConnection();
        private string usr;

        public string Usr { get => usr; set => usr = value; }

        public  Form1()
        {
            InitializeComponent();

            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT TenDangNhap,MatKhau FROM TaiKhoan WHERE TenDangNhap = '"+username_txt.Text+"' AND MatKhau = '"+password_txt.Text+"'";
            bool kq = con.login(sql);
            if (kq)
            {
                Homepage home = new Homepage();
                home.Tennv = username_txt.Text;
                home.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Thông tin đăng nhập sai");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
