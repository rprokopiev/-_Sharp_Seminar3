
bool IsInputValid(int a)
{
    if(a<1)
    {
        return false;
    }
    return true;
}

Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine());
bool isValid = IsInputValid(A);
if (isValid)
{
    int sum = CalculateSum(A);
    Console.WriteLine("Sum = " + sum);

}
else
{
    Console.WriteLine("error");
}

int CalculateSum(int n)
{
    int sum = 0;
    for (int i = 1; i<=n; i++)
    {
        sum+=i;
    }
    return sum;
}





