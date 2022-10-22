Console.WriteLine("enter");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("должно быть " + Convert.ToString(x,2));
Console.WriteLine("рекурсия " + Conv(x)); 

int N = x;
int k;
string res = "";

do
{
    k = N % 2;
    N = N / 2;
    res = k + res;
}while (N > 0);

Console.WriteLine("while " + res);


string Conv (int N)
{
    if (N == 0) return "0";
    int Z =N%2;
    return Z + Conv (N / 2);
}