// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// (Округление до 2х знаков после запятой - Math.Round(value, 2))

void FillDouble2DArray(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int n = new Random().Next(min, max);
            array[i, j] = new Random().NextDouble();
            array[i, j] = Math.Round((array[i, j] * n), 2);
        }
    }
}
void PrintArray(double[,] array)
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

double[,] Array = new double[3, 4];
FillDouble2DArray(Array, -10, 10);
PrintArray(Array);
