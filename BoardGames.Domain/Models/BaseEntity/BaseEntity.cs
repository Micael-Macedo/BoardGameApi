namespace BoardGames.Domain;

public class BaseEntity
{
    public Guid Id { get; set; }
    public string CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}