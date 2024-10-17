namespace MyWebApi.Logging;

public class Logging : ILogging
{
    public void Logg(string message, string type)
    {
        if (type == "error")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR - " + message);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            {
                Console.WriteLine(message);
            }
        }
    }

}
