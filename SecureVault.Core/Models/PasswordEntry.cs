namespace SecureVault.Core.Models;

public class PasswordEntry
{
    public int id;
    public string name;
    public string password;

    public PasswordEntry(int _id, string _name, string _password)
    {
        id = _id;
        name = _name;
        password = _password;
    }
}