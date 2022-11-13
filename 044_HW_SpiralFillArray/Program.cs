void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Array = new int[4, 4];

PrintArray(Array);

int[,] SpiralFillArray(int[,] array)
{
    for (int m = 1; m < array.Length; m++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = m;
                m++;
            }
        }
    }
    return array;
}

int[,] Arr = SpiralFillArray(Array);

PrintArray(Array);

// int m = 1;

// while (m <= 16)
// {
//     int n = m % 4;
//     Console.WriteLine(m + " - " + n);
//     m++;
// }

