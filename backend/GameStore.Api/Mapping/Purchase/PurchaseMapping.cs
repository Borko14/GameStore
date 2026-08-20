using System;

namespace GameStore.Api;

public static class PurchaseMapping
{
    public static PurchaseDto ToDto(this Purchase purchase, long UserId, long GameId)
    {
        return new PurchaseDto(
            purchase.Id,
            UserId,
            GameId,
            purchase.Price,
            purchase.PurchaseDate
            );
    }
    public static Purchase ToEntity(this PurchaseDto dto, long UserId, long GameId)
    {
        return new Purchase
        {
            UserId = UserId,
            GameId = GameId,
            Price = dto.Price,
            PurchaseDate = dto.PurchaseDate
        };
    }
}