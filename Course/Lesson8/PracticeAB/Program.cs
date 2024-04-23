namespace PracticeAB;

class Program
{
    // Творим тут
    // 1
    static int add(int a, int b)
    {
        return a + b;
    }

    // 2
    static bool isEven(int number)
    {
        return number % 2 == 0;
    }

    // 3
    static string reverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);
    }

    // 4
    static int findMax(int[] arr){
        return arr.Max();
    }

    // 5
    static double calculateYearlySalary(double salary)
    {
        return salary * 12;
    }

    // 6
    static double celsiusToFahrenheit(double celsius)
    {
        return celsius * 9/5 + 32;
    }

    // 7
    static int countVowels(string str)
    {
        string vowels = "УуЕеЭэОоАаЫыЯяИиЮю";
        char[] vowels_ar = vowels.ToArray();
        char[] chars = str.ToArray();
        int count = 0;

        foreach (char c in chars)
        {
            foreach (char gl in vowels)
            {
                if (c == gl)
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }   

    // 8
    static int generatePassword(string passtohack)
    {
        int count = 0;
        
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        count++;
                        string generatedpass = Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(h);
                        if (generatedpass == passtohack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль, теперь вы хакер");
                            return count-1;
                        }
                    }
                }
            }
        }
        
        return count;
    }

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все остальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        Console.WriteLine(add(1, 3));
        Console.WriteLine(isEven(7));
        Console.WriteLine(reverseString("fell"));
        Console.WriteLine(findMax(array_nums));
        Console.WriteLine(calculateYearlySalary(2000));
        Console.WriteLine(celsiusToFahrenheit(8));
        Console.WriteLine(countVowels("Привет!"));
        Console.WriteLine(generatePassword("8716"));
    }
}
