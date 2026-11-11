using Domain.Enums;

namespace Domain.Entities;

public class Booking : BaseEntity
{
    public int UserId { get; set; }
    public int StaffId { get; set; }
    public int ServiceId { get; set; }
    public DateTime StartUtc { get; set; }
    public DateTime EndUtc { get; set; }
    public decimal PriceAtBooking { get; set; }
    public BookingStatus Status { get; set; } = BookingStatus.Pending;

    public User User { get; set; } = null!;
    public Staff Staff { get; set; } = null!;
    public Service Service { get; set; } = null!;
}
