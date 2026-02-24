namespace SecureVault.Core.Interfaces;

interface IEncryptionService
{
    byte[] Encrypt(string plaintext, byte[] encryptionKey);
    string Decrypt(byte[] encryptedData, byte[] encryptionKey);
}