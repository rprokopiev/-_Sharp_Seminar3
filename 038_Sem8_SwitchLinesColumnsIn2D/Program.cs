int GetNumber(string input)
{
    Console.WriteLine(input);
    int n = int.Parse(Console.ReadLine());
    return n;
}
int[,] Fill2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}
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

// создаём другой изменённый массив 
void PrintChangedArray(int rows, int columns, int min, int max)
{
    if (rows == columns)
    {
        int[,] Array = Fill2DArray(rows, columns, min, max);
        PrintArray(Array);
        int[,] ChangedArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                {
                    if (i == j)
                    {
                        ChangedArray[i, j] = Array[i, j];
                    }
                    else
                    {
                        ChangedArray[i, j] = Array[j, i];
                    }

                }

            }

        }
        PrintArray(ChangedArray);
    }
    else Console.WriteLine("Impossible");
}

// изменяем текущий массив
void ChangePrintArray(int rows, int columns, int min, int max)
{
    if (rows == columns)
    {
        int[,] Array = Fill2DArray(rows, columns, min, max);
        PrintArray(Array);

        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[j, i];
                    Array[j, i] = temp;
                }
            }
        }
        PrintArray(Array);
    }
    else Console.WriteLine("Impossible");
}

int rows = GetNumber("Quantiy of rows");
int columns = GetNumber("Quantiy of columns");
int min = GetNumber("Array min number");
int max = GetNumber("Array max number");
// PrintChangedArray(rows, columns, min, max);

ChangePrintArray(rows, columns, min, max);

