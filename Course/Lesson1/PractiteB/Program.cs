namespace PractiteB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Калькулятор");

        Console.Write("Введите число - ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ваше число {numberOne}");

        Console.Write("Введите число - ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ваше число {numberTwo}");
        

        int additions = numberOne + numberTwo;
        int subtraction = numberOne - numberTwo;
        int multiplication = numberOne * numberTwo;
        int division = numberOne / numberTwo;

        Console.WriteLine($"Результат сложения: {additions}");
        Console.WriteLine($"Результат вычитания: {subtraction}");
        Console.WriteLine($"Результат умножения: {multiplication}");
        Console.WriteLine($"Результат деления: {division}");
    }
}
