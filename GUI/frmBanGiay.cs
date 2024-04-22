using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI
{
    public partial class frmBanGiay : Form
    {
        private GiayBUS Giay_BUS;
        public frmBanGiay()
        {
            InitializeComponent();
            Giay_BUS = new GiayBUS();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmBanGiay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuahang_bangiayDataSet1.Giay' table. You can move, or remove it, as needed.
            this.giayTableAdapter.Fill(this.cuahang_bangiayDataSet1.Giay);
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvBanGiay.DataSource = Giay_BUS.LayDanhSachGiay();

            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.HeaderText = "Ảnh";
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //DataGridViewImageColumn textBoxcolumn = new DataGridViewImageColumn();
            //imageColumn.HeaderText = "Hình";

            
            //dgvBanGiay.Columns.Add(imageColumn);
            //dgvBanGiay.Columns.Add(textBoxcolumn);

            //dgvBanGiay.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            //dgvBanGiay.RowTemplate.Height = 10;
        }
        
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
        
            dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
 

            if (dialog.ShowDialog() == DialogResult.OK)
            {      
                ptB_giay.Image = Image.FromFile(dialog.FileName);
                
            }
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            GiayDTO giay = new GiayDTO();
            giay.MaGiay = int.Parse(txtMaGiay.Text);
            giay.TenGiay = txtTenGiay.Text;
            giay.Size = int.Parse(txtSize.Text);
            giay.Gia = int.Parse(txt_Gia.Text);
            giay.MaNCC = int.Parse(txtMancc.Text);
            giay.Hinh = txtHinh.Text;
            giay.MaLoai = int.Parse(txtMaLoai.Text);
            giay.TrangThai = cboTrangThai.SelectedIndex;
            
            if (Giay_BUS.ThemGiay(giay))
            {
                MessageBox.Show("Thêm giày thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm giày thất bại");
            }
            
        }

        private void dgvBanGiay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 7 && e.Value != null)
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

        private void dgvBanGiay_Click(object sender, EventArgs e)
        {

        }

        private void dgvBanGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBanGiay.Rows[e.RowIndex];
                txtMaGiay.Text = row.Cells["MaGiay"].Value.ToString();
                txtTenGiay.Text = row.Cells["TenGiay"].Value.ToString();
                txtSize.Text = row.Cells["Size"].Value.ToString();
                txt_Gia.Text = row.Cells["Gia"].Value.ToString();
                txtMancc.Text = row.Cells["MaNCC"].Value.ToString();
                txtHinh.Text = row.Cells["Hinh"].Value.ToString();
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                cboTrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
            }
            
        
    }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiayDTO giay = new GiayDTO();
            giay.MaGiay = int.Parse(txtMaGiay.Text);
            giay.TenGiay = txtTenGiay.Text;
            giay.Size = int.Parse(txtSize.Text);
            giay.Gia = int.Parse(txt_Gia.Text);
            giay.MaNCC = int.Parse(txtMancc.Text);
            giay.Hinh = txtHinh.Text;
            giay.MaLoai = int.Parse(txtMaLoai.Text);
            giay.TrangThai = cboTrangThai.SelectedIndex;

            if (Giay_BUS.CapNhatGiay(giay))
            {
                MessageBox.Show("Cập nhật giày thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật giày thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaGiay = int.Parse(txtMaGiay.Text);
           
            if (Giay_BUS.XoaGiay(MaGiay))
            {
                MessageBox.Show("Xóa Giày thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa Giày thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenGiay = txtTim.Text;
            dgvBanGiay.DataSource = Giay_BUS.TimGiay(tenGiay);
        }

        private void dgvBanGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBanGiay_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
