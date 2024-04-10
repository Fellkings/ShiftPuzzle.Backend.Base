namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число - ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число - ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        int resultAdd = numberOne + numberTwo;
        
        Console.WriteLine($"Результат сложение ваших чисел - {resultAdd}");
    }
}
