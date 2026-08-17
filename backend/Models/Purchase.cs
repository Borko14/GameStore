namespace GameStore.Api;

public class Purchase
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }
    public decimal Price { get; set; }
    public DateOnly PurchaseDate { get; set; }
}
