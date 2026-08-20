using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace GameStore.Api;

public record class CreateGameDto(
    [Required][StringLength(50)]string Name,
    [Range(1, 50)] int GenreId,
    string Description,
    decimal Price,
    DateOnly ReleaseDate
);