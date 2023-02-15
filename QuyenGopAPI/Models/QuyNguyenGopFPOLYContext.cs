using Microsoft.EntityFrameworkCore;

namespace QuyenGopAPI.Models
{
    public partial class QuyNguyenGopFPOLYContext : DbContext
    {
        public QuyNguyenGopFPOLYContext()
        {
        }

        public QuyNguyenGopFPOLYContext(DbContextOptions<QuyNguyenGopFPOLYContext> options) : base(options)
        {
        }

        public DbSet<TbBaiVietChuongTrinhNguyenGop> TbBaiVietChuongTrinhNguyenGops { get; set; }
        public DbSet<TbChuDe> TbChuDes { get; set; }
        public DbSet<TbChuongTrinhNguyenGop> TbChuongTrinhNguyenGops { get; set; }
        public DbSet<TbNguoiNguyenGop> TbNguoiNguyenGops { get; set; }
        public DbSet<TbToChucDongHanh> TbToChucDongHanhs { get; set; }



    }
}
