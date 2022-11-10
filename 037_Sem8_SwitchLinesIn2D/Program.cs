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

int rows = GetNumber("Quantiy of rows");
int columns = GetNumber("Quantiy of columns");
int min = GetNumber("Array min number");
int max = GetNumber("Array max number");

int[,] Array = Fill2DArray(rows, columns, min, max);

PrintArray(Array);

for (int j = 0; j < columns; j++)
{
    int i = 0;
    int l = Array[i,j];
    Array[i,j] = Array[rows-1,j]; 
    Array[rows-1,j] = l;
}

PrintArray(Array);