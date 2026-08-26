using Learning.Rot13Cipher;

Console.WriteLine("    Rot13 Cipher    ");
Console.WriteLine();

Console.Write("Type in the message to transform: ");
string message = Console.ReadLine()?.Trim() ?? "";
Console.WriteLine("========================================");
Console.WriteLine(message);
Console.WriteLine("========================================");

while (true)
{
    Console.WriteLine("    Rot13 Cipher    ");
    Console.WriteLine();

    Console.Write("Press 'T' to transform the message. Press any other key to end the program: ");
    string commandInput = Console.ReadLine()?.Trim() ?? "";
    Console.WriteLine();

    if ("tT".Contains(commandInput))
    {
        Console.WriteLine("========================================");
        string transformedMessage = Rot13Cipher.TransformMessage(message);
        Console.WriteLine(transformedMessage);
        Console.WriteLine("========================================");
    }
    else
    {
        break;
    }
}
