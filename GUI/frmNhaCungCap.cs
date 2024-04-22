using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhaCungCap : Form
    {
        private NhaCungCapBUS NhaCungCapBUS;
       public frmNhaCungCap()
        {
            InitializeComponent();
            NhaCungCapBUS = new NhaCungCapBUS();
        }
        private void LoadDataGridView()
        {
            dgvNCC.DataSource = NhaCungCapBUS.LayDanhSachNCC();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuahang_bangiayDataSet3.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.cuahang_bangiayDataSet3.NhaCungCap);
            LoadDataGridView();
        }

        private void dgvNCC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                int trangThai = (int)e.Value;
                if (trangThai == 1)
                {
                    e.Value = "Hoạt động";
                }
                else if (trangThai == 0)
                {
                    e.Value = "Không hoạt động";
                }
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
            txtMancc.Text = row.Cells["MANCC"].Value.ToString();
            txtTenncc.Text = row.Cells["TenNCC"].Value.ToString();
            txtDchi.Text = row.Cells["DCHI"].Value.ToString();
            txtSdt.Text = row.Cells["SDT"].Value.ToString();
            txtEmail.Text = row.Cells["MAIL"].Value.ToString();
            cbbTrangthai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MANCC = int.Parse(txtMancc.Text);
            ncc.TenNCC = txtTenncc.Text;
            ncc.DCHI = txtDchi.Text;
            ncc.SDT = txtSdt.Text;
            ncc.MAIL = txtEmail.Text;
            ncc.TrangThai = cbbTrangthai.SelectedIndex;


            if (NhaCungCapBUS.ThemNCC(ncc))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MANCC = int.Parse(txtMancc.Text);

            if (NhaCungCapBUS.XoaNCC(MANCC))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MANCC = int.Parse(txtMancc.Text);
            ncc.TenNCC = txtTenncc.Text;
            ncc.DCHI = txtDchi.Text;
            ncc.SDT = txtSdt.Text;
            ncc.MAIL = txtEmail.Text;
            ncc.TrangThai = cbbTrangthai.SelectedIndex;

            if (NhaCungCapBUS.CapNhatNCC(ncc))
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenncc = txtTim.Text;
            dgvNCC.DataSource = NhaCungCapBUS.TimKiemNCC(tenncc);
        }
    }
}
