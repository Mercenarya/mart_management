using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Groccery_Application
{
    public partial class Homepage : MaterialForm
    {
        Form1 fm = new Form1();
        private string tennv;
        public string Tennv { get => tennv; set => tennv = value; }
        public Homepage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            name.Text = tennv;
        }
        MainConnection kn = new MainConnection();

       

        private void name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "SELECT MaNV FROM TaiKhoan WHERE TenDangNhap = '" + name.Text + "'";
            DataTable result = kn.getTBdata(sql);
            if (result.Rows.Count > 0)
            {
                profile pf = new profile();
                pf.Manv = result.Rows[0]["MaNV"].ToString();
                pf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã nhân viên");
            }
           
            
        }
    }
}
