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
    public partial class CartForm: Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = Sale_form.GioHang;

            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            decimal tong = Sale_form.GioHang.Sum(i => i.ThanhTien);
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }

        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                var maSP = dgvGioHang.CurrentRow.Cells["MaSP"].Value.ToString();
                var item = Sale_form.GioHang.FirstOrDefault(i => i.MaSP == maSP);
                if (item != null)
                {
                    Sale_form.GioHang.Remove(item);
                    CartForm_Load(sender, e); // load lại
                }
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            Sale_form.GioHang.Clear();
            CartForm_Load(sender, e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Sale_form.GioHang.Count == 0)
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
                Sale_form.GioHang.Clear();

                // Làm mới lưới và tổng tiền
                dgvGioHang.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CartForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CartForm";
            this.ResumeLayout(false);

        }
    }
}
