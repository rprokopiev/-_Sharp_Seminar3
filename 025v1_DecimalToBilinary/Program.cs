Console.WriteLine("enter");
int number = int.Parse(Console.ReadLine());

int k;
string result = "";

while (number > 0);
{
    k = number % 2;
    number = number / 2;
    result = k + result;
}

// Console.WriteLine(result);
// Console.WriteLine(Convert.ToString(number,2));
Console.WriteLine(Conv(number));

string Conv (int number)
{
    if (number == 0) return "";
    return k + Conv (number / 2);
}