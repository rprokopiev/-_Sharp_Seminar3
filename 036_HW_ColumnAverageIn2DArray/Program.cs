// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Округление до 2х знаков - Math.Round(value, 2)
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
    Console.WriteLine();

}
void GetColumnsAverages(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double Average = 0.0;
        double Sum = 0.0;
        double Count = 0.0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum = Sum + array[i, j];
            Count++;
        }
        Average = Sum / Count;
        Console.Write(Math.Round(Average,2) + " ");
    }
}


int[,] Array = new int[4, 3];
Fill2DArray(Array, 0, 10);
PrintArray(Array);
GetColumnsAverages(Array);


