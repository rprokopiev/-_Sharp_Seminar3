int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int N = PrintAndGetValue("Введите целочисленное число");

if (N > 0)
{
    for(int i = 1; i<=N; i++)
    {
        double result = Math.Pow(i,2);
        Console.Write(result +" ");
    }
}
else if (N < 0)
{
    for(int i = N; i<0; i++)
    {
        double result = Math.Pow(i,2);
        Console.Write(result +" ");
    }
}
else
{
    Console.WriteLine("Ошибка");
}


