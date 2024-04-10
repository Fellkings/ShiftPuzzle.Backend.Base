namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int[] newList = {-1, 5, 48, 25, -10};
        
        for(int i = 0; i < newList.Length; i ++)
        {
            newList[i] = newList[i] < 0? 0: newList[i];
        }
    }
}
