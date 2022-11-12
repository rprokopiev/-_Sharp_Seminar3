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

void GetLowSumRow(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        int Sum = 0;
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Sum = Sum + array[rows, col];
        }
        arr[rows] = Sum;
    }

    int i = 0;
    int min = arr[i];
    int minInd = i+1;
    while (i < arr.Length)
    {
        if (arr[i] < min) 
        {
            min = arr[i]; 
            minInd = i+1;
        }
        i++;
    }
    Console.WriteLine("The minimum sum is in the row # " + minInd);
}

int rows = GetNumber("Quantiy of rows");
int columns = GetNumber("Quantiy of columns");
int min = GetNumber("Array min number");
int max = GetNumber("Array max number");

int[,] Array = Fill2DArray(rows, columns, min, max);
PrintArray(Array);
GetLowSumRow(Array);



