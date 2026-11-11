namespace Domain.Entities;

public class WorkingHour : BaseEntity
{
    public int StaffId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public Staff Staff { get; set; } = null!;
}
