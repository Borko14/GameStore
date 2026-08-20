namespace GameStore.Api;

public static class UserMapping
{
    public static User ToEntity(this CreateUserDto dto, Role role)
    {
        return new User
        {
            Username = dto.Username,
            Email = dto.Email,
            Password = dto.Password,
            Role = role
        };
    }
    public static UserDto ToDto(this User user)
    {
        return new UserDto(
            user.Id,
            user.Username,
            user.Email,
            user.Role
        );
    }
}
