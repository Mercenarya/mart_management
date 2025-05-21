using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Groccery_Application
{
    public partial class profile : MaterialForm
    {
        public profile()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        MainConnection kn = new MainConnection();
        Homepage hp = new Homepage();
        private string manv;

        public string Manv { get => manv; set => manv = value; }

        private void profile_Load(object sender, EventArgs e)
        {
            manv_txt.BackColor = Color.LightBlue;
            name_txt.BackColor = Color.LightBlue;
            pos_cbbox.BackColor = Color.LightBlue;
            SDT.BackColor = Color.LightBlue;
            update.BackColor = Color.LightBlue;
            logout.BackColor = Color.LightBlue;

            string sql = "SELECT * FROM NhanVien WHERE MaNV = '"+manv+"'";
            DataTable result = kn.getTBdata(sql);
            if (result.Rows.Count > 0)
            {
                manv_txt.Text = result.Rows[0]["MaNV"].ToString();
                name_txt.Text = result.Rows[0]["TenNV"].ToString();
                SDT.Text = result.Rows[0]["SDT"].ToString();

            }
            else
            {
                MessageBox.Show("Invalid profile");
            }



        }

        private void xuatfile_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void manv_txt_TextChanged(object sender, EventArgs e)
        {
            manv_txt.BackColor = Color.LightBlue;
            
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            name_txt.BackColor = Color.LightBlue;
        }

        private void pos_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pos_cbbox.BackColor = Color.LightBlue;
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            SDT.BackColor = Color.LightBlue;
        }

        private void update_Click(object sender, EventArgs e)
        {
            update.BackColor = Color.LightBlue;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            logout.BackColor = Color.LightBlue;
        }
    }
}
