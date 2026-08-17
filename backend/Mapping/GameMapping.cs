using System.Data.Common;
using System.Runtime.CompilerServices;

namespace GameStore.Api;

public class GameMapping
{
    public static Game ToEntity(this CreateGameDto dto)
    {
        return new Game
        {
            Name = dto.Name,
            Description = dto.Description,
            GenreId = dto.GenreId,
            Price = dto.Price,
            ReleaseDate = dto.ReleaseDate
        };
    }
    public static GameDto ToDto(this Game game)
    {
        return new GameDto
        {
            Id = game.Id,
            Name = game.Name,
            Description = game.Description,
            GenreId = game.GenreId,
            Price = game.Price,
            Genre = game.Genre,
            ReleaseDate = game.ReleaseDate
        };
    }
}