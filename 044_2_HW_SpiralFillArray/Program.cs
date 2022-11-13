// СПИРАЛЬНО ЗАПОЛНИТЬ МАССИВ 4 * 4

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

void FillArray4X4(int[,] array)
{
    if (array.GetLength(0) == 4 && array.GetLength(1) == 4) // проверка массива
    {
        int k = array.Length - 3;   // переменная для заполнения внутреннего кольца массива

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int iOrder = i + 1; // нумерация строки с единицы
                int jOrder = j + 1; // нумерация столбца с единицы
                int number = (iOrder + jOrder - 1); // переменная для заполнения внешнего кольца массива
                int change = (jOrder - iOrder + number) / number; // переменная для изменения порядка нумерации
                if (!(i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1)) // заполнение внутреннего кольца массива
                {
                    if (change == 0) array[i, j] = (4 * array.GetLength(0));
                    else
                    {
                        array[i, j] = k;
                        k++;
                    }
                }
                else // заполнение внешнего кольца массива
                {
                    array[i, j] = (change * number) + (((change - 1) * -1) * (4 * array.GetLength(0) - 2 - number));
                }
            }
        }
    }
    else Console.WriteLine("Ошибка ввода");

}

int Lght = 4;
int[,] Array = new int[Lght, Lght];
FillArray4X4(Array);
PrintArray(Array);
