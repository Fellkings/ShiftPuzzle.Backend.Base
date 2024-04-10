namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};
        int count = 0;
        
        foreach(var i in newList)
        {
            if(i < 0)
            {
                ++count;
            }
        }
        
        Console.WriteLine($"В массиве находится {count} отрицательных чисел.");
    }
}
