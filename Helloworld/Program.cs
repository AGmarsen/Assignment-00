namespace Helloworld;

public class Program
{
    private static void Main(String[] args)
    {
        string input = Console.ReadLine();
        var runner = new Program();
        var cleansed = Convert.ToInt32(input);
        Console.WriteLine(runner.LeapYear(cleansed) ? "yay" : "nay");
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


