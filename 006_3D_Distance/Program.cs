int PrintReadIntReturn(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine());
    return N;
}

void ArrayFill3Ind(int[] ar)
{
    int i = 0;
    int l = 3;
    ar[i] = PrintReadIntReturn("Введите X");
    i++;
    ar[i] = PrintReadIntReturn("Введите Y");
    i++;
    ar[i] = PrintReadIntReturn("Введите Z");
}

void ArrayPrint(int[] ar)
{
    int i = 0;
    int l = ar.Length;
    while (i<l)
    {
        Console.Write(ar[i]);
        Console.Write(" / ");
        i++;
    }
}

Console.WriteLine("Координаты А:");
int [] A = new int [3];
ArrayFill3Ind(A);

Console.WriteLine("Координаты B:");
int [] B = new int [3];
ArrayFill3Ind(B);

Console.Write("Коордениты А: ");
ArrayPrint(A);
Console.WriteLine();
Console.Write("Коордениты B: ");
ArrayPrint(B);

double AB = Math.Sqrt(Math.Pow((A[0]- B[0]), 2) + Math.Pow((A[1]- B[1]), 2) + Math.Pow((A[2]- B[2]), 2));

Console.WriteLine();
Console.WriteLine("Расстояние между А и B;");
Console.WriteLine(AB);