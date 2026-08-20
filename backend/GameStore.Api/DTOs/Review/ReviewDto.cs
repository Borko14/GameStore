namespace GameStore.Api;

public record class ReviewDto(
    long Id,
    string Content,
    int Rating,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    long GameId,
    long UserId,
    bool IsVerifiedPurchase
);