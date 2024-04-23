namespace PracticeA;

class Program
{
    //task 1
    static int factorial(int a)
    {
        if (a <= 1)
        {
            return 1;
        }
        else
        {
            return a * factorial(a - 1);
        }
    }
    //task 1

    //task 2
    static int fibonachiNums(int num)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        return fibonachiNums(num - 1) + fibonachiNums(num - 2);
    }
    //task 2

    //task 3
    static string reverseString(string a)
    {
        if (a.Length <= 1)
        {
            return a;
        }
        else
        {
            return a[a.Length - 1] + reverseString(a.Substring(0, a.Length - 1));
        }
    }
    //task 3

    //task 4
    static int sumElements(int[] a)
    {
        if (a.Length == 1)
        {
            return a[0];
        }
        else
        {
            return sumElements(a[0..(a.Length - 1)]) + a[a.Length - 1];
        }
    }
    //task 4

    //task 5
    static int greatestCommonDivisor(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return a + b;
        }
        else
        {
            if (a > b)
            {
                return greatestCommonDivisor(a % b, b);
            }
            else
            {
                return greatestCommonDivisor(a, b % a);
            }
        }
    }
    //task 5

    //task 6
    static bool isPolindrome(string a)
    {
        if (a == Revers(a))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //task 6

    //task 7
    static void MoveTowers(int disks, string source, string auxiliary, string destination)
    {
        if (disks == 1)
        {
            Console.WriteLine($"Передвиньте диск 1 с {source} на {destination}");
        }
        else
        {
            MoveTowers(disks - 1, source, destination, auxiliary);
            Console.WriteLine($"Передвиньте диск {disks} с {source} на {destination}");
            MoveTowers(disks - 1, auxiliary, source, destination);
        }
    }
    //task 7

    //task 8
    static void generateSubsets(List<int> set, List<int> subset, int index)
    {
        if (index == set.Count)
        {
            Console.WriteLine("Subset: " + string.Join(", ", subset));
            return;
        }

        subset.Add(set[index]);
        generateSubsets(set, subset, index + 1);
        subset.RemoveAt(subset.Count - 1);

        generateSubsets(set, subset, index + 1);
    }
    //task 8

    //task 9
    //task 9

    //task 10
    //task 10
}
