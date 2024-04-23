namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sumNumber(5, 7));
        greetUser("Fellyga");
        Console.WriteLine(max(10, 27));
        Console.WriteLine(isEven(9));
        Console.WriteLine(convertToFahrenheit(7));
        Console.WriteLine(reverseString("hello fell"));
        Console.WriteLine(countChars("hello fell", 'l'));
        Console.WriteLine(calculateFactorial(5));
        Console.WriteLine(isPrime(17));
        Console.WriteLine(generateRandomNumber(1, 100));
    }

    static int sumNumber(int a, int b)
    {
        return a + b;
    }

    static void greetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static int max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static bool isEven(int num)
    {
        return num % 2 == 0;
    }

    static double convertToFahrenheit(double celsius)
    {
        return ((celsius * 9 / 5) + 32);
    }

    static string reverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int countChars(string str, char symbol)
    {
        int count = 0;
        foreach (char i in str)
        {
            if (i == symbol)
            {
                count++;
            }
        }
        return count;
    }

    static int calculateFactorial(int num)
    {
        int result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    static bool isPrime(int num)
    {
        if (num == 2) return true;
        if (num < 2 || num % 2 == 0) return false;

        int maxDivisor = (int)Math.Sqrt(num);

        for (int i = 3; i <= maxDivisor; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int generateRandomNumber(int minRange, int maxRange)
    {
        Random randomNumber = new Random();
        return randomNumber.Next(minRange, maxRange + 1);
    }
}