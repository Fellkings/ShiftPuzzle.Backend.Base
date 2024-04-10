namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {1, 5, 48, 25, 10};

        foreach(var i in newList)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
