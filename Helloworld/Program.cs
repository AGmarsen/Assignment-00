namespace Helloworld;

public class Program
{
    private static void Main(String[] args)
    {
        Console.WriteLine("Hello world!");
    }


    public bool LeapYear(int year)
    {
        if (year < 1752) return false;
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        if (year % 4 == 0) return true;
        return false;
    }
}


