// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int GetSumBetween2Numbers(int m, int n, int sum = 0)
{
    if (m == n)
    {
        sum += m;
        return sum;
    }
    else
    {
        sum += m;
        m++;
        return GetSumBetween2Numbers(m, n, sum);
    }
}

int M = 4;
int N = 8;

Console.WriteLine(GetSumBetween2Numbers(M, N));

