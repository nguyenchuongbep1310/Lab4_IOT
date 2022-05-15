using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }
        public string TrangThai { get; set; }
    }
}
