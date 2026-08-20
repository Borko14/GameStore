using System;

namespace GameStore.Api;

public record CreateUserDto(
    string Username,
    string Email,
    string Password
);