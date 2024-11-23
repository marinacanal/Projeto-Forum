namespace Domain.UserDomain.Services
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool VerifyHashedPassword(string salt_hashedPassword, string password);
    }
}