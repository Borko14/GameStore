namespace GameStore.Api;

public record class GameDto(
    int Id,
    string Name,
    string Description,
    int GenreId,
    decimal Price,
    string ImageUrl
);