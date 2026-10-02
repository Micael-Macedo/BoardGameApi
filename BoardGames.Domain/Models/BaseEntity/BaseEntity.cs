namespace BoardGames.Domain;

public class BaseEntity
{
    public int Id { get; set; }
    public string CreatedByUserId { get; set; } = "MICAEL";
    public DateTime CreatedAt { get; set; } = new DateTime();
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
}