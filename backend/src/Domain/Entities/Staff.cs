namespace Domain.Entities;

public class Staff : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;

    public List<StaffService> StaffServices { get; set; } = [];
    public List<WorkingHour> WorkingHours { get; set; } = [];
    public List<TimeOff> TimeOffs { get; set; } = [];
    public List<Booking> Bookings { get; set; } = [];
}
