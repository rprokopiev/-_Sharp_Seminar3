int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateArray(int n, int m)
{
    int [,] array = new int[n, m];
    for (int rows = 0; rows < n; rows++)
    {
        for (int columns = 0; columns < m; columns++)
        {
            array[rows,columns] = rows + columns;
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

int n = GetNumber("Enter rows quantity");
int m = GetNumber("Enter columns quantity");
int [,] Array = CreateArray(n,m);
PrintArray(Array);
