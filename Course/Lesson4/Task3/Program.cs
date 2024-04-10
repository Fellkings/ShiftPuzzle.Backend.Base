namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {1, 5, 48, 25, 10};
        Array.Reverse(newList);
        
        for (int i = 0; i < newList.Length; i++)
        {
            Console.WriteLine(newList[i]);
        }
    }
}
