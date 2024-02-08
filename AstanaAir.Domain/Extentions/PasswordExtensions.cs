using System.Security.Cryptography;
using System.Text;
using AstanaAir.Domain.Entities;

namespace AstanaAir.Domain.Extentions
{
    public static class PasswordExtensions
    {
        const int KeySize = 64;
        const int Iterations = 350000;
        static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;

        public static User HashPassword(this User user, string password)
        {
            user.Hash = HashPassword(password, out var salt);
            user.Salt = salt;
            return user;
        }
        private static string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(KeySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                Iterations,
                HashAlgorithm,
                KeySize);
            return Convert.ToHexString(hash);
        }

        public static bool PasswordIsValid(this User user, string password)
        {
            return VerifyPassword(password, user.Hash, user.Salt);
        }
        private static bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithm, KeySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
