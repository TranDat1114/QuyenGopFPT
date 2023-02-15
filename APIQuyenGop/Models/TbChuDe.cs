using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIQuyenGop.Models
{
    [Table("TbChuDe")]
    public class TbChuDe
    {
        //public TbChuDe()
        //{
        //    TbBaiVietChuongTrinhNguyenGops = new HashSet<TbBaiVietChuongTrinhNguyenGop>();
        //}
        [Key]
        public int IdChuDe { get; set; }
        public string TenChuDe { get; set; } = null!;

        //public virtual ICollection<TbBaiVietChuongTrinhNguyenGop> TbBaiVietChuongTrinhNguyenGops { get; set; }
    }
}
