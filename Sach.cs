using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySachCaNhan
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoTrang { get; set; }
        public string NamXB { get; set; }    
        public string ViTriSach { get; set; }
        public string TacGia { get; set; }
        public string MaCD { get; set; }
        public string LinkHinh { get; set; }
        public string LoaiSach { get; set; }
        public int TrangThai { get; set; }


        public Sach()
        {

        }

        public Sach(string maSach, string tenSach, string tacGia, int soTrang, string ngayXB, string theLoai, string loaiSach, string viTriSach, int trangThai, string linkHinh)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            SoTrang = soTrang;
            NamXB = ngayXB;
            MaCD = theLoai;
            LoaiSach = loaiSach;
            ViTriSach = viTriSach;
            TrangThai = trangThai;
            LinkHinh = linkHinh;
        }
    }
}
