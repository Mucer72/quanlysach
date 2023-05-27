using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySachCaNhan
{
    internal class MuonSach
    {
        public string MaSach { get; set; }
        public string MaBD { get; set; }
        public string LoaiHinhMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public MuonSach()
        {

        }
        public MuonSach(string maSach, string maBD, string loaiHinhMuon, DateTime ngayMuon, DateTime ngayTra)
        {
            MaSach = maSach;
            MaBD = maBD;
            LoaiHinhMuon = loaiHinhMuon;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
    }
}
