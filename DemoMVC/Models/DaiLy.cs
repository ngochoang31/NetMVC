using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("DaiLy")]
    public class DaiLy
    {
        [Key]
        public string MaDaily { get; set; }
        public string TenDaily { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string NguoiDaiDien { get; set; }
        public string MaHTPP { get; set; }
    }
}