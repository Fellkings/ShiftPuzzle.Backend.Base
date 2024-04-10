namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};
        int searchNum = 25;
        
        for(int i = 0; i < newList.Length; i++)
        {
            if(newList[i] == searchNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
