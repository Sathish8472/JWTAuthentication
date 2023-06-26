using JWTAuthentication.Models;

namespace JWTAuthentication.Repository
{
    public interface IJWTManageRepository
    {
        public Tokens Authenticate(Users user);
    }
}
