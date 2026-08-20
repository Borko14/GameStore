namespace GameStore.Api;

public record class CreateReviewDto(
    string Content,
    int Rating
);