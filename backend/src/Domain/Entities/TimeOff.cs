namespace Domain.Entities;

public class TimeOff : BaseEntity
{
    public int StaffId { get; set; }
    public DateTime StartUtc { get; set; }
    public DateTime EndUtc { get; set; }
    public string Reason { get; set; } = string.Empty;

    public Staff Staff { get; set; } = null!;
}
