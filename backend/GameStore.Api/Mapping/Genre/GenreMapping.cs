using System;

namespace GameStore.Api;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto(
            genre.Id,
            genre.Name ?? string.Empty
        );
    }
    public static Genre ToEntity(this GenreDto dto)
    {
        return new Genre
        {
            Name = dto.Name
        };
    }
}