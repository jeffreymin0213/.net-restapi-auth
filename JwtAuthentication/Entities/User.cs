namespace JwtAuthentication.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;

    public byte[] PwdHash { get; set; } = Array.Empty<byte>();
    public byte[] PwdSalt { get; set; } = Array.Empty<byte>();
}