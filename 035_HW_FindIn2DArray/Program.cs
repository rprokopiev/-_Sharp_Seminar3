// на вход принимает позиции элемента в двумерном массиве (row ,column)
// возвращает значение этого элемента или же указание, что такого элемента нет.
int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}
void Fill2DArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
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

}
void IsEnteredLocationExist(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine(array[i, j]);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("такого числа в массиве нет");
    }
}

int[,] Array = new int[3, 4];

int RowIndex = Prompt("Введите номер ряда");
int ColumnIndex = Prompt("Введите номер колонки");
if (RowIndex <= 0 || ColumnIndex <= 0) Console.WriteLine("Ошибка ввода");
else
{
    Fill2DArray(Array, 0, 5);
    PrintArray(Array);
    IsEnteredLocationExist(Array, RowIndex, ColumnIndex);
}
