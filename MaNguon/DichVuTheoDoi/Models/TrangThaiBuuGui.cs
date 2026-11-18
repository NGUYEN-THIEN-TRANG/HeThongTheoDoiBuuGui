
namespace DichVuTheoDoi.Models;

/// <summary>
/// Các trạng thái vận chuyển bưu gửi theo đề bài.
/// </summary>
public enum TrangThaiBuuGui
{
    Created,
    InTransit,
    AtHub,
    Delivered,
    Failed
}
