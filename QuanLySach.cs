using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySachCaNhan
{
    public class QuanLySach
    {
        DataReader dataReader = new DataReader();
        public List<Sach> qlsach;
        public QuanLySach()
        {
            qlsach = new List<Sach>();
            DocDuLieu();
        }
        public void Them()
        {

        }
        public void Xoa()
        {

        }
        public void Sua()
        {

        }
        public void SapXep()
        {

        }
        public List<Sach> TimKiem()
        {
            return qlsach;
        }
        public void DocDuLieu()
        {
            SqlConnection conn = new SqlConnection(dataReader.connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Sach";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Sach sach;
            while (reader.Read())
            {
                sach = new Sach();
                sach.MaSach = reader["MaSach"].ToString();
                sach.TenSach = reader["TenSach"].ToString();
                sach.SoTrang = int.Parse(reader["SoTrang"].ToString());
                sach.NamXB = reader["NamXB"].ToString();
                sach.ViTriSach = reader["ViTriSach"].ToString();
                sach.TacGia = reader["TacGia"].ToString();
                sach.LinkHinh = reader["LinkHinh"].ToString();
                sach.MaCD = reader["MaCD"].ToString();
                qlsach.Add(sach);
            }
            conn.Close();
        }
    }
}
