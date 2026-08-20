using System.Data.Common;
using System.Runtime.CompilerServices;

namespace GameStore.Api;

public static class GameMapping
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
        return new GameDto(
            game.Id,
            game.Name,
            game.Description,
            game.GenreId,
            game.Price,
            game.ReleaseDate
            );
    }
    public static void UpdateEntity(this UpdateGameDto dto, Game game)
    {
        game.Name = dto.Name;
        game.Description = dto.Description;
        game.GenreId = dto.GenreId;
        game.Price = dto.Price;
        game.ReleaseDate = dto.ReleaseDate;
    }
}