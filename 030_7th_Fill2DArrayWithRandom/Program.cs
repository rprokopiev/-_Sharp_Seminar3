int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool IsInputLenghtValid(int number)
{
    if (number <= 0)
    {
        return false;
    }
    return true;
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

int n = GetNumber("ВВедите кол-во строк");
int m = GetNumber("Введите кол-во столбцов");
int [,] Array = CreateArray(n,m,-10,10);
PrintArray(Array);

