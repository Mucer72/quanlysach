using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySachCaNhan
{
    public partial class frmSach : Form
    {
        QuanLySach qlds = new QuanLySach();
        Sach s;
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            s = new Sach();
            lblTen.Text = "Conan";
            lblTheLoai.Text = "Bí ẩn";
            lblTacGia.Text = "Shogakukan";
            lblNamXB.Text = "1996";
            lblSoTrang.Text = "103";
            lblTrangThai.Text = "25";
            lblLoaiSach.Text = "Sách của tôi";
            lblViTri.Text = "Tầng 1";


            txtTen.Text = lblTen.Text;
            cboTheLoai.Text = lblTheLoai.Text;
            txtTenTacGia.Text = lblTacGia.Text;
            
            txtSoTrang.Text = lblSoTrang.Text;
            TrangThai.Text = lblTrangThai.Text;
            cboLoaiSach.Text = lblLoaiSach.Text;
            cboVitri.Text = lblViTri.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTen.Visible = true;
            cboTheLoai.Visible = true;
            btnAdd.Visible = true;
            txtTenTacGia.Visible = true;
            dtpNgayXB.Visible = true;
            txtSoTrang.Visible = true;
            TrangThai.Visible = true;
            cboLoaiSach.Visible = true;
            btnBrowse.Visible = true;
            btnOK.Visible = false;
            btnLuu.Visible = true;
            cboVitri.Visible = true;
            lblTheLoai.Text = "Bí ẩn,Kinh dị, giật gân";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string file = Environment.CurrentDirectory.ToString() + "\\Images";
            OpenFileDialog ofd = OpenFileDialog1;
            ofd.Filter = "Image files(*.gif; *.png; *.jpg; *.bmg)|*.GIF; *.PNG; *.JPG; *.BMG";
            ofd.InitialDirectory = file;
            ofd.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
