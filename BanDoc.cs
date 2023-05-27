using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySachCaNhan
{
    internal class BanDoc
    {
        public string MaBD { get; set; }
        public string TenBD { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public BanDoc()
        {

        }

        public BanDoc(string maBD, string tenBD, string sDT, string diaChi)
        {
            MaBD = maBD;
            TenBD = tenBD;
            SDT = sDT;
            DiaChi = diaChi;
        }
    }
}
