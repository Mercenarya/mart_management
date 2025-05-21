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

namespace Groccery_Application
{
    public partial class saleform : Form
    {
        public saleform()
        {
            InitializeComponent();
            txt_Masp.Leave += txt_Masp_Leave; // Gắn sự kiện Leave
        }

        public static List<Items> GioHang = new List<Items>();
        
        private void txt_Masp_Leave(object sender, EventArgs e)
        {
            string maSP = txt_Masp.Text.Trim();
            if (string.IsNullOrEmpty(maSP)) return;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Groccery_Application\Groccery_Application\grocery.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TenSP, Dongiaban FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lb_Tensp.Text = reader["TenSP"].ToString();
                        lb_Dongia.Text = reader["Dongiaban"].ToString();
                    }
                    else
                    {
                        lb_Tensp.Text = "Không tìm thấy sản phẩm";
                        lb_Dongia.Text = "";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }



        private void lb_Tensp_Click(object sender, EventArgs e)
        {

        }

        private void txt_Soluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Themvaogiohang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Masp.Text) || string.IsNullOrEmpty(txt_Soluong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm và số lượng.");
                return;
            }

            if (!int.TryParse(txt_Soluong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            string maSP = txt_Masp.Text.Trim();
            string tenSP = lb_Tensp.Text;
            decimal donGia = decimal.Parse(lb_Dongia.Text);

            // Thêm vào giỏ hàng
            var item = new Items
            {
                MaSP = maSP,
                TenSP = tenSP,
                SoLuong = soLuong,
                DonGia = donGia
            };

            saleform.GioHang.Add(item);

            // Mở Form giỏ hàng
            Cart cartForm = new Cart();
            cartForm.ShowDialog();
        }

        private void lb_hiendongia_Click(object sender, EventArgs e)
        {

        }

        private void lb_hientensp_Click(object sender, EventArgs e)
        {

        }

        private void txt_Masp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Masp_Click(object sender, EventArgs e)
        {

        }

        private void Sale_form_Load(object sender, EventArgs e)
        {

        }

        private void lb_Dongia_Click(object sender, EventArgs e)
        {

        }

        private void lb_Soluong_Click(object sender, EventArgs e)
        {

        }

        private void txt_Masp_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
