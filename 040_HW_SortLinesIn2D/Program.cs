// Задать 2-мерный массив
// Упорядочить по убыванию элементы каждой строки

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
int[,] SortRowsIn2DArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            int maxValue = array[rows, col];
            int maxRow = rows;
            int maxCol = col;
            for (int i = col; i < array.GetLength(1); i++)
            {
                if (array[rows, i] > maxValue)
                {
                    maxValue = array[rows, i];
                    maxRow = rows;
                    maxCol = i;
                }
            }
            array[maxRow, maxCol] = array[rows, col];
            array[rows, col] = maxValue;
        }
    }
    return array;
}

int rows = GetNumber("Quantiy of rows");
int columns = GetNumber("Quantiy of columns");
int min = GetNumber("Array min number");
int max = GetNumber("Array max number");

int[,] Array = Fill2DArray(rows, columns, min, max);
PrintArray(Array);
int[,] SortArray = SortRowsIn2DArray(Array);
PrintArray(SortArray);
