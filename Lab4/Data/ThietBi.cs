using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    [Table("ThietBi")]
    public class ThietBi
    {
        [Key]
        public int MaThietBi { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenThietBi { get; set; }
        public string TinhTrang { get; set; }
        public string NhietDo { get; set; }
        public string DoAm { get; set; }
        public string AnhSang { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
