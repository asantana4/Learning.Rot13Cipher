using Learning.Rot13Cipher;

string message = "";

while (true)
{
    Console.Clear();
    Console.WriteLine("    Rot13 Cipher    ");
    Console.WriteLine();

    if (string.IsNullOrEmpty(message))
    {
        Console.Write("Type in the message to transform: ");
        message = Console.ReadLine()?.Trim() ?? "";
    }
    Console.WriteLine("========================================");
    Console.WriteLine(message);
    Console.WriteLine("========================================");

    Console.Write("Press 'T' to transform the message. Press any other key to end the program: ");
    ConsoleKeyInfo commandInput = Console.ReadKey(intercept: true);

    if (commandInput.Key == ConsoleKey.T)
    {
        message = Rot13Cipher.TransformMessage(message);
    }
    else
    {
        Console.WriteLine("\nExiting program...");
        break;
    }
}
