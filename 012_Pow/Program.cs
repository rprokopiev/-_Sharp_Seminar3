int Pow(string message1, string message2)
{
    Console.WriteLine(message1);
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine(message2);
    int B = int.Parse(Console.ReadLine());
    int C = A;
    if (B <=0)
    {
        Console.WriteLine("Ошиба ввода, B должно быть > 0");
    }
    else
    {
        int i = 0;
        while (i < B)
        {
            C = C*A;
            i++;
        }
        Console.WriteLine(C);
    }
    return C;
          
}

int C = Pow("Введите число А", "Введите число B");
