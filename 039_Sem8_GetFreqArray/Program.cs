int[] array = { 1, 3, 5, 2, 1, 1, 1 };
PrintArr(array);
int[] sortArray = GetSortArray(array);
PrintArr(sortArray);

int[] GetSortArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        int min = array[j];
        int minInd = j;
        for (int i = j; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minInd = i;
            }
        }
        array[minInd] = array[j];
        array[j] = min;
    }
    return array;
}

void PrintArr(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

// int low = GetArrayMin(array);


// int[] rowarray = new int[array.Length];
// rowarray[0] = low;
// for (int i=1; i<array.Length; i++)
// {
//     if (rowarray[i])
// }
// PrintArr(rowarray);


// составить частотный словарь массива

// int GetNumber(string input)
// {
//     Console.WriteLine(input);
//     int n = int.Parse(Console.ReadLine());
//     return n;
// }
// int[,] Fill2DArray(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] Get1DFrom2DArray(int[,] array)
// {
//     int[] arr = new int[array.GetLength(0) * array.GetLength(1)];
//     int l = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arr[l] = array[i, j];
//             l++;
//         }
//     }
//     return arr;
// }



// int rows = GetNumber("Quantiy of rows");
// int columns = GetNumber("Quantiy of columns");
// int min = GetNumber("Array min number");
// int max = GetNumber("Array max number");

// int[,] Array = Fill2DArray(rows, columns, min, max);
// PrintArray(Array);
// int[] array = Get1DFrom2DArray(Array);
// PrintArr(array);




// int count = 0;
// int j = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (j == array[i]) count++;
// }
// Console.WriteLine(count + " - " + j + " шт.");


