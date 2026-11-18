
namespace DichVuTheoDoi.Models;

/// <summary>
/// Lưu lại từng lần thay đổi trạng thái hoặc địa điểm bưu gửi.
/// </summary>
public class LichSuBuuGui
{
    public int Id { get; set; }

    // Mã vận đơn liên quan
    public string MaVanDon { get; set; } = string.Empty;

    // Địa điểm ghi nhận sự kiện
    public string DiaDiem { get; set; } = string.Empty;

    // Trạng thái được ghi nhận
    public TrangThaiBuuGui TrangThai { get; set; }

    // Thời điểm ghi nhận
    public DateTime ThoiGian { get; set; }

    // Ghi chú bổ sung
    public string? GhiChu { get; set; }
}
