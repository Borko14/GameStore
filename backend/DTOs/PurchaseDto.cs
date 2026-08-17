namespace GameStore.Api;

public record class PurchaseDto(
    User User, 
    Game Game, 
    decimal Price,
    DateOnly PurchaseDate
);