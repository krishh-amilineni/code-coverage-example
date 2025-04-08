namespace Demo_App;

public class Helper
{
    public void AnotherMethod(string name)
    {
        if (name.ToLower().Equals("test"))
        {
            Console.WriteLine("Calling from another method");
        }
        else if (name.ToLower().Equals("new branch"))
        {
            Console.WriteLine("This is a new uncovered area.");
        }
    }
    
    public int UncoveredMethod(int value)
    {
        if (value > 10)
        {
            return value * 2;
        }
        else if (value > 5)
        {
            return value * 3;
        }
        else
        {
            return value;
        }
    }
}