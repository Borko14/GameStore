namespace GameStore.Api;

public record class PurchaseDto(
    long Id,
    long UserId, 
    long GameId, 
    decimal Price,
    DateOnly PurchaseDate
);