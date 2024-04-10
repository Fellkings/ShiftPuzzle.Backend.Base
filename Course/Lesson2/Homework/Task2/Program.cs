namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Приветствую, это игра 'Угадай число'");
        Random rand = new Random();
        int numberPC = rand.Next(1, 11);
        Console.Write("Компьютер загадал число от 1 до 10. Введите число - ");
        int numberUser = Convert.ToInt32(Console.ReadLine());

        
       while (true)
       {
            if (numberPC == numberUser)
            {
                Console.WriteLine($"Да! Компьютер загадал число {numberPC}!");
                break;
            }
            else if (numberPC < numberUser)
            {
                Console.Write($"Нет, число меньше! Попробуйте еще раз, введите число - ");
                numberUser = Convert.ToInt32(Console.ReadLine()); 
            }
            else
            {   
                if (numberPC > numberUser)
                {
                    Console.Write($"Нет, число больше! Попробуйте еще раз, введите число - ");
                    numberUser = Convert.ToInt32(Console.ReadLine()); 
                }

            }
       }
    }
}

