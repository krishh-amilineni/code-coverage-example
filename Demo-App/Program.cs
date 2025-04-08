namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        var helper = new Helper();
        if (args.Length > 0)
        {
            Console.WriteLine($"Howdy, {args[0]}!{Environment.NewLine}");
            helper.AnotherMethod(args[0]);
        }
        else
        {
            Console.WriteLine($"Hello there!{Environment.NewLine}");
        }

        Console.WriteLine("Complete");
    }
}