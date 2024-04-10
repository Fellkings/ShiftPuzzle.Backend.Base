namespace Practite3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет! Это контактная книга. Введите имя контакта и его номер телефона");
        Console.Write("Имя: ");
        string name = Console.ReadLine()??"";
        Console.Write("Номер телефона: ");
        string number = Console.ReadLine()??"";
        Console.WriteLine($"Контакт: {name} - {number}");
    }
}
