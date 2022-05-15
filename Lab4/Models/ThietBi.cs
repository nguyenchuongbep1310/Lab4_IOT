using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ThietBiVM
    {
        public string NhietDo { get; set; }
        public string DoAm { get; set; }
        public string AnhSang { get; set; }

    }
    public class ThietBi: ThietBiVM
    {
        public int MaThietBi { get; set; }
        public string TinhTrang { get; set; }
    }
}
