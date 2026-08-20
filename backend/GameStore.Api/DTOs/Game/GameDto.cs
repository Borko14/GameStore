using System.ComponentModel.DataAnnotations;

namespace GameStore.Api;

public record class GameDto(
    long Id,
    [Required][StringLength(50)] string Name,
    string? Description,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);