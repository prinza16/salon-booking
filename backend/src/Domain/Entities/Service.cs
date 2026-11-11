namespace Domain.Entities;

public class Service : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public decimal Price { get; set; }

    public List<StaffService> StaffServices { get; set; } = [];
    public List<Booking> Bookings { get; set; } = [];
}
