using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groccery_Application
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            this.Load += CartForm_Load;
        }
        

        private void CartForm_Load(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = saleform.GioHang;

            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            decimal tong = saleform.GioHang.Sum(i => i.ThanhTien);
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }

        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                var maSP = dgvGioHang.CurrentRow.Cells["MaSP"].Value.ToString();
                var item = saleform.GioHang.FirstOrDefault(i => i.MaSP == maSP);
                if (item != null)
                {
                    saleform.GioHang.Remove(item);
                    CartForm_Load(sender, e); // load lại
                }
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            saleform.GioHang.Clear();
            CartForm_Load(sender, e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (saleform.GioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận thanh toán?", "Thanh toán", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Xử lý lưu đơn hàng nếu cần (ghi vào DB, file, v.v.)

                MessageBox.Show("Thanh toán thành công!");

                // Xoá giỏ hàng
                saleform.GioHang.Clear();

                // Làm mới lưới và tổng tiền
                dgvGioHang.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            }
        }
    }
}
