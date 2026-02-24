namespace SecureVault.Core.Interfaces;

interface IMasterPasswordHasher
{
    string HashPassword(string password, byte[] salt);
    bool VerifyPassword(string password, string hash, byte[] salt);
}