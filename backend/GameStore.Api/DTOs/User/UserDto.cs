namespace GameStore.Api;

public record class UserDto(
    long Id,
    string Username, 
    string Email,
    Role Role
);