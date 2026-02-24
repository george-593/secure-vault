namespace SecureVault.Core.Models;

public class Vault
{
    public int id;
    public string name;
    public List<PasswordEntry> passwords;

    public Vault(int _id, string _name, List<PasswordEntry> _passwords)
    {
        id = _id;
        name = _name;
        passwords = _passwords;
    }
    public Vault(int _id, string _name) : this(_id, _name, new List<PasswordEntry>()) { }
}