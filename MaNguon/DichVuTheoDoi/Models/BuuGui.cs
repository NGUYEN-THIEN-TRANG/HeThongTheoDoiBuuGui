
namespace DichVuTheoDoi.Models;

/// <summary>
/// Thông tin chính của một bưu gửi.
/// </summary>
public class BuuGui
{
    public int Id { get; set; }

    // Mã vận đơn duy nhất
    public string MaVanDon { get; set; } = string.Empty;

    // Thông tin người gửi
    public string NguoiGui { get; set; } = string.Empty;

    // Thông tin người nhận
    public string NguoiNhan { get; set; } = string.Empty;

    // Địa điểm hiện tại của bưu gửi
    public string DiaDiemHienTai { get; set; } = string.Empty;

    // Trạng thái hiện tại
    public TrangThaiBuuGui TrangThai { get; set; }

    // Thời điểm tạo bưu gửi
    public DateTime ThoiGianTao { get; set; }

    // Thời điểm cập nhật gần nhất
    public DateTime ThoiGianCapNhat { get; set; }
}
