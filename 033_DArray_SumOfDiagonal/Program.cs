int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] CreateArray(int n, int m, int min, int max)
{
    int [,] array = new int[n, m];
    for (int rows = 0; rows < n; rows++)
    {
        for (int columns = 0; columns < m; columns++)
        {
            array[rows,columns] = new Random().Next(min,max+1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows,columns]} ");
        }
        Console.WriteLine();
    }
}
int GetDArrayDiagonalSum(int[,] array)
{
    int sum = 0;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for(int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (rows == columns) sum = sum + array[rows,columns];
        }
    }
    return sum;
}

int n = GetNumber("Enter rows qty");
int m = GetNumber("Enter columns qty");
int [,] Array = CreateArray(n, m, 1, 10);
PrintArray(Array);
int DiagSum = GetDArrayDiagonalSum(Array);
Console.WriteLine();
Console.WriteLine(DiagSum);

