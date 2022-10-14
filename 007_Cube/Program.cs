int PrintReadIntReturn(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int Number = PrintReadIntReturn("Введите число");
int i = 1;
while(i < Number)
{
    double N = Math.Pow(i, 3);
    Console.Write(N);
    Console.Write(", ");
    i++;
}
double Last = Math.Pow(Number, 3);
Console.Write(Last);
