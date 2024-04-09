namespace PractiteC;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Напишите ваше число - ");

        int number = Convert.ToInt32(Console.ReadLine());
        int newNumber = number + 5;

        Console.WriteLine($"Результат преображения вашего числа: {newNumber}");
    }
}
