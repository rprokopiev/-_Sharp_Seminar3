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
            Console.Write($"{array[rows,columns]}\t");
        }
        Console.WriteLine();
    }
}
int[,] CreateDublicateWithPow(int[,] array)
{
    int [,] array1 = new int [array.GetLength(0),array.GetLength(1)];

    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for(int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (rows % 2 ==1 && columns % 2 ==1)
            {
                array1[rows,columns] = array[rows,columns]*array[rows,columns];
            }
            else
            {
                array1[rows,columns] = array[rows,columns];
            }          
        }
    }
    return array1;
}

int n = GetNumber("Enter rows qty");
int m = GetNumber("Enter columns qty");
int [,] Array = CreateArray(n, m, 1, 10);
PrintArray(Array);
int [,] resultArray = CreateDublicateWithPow(Array);
Console.WriteLine();
PrintArray(resultArray);
PrintArray(Array);
