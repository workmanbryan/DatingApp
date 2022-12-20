using API.Entities;

namespace API.Interfaces
{
    // Interface is a contract. Anything that uses this interface must support the declarations within.
    // i.e. AppUser in CreateToken
    public interface ITokenService 
    {
         string CreateToken(AppUser user);
    }
}