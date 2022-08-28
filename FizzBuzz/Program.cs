namespace FizzBuzz;

public class Program
{

    public static void Main()
    {
        
    }
    public string FizzBuzz(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return "It is not a multiple of 3 or 5";
    }
}

