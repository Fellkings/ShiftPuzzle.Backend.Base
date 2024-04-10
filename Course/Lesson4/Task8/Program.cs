namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};
        int max = newList[0];
        int min = newList[0];

        foreach(var num in newList)
        {
            max = max < num? num : max;
            min = min > num? num : max;
        }
        Console.WriteLine($"В массиве максимальное значение - {max}, а минимальное - {min}.");
    }
}
