namespace Domain.Entities;

public class Staff : BaseEntity
{
    public string Name {get; set;} = string.Empty;
    public bool Isactive {get; set;} = true;
}