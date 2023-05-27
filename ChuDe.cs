using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySachCaNhan
{
    internal class ChuDe
    {
        public string MaCD { get; set; }
        public string TenCD { get; set; }
        public ChuDe()
        {

        }
        public ChuDe(string maCD, string tenCD)
        {
            MaCD = maCD;
            TenCD = tenCD;
        }
    }
}
