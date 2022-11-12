int[,,] Fill3DArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " (" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


int rows = 2;
int columns = 2;
int depth = 2;
int min = 10;
int max = 99;

int[,,] Array = Fill3DArray(rows, columns, depth, min, max);
Print3DArray(Array);