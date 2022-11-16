// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackermann(int m, int n, int a = 0)
{
    if (m == 0)
    {
        a = n + 1;
        return a;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return a;
}

int m = 3;
int n = 2;
if (m>=0 && n>=0)
{
    Console.WriteLine(Ackermann(m,n));
}
else Console.WriteLine("Error");

