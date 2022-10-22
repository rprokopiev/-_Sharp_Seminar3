double GetNumber (string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

void Fill2DArrayFromTerminal(double [,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int i = 0;
    int j = 0;
    string [] countJ = {"k","b"};
    int [] countI = {1,2};
    while (i < rows)
    {
        while (j < columns)
        {
            array[i,j] = GetNumber("Введите значение " + countJ[j] + countI[i]);
            j++;
        }
        i++;
        j = 0;
    }
}

void Print2DArray (double [,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows; 
    int i = 0;
    int j = 0;
    while (i < rows)
    {
        while(j < columns)
        {
            Console.Write(array[i,j] + " / ");
            j++;
        }
        i++;
        j = 0;
    }
}

void GetCrossPoint (double [,] array)
{
    double X = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
    double Y = (array[0,0]*X)+array[0,1];
    Console.WriteLine();
    Console.WriteLine("Точка пересечения двух прямых - " + "(" + X + "; " + Y + ")" );
}

double [,] Array = new double[2,2];
Fill2DArrayFromTerminal(Array);
Print2DArray(Array);
GetCrossPoint(Array);
