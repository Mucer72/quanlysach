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
        string ID;

        public UserControl1(string id, string name, string link)
        {
            InitializeComponent();
            this.lblName.Text = name;
            this.pbHinh.Image = Image.FromFile("./100_bd275c22338e4df3a7b01a0b8553e338_master.jpg");
            ID=id;
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

        private void pbHinh_Click(object sender, EventArgs e)
        {
            frmSach form = new frmSach(ID);
            form.ShowDialog();
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            pbHinh_Click(sender,e);
        }
    }
}
