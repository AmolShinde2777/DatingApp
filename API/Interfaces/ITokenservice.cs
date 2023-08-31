using API.Entities;

namespace API.Interfaces
{
    public interface ITokenservice
    {
        string CreateToken(AppUser user);
    }
}