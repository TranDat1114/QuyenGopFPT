using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuyenGopAPI.Models
{
    [Table("TbNguoiNguyenGop")]
    public class TbNguoiNguyenGop
    {
        //public TbNguoiNguyenGop()
        //{
        //    TbChuongTrinhNguyenGops = new HashSet<TbChuongTrinhNguyenGop>();
        //}
        [Key]
        public int IdNng { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string LienHe { get; set; } = null!;
        public string SoTienNguyenGop { get; set; } = null!;
        public DateTime NgayNguyenGop { get; set; }
        public string HinhThucNguyenGop { get; set; } = null!;
        public string? MucDichNguyenGop { get; set; }

        //public virtual ICollection<TbChuongTrinhNguyenGop> TbChuongTrinhNguyenGops { get; set; }
    }
}
