namespace GameStore.Api;

public class User
{
    int Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public Role? Role { get; set; }
    
}
