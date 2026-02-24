namespace SecureVault.CLI.ConsoleUI;

public static class Main
{
    public static void Start()
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
                    throw new NotImplementedException();
                //break;
                case "create-vault":
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

    private static void DisplayHelp()
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
}