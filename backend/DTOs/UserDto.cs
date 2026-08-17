namespace GameStore.Api;

public record class UserDto(
    int Id,
    string Username, 
    string Email, 
    Role Role
);