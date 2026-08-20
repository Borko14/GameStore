namespace GameStore.Api;

public class Purchase
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long GameId { get; set; }
    public decimal Price { get; set; }
    public DateOnly PurchaseDate { get; set; }
}
