namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};
        int rotationCount = 2; 
        int length = oneList.Length;

        for (int i = 0; i < rotationCount; i++)
        {
            int lastElement = newList[length - 1];
            for (int j = length - 1; j > 0; j--)
            {
                newList[j] = newList[j - 1];
            }
            onenewListList[0] = lastElement;
        }

        for (int i = 0; i < newList.Length; i++)
        {
            Console.WriteLine(newList[i]);
        }
    }
}
