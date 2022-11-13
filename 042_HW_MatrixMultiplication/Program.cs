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
int[,] GetMatrixComposition(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(0); j++)
        {
            for (int k = 0; k < arrayB.GetLength(1); k++)
            {
                arrayC[i, k] += arrayA[i, j] * arrayB[j, k];
            }
        }
    }
    return arrayC;
}

int rowsA = GetNumber("Rows Quantiy of Matrix A");
int columnsA = GetNumber("Columns Quantiy of Matrix A");
int minA = GetNumber("Min number of Matrix A");
int maxA = GetNumber("Max number of Matrix A");
int[,] ArrayA = Fill2DArray(rowsA, columnsA, minA, maxA);

int rowsB = GetNumber("Rows Quantiy of Matrix B");
int columnsB = GetNumber("Columns Quantiy of Matrix B");
int minB = GetNumber("Min number of Matrix B");
int maxB = GetNumber("Max number of Matrix B");
int[,] ArrayB = Fill2DArray(rowsB, columnsB, minB, maxB);

Console.WriteLine("Matrix A:");
PrintArray(ArrayA);
Console.WriteLine("Matrix B:");
PrintArray(ArrayB);

if (ArrayA.GetLength(1) == ArrayB.GetLength(0) || ArrayA.GetLength(0) == ArrayB.GetLength(1))
{
    int[,] ArrayC = GetMatrixComposition(ArrayA, ArrayB);
    PrintArray(ArrayC);
}
else Console.WriteLine("Error.");

