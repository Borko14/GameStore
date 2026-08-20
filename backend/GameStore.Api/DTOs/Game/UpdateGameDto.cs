using System.ComponentModel.DataAnnotations;
namespace GameStore.Api;

public record class UpdateGameDto(
    [Required][StringLength(50)]string Name,
    [Range(1, 50)] int GenreId,
    string Description,
    decimal Price,
    DateOnly ReleaseDate
);