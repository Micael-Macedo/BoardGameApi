namespace BoardGames.Domain;

public class BaseEntity<T>
{
    public Guid Id { get; set; }
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}