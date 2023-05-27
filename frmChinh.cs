using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLySachCaNhan
{
    
    public partial class frmChinh : Form
    {
        DataReader reader = new DataReader();
        public QuanLySach DanhSach = new QuanLySach();

        //private int rowCount = 1; // số hàng hiện tại
        //private int panelCount = 1; // số panel hiện tại
        //private const int maxColumns = 3; // số cột tối đa
        //private const int panelSpacing = 50;
        public frmChinh()
        {
            InitializeComponent();
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {
            LoadBookList();
           
        }
        private void LoadBookList()
        {
            UserControl1 sach;
            foreach(Sach s in DanhSach.qlsach)
            {
                sach = new UserControl1(s.MaSach,s.TenSach, s.LinkHinh);
                this.flowLayoutPanel1.Controls.Add(sach);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //this.flowLayoutPanel1.Controls.Add(UserControl1)
        }
    }
}
