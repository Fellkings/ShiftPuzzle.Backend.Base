namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] oneList = {-1, 5, 48, 25, -10};
        int[] twoList = {1, -5, -48, -25, 10};
        int[] threeList = oneList.Concat(twoList).ToArray();

        for (int i = 0; i < threeList.Length; i++)
        {
            Console.WriteLine(threeList[i]);
        }
    }
}
