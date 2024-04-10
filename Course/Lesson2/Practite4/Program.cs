namespace Practite4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Эта программа считает ваши нажатия на Enter, чтобы выйти из нее нажмите Esc.");
        ConsoleKeyInfo keyInfo;
        int count = 0;

        do
        {
            keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                count++;
                Console.WriteLine($"Вы нажали Enter {count} раз.");
            }
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}