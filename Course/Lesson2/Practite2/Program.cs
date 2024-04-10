namespace Practite2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваш год рождения - ");

        int birthYear = Convert.ToInt32(Console.ReadLine());
        int ageUser = 2024 - birthYear;

        Console.WriteLine($"Ваш возраст - {ageUser}");
    }
}
