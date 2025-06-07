namespace SnapToTable.Domain.Entities;

public record BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
}