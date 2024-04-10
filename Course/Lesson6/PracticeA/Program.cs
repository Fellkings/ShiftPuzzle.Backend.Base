namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(5, 3));
        GreetUser("John");
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(IsEven(7));
        Console.WriteLine(ConvertToFahrenheit(25));
        Console.WriteLine(ReverseString("hello"));
        Console.WriteLine(CountChars("hello", 'l'));
        Console.WriteLine(CalculateFactorial(5));
        Console.WriteLine(IsPrime(17));
        Console.WriteLine(GenerateRandomNumber(1, 100));
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    static double ConvertToFahrenheit(double celsius)
    {
        return ((celsius * 9 / 5) + 32);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CountChars(string str, char ch)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ch)
            {
                count++;
            }
        }
        return count;
    }

    static int CalculateFactorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = i;
        }
        return result;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int GenerateRandomNumber(int min, int max)
    {
        Random rnd = new Random();
        return rnd.Next(min, max + 1);
    }
}