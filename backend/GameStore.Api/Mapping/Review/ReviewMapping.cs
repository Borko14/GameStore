using System;

namespace GameStore.Api;

public static class ReviewMapping
{
    public static ReviewDto ToDto(this Review review, bool IsverifiedPurchase)
    {
        return new ReviewDto(
            review.Id,
            review.Content,
            review.Rating,
            review.CreatedAt,
            review.UpdatedAt ?? review.CreatedAt,
            review.UserId,
            review.GameId,
            IsverifiedPurchase
        );
    }
    public static Review ToEntity(this CreateReviewDto dto, long UserId, long GameId)
    {
        return new Review
        {
            Content = dto.Content,
            Rating = dto.Rating,
            UserId = UserId,
            GameId = GameId,
            CreatedAt = DateTime.UtcNow
        };
    }
}