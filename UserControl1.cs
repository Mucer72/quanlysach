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
    public partial class UserControl1 : UserControl
    {
        DataReader reader = new DataReader();
        QuanLySach qls = new QuanLySach();
        List<Sach> Sach = new List<Sach>();

        public UserControl1(string name, string link)
        {
            InitializeComponent();
            this.lblName.Text = name;
            this.pbHinh.Image = Image.FromFile("./100_bd275c22338e4df3a7b01a0b8553e338_master.jpg");
        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void pbHinh_MouseEnter(object sender, EventArgs e)
        {
            pbHinh.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;
        }

        private void pbHinh_MouseLeave(object sender, EventArgs e)
        {
            pbHinh.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Color.White;
        }
    }
}
