namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {1, 5, 48, 25, 10};
        int sum = 0;

        foreach(var num in newList)
        {
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
