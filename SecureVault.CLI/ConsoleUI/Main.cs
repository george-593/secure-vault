using SecureVault.Core;

namespace SecureVault.CLI.ConsoleUI;

public class Main
{
    private VaultManager vaultManager = new VaultManager();

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Secure Vault CLI\nType 'help' to view available commands");

        while (true)
        {
            Console.Write("> ");
            string[] input = Console.ReadLine()!.Split(" ");

            switch (input[0])
            {
                case "help":
                    DisplayHelp();
                    break;
                case "exit":
                case "quit":
                    Environment.Exit(0);
                    break;
                case "load-vault":
                    LoadVault(input);
                    break;
                case "create-vault":
                    CreateVault(input);
                    break;
                case "delete-vault":
                    throw new NotImplementedException();
                //break;
                case "lock-vault":
                    break;
                case "add-password":
                    break;
                case "delete-password":
                    throw new NotImplementedException();
                //break;
                case "view-password":
                    break;
                case "list-passwords":
                    break;
                default:
                    Console.WriteLine("Unknown command, please try again.");
                    break;
            }
        }
    }

    private void DisplayHelp()
    {
        Console.WriteLine("Commands and usage:");

        Console.WriteLine("\nVault Management: ");
        Console.WriteLine("load-vault [vault-name/vault-id]");
        Console.WriteLine("create-vault [vault-name]");
        Console.WriteLine("delete-vault [vault-name/vault-id]");
        Console.WriteLine("lock-vault");

        Console.WriteLine("\nPassword Operations (requires loaded vault)");
        Console.WriteLine("add-password [password-name]");
        Console.WriteLine("delete-password [password-name/password-id]");
        Console.WriteLine("view-password [password-name/password-id]");
        Console.WriteLine("list-passwords");

        Console.WriteLine("\nOther:");
        Console.WriteLine("help");
        Console.WriteLine("exit, quit");
    }

    private void LoadVault(string[] input)
    {

    }

    private void CreateVault(string[] input)
    {
        string vaultName = input[1];

        if (vaultName == "")
        {
            Console.WriteLine("Error: No vault name provided.");
            return;
        }

        string masterPassword = ConsoleInputHelper.GetSecureInput();

        if (!ConsoleInputHelper.ValidateFollowPasswordRules(masterPassword))
        {
            // Placeholder function, this code path will never be triggered currently
        }

        if (!ConsoleInputHelper.ValidateSecureInput(masterPassword))
        {
            Console.WriteLine("Master passwords do not match, please try again");
            CreateVault(input);
            return;
        }

        try
        {
            Console.WriteLine("Creating vault");
            vaultManager.CreateVault(vaultName, masterPassword);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unhandled exception occured: {e.Message}");
        }
    }

    private void DeleteVault(string[] input)
    {

    }

    private void Lockvault(string[] input)
    {

    }
}