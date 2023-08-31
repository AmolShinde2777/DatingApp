namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string UserName { get; set;}
    public byte[] PassworddHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
