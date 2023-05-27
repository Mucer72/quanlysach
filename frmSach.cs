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
        public frmSach(string id)
        {
            InitializeComponent();
            s=new Sach();
            s.MaSach = id;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            frmChinh form = (frmChinh)Application.OpenForms["frmChinh"];
            foreach(Sach sach in form.DanhSach.qlsach)
            {
                if(sach.MaSach==s.MaSach)
                {
                    s = sach;
                    break;
                }
            }
            lblTen.Text = s.TenSach;
            lblTheLoai.Text = "";
            lblTacGia.Text = s.TacGia;
            lblNamXB.Text = s.NamXB;
            lblSoTrang.Text = s.SoTrang.ToString();
            if(s.TrangThai==s.SoTrang)
            {
                lblTrangThai.Text = "Hoàn thành";
            }    
            else
                lblTrangThai.Text = "Chưa hoàn thành";
            lblLoaiSach.Text = "";
            lblViTri.Text = s.ViTriSach;


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
            lblTT.Visible = true;
            lblTrang.Visible = true;
            lblTrangThai.Visible = false;
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
        public void LoadId(string id)
        {

        }
    }
}
