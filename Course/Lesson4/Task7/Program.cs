namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};

        for(int i = 0; i < newList.Length; i += 2)
        {
            Console.WriteLine(newList[i]);
        }
    }
}
