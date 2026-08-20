namespace GameStore.Api;

public record class UpdateReviewDto(
    string Content,
    int Rating
);