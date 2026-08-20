namespace GameStore.Api;

public class Review
{
    public long Id { get; set; }
    public required string Content { get; set; }
    public int Rating { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public long GameId { get; set; }
    public Game Game { get; set; } = null!;
    public long UserId { get; set; }
    public User User { get; set; } = null!;

}