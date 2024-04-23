namespace Homework;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 2, 3, 4, 3, 1, 2, 3, 4, 2, 2 };
        List<int> mostFrequentNumbers = FindMostFrequentNumbers(numbers);
        Console.Write("Первое задание \nНаиболее часто встречающимися числами в массиве являются: ");
        foreach (var num in mostFrequentNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] transposedMatrix = TransposeMatrix(matrix);

        Console.WriteLine("Второе задание");
        PrintMatrix(transposedMatrix);
    }

    static List<int> FindMostFrequentNumbers(int[] numbers)
    {
        var frequencyMap = new Dictionary<int, int>();

        foreach (var num in numbers)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap[num] = 1;
            }
            else
            {
                frequencyMap[num]++;
            }
        }

        List<int> mostFrequentNumbers = new List<int>();
        int maxFrequency = 0;
        foreach (var pair in frequencyMap)
        {
            if (pair.Value == maxFrequency)
            {
                mostFrequentNumbers.Add(pair.Key);
            }
            else if (pair.Value > maxFrequency)
            {
                mostFrequentNumbers.Clear();
                mostFrequentNumbers.Add(pair.Key);
                maxFrequency = pair.Value;
            }
        }

        return mostFrequentNumbers;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}