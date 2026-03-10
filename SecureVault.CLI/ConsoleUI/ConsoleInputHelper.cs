namespace SecureVault.CLI.ConsoleUI;

public static class ConsoleInputHelper
{
    public static string GetSecureInput(bool displayText = true)
    {
        if (displayText) Console.Write("Enter Password: ");

        List<char> finalInput = new List<char>();
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter) break;
            else if (key.Key == ConsoleKey.Backspace)
            {
                finalInput.RemoveAt(finalInput.Count - 1);
                Console.Write("\b \b");
                continue;
            }

            finalInput.Add(key.KeyChar);
            Console.Write("*");
        }
        Console.Write("\n");
        return finalInput.ToString()!;
    }

    public static bool ValidateSecureInput(string input1)
    {
        Console.Write("Confirm Password: ");
        string input2 = GetSecureInput(false);

        if (input1 == input2) return true;
        return false;
    }

    public static bool ValidateFollowPasswordRules(string password)
    {
        return true;
    }
}