using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] newList = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10};
            int N = 3;
            Array.Sort(newList);
            int[] output = new int[N];

            for(int i = 0; i < N; i++)
            {
                output[i] = newList[newList.Length-1-i];
            }

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
            //не выходя за пределы
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] newList = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10};
            Array.Sort(newList);
            int uniqueCount = 1;

            for (int i = 1; i < newList.Length; i++)
            {
                if (newList[i] != newList[i - 1])
                {
                    uniqueCount++;
                }
            }   

            foreach (int number in newList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Число уникальных элементов: " + uniqueCount);
            //не выходя за пределы
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] newList = {1, 2, 3, 3, 3, 3, 7, 7, 7, 7 };
            int[] rateList = new int[newList.Length];
            
            for (int i = 0; i < newList.Length; i++)
            {
                int num = newList[i];
                rateList[num]++;
            }
            
            int maxRepeat  = 0;
            for (int i = 0; i < rateList.Length; i++)
            {
                if (rateList[i] > maxRepeat)
                {
                    maxRepeat = rateList[i];
                }
            }
            
            for (int i = 0; i < rateList.Length; i++)
            {
                if (rateList[i] == maxRepeat)
                {
                    Console.WriteLine($"Число '{i}' появляется {maxRepeat} раза");
                }
            }
            //не выходя за пределы
        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь

            int[] oldList = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10};
            int K = 3;

            Console.WriteLine("Исходный массив:");
            foreach (var i in oldList)
            {
                Console.Write(i + " ");
            }

            int[] newList = new int[oldList.Length];
            for (int i = 0; i < oldList.Length; i++)
            {
                newList[(i + K) % oldList.Length] = oldList[i];
            }

            for (int i = 0; i < oldList.Length; i++)
            {
                oldList[i] = newList[i];
            }

            Console.WriteLine("\nНовый массив:");
            foreach (var i in oldList)
            {
                Console.Write(i + " ");
            }
            //не выходя за пределы
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] oneList = {1, 2, 3, 4, 5, 6, 7};
            int[] twoList = {3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine("Первый массив:");
            foreach (int num in oneList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив:");
            foreach (int num in twoList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            var commonNumbers = oneList.Intersect(twoList).Distinct().ToArray();
            Console.WriteLine("Числа, встречающиеся в обоих массивах:");
            foreach (int num in commonNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            //не выходя за пределы
        }
    }
}
