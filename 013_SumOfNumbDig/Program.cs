int SumOfIntegRanks(string messag)
{
    int IntegerLenght(int n)
{
    int i = 0;
    while (i < n)
    {
        n = n/10;
        i++; 
    }
    return i;
}      
    Console.WriteLine("Введите чило");
    int number = int.Parse(Console.ReadLine());
    int Lght = IntegerLenght(number);
    int sum = 0;
    int m = 0;
    for (int i=0; i<Lght; i++)
    {
        m = number % 10;
        sum = sum + m;
        number = number / 10;
    }
    return sum;
}
int N = SumOfIntegRanks("Введите натуральное число ");
Console.WriteLine(N);