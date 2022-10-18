void IsNumberInArray(int [] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) 
        {
            i++;
            Console.WriteLine("Да");
            break;
        }
        if (i == array.Length -1) Console.WriteLine("Нет");
    }
        
}
void PrintStringArray(string[] arr)
{
    Console.Write("[");
    int Lght = arr.Length;
    for(int i = 0; i<(Lght-1); i++)
    {
        Console.Write(arr[i]);
        Console.Write(",");
    }
    Console.Write(arr[Lght-1]);
    Console.Write("]");
}
void GetStringArrayInInt(int [] intArr, string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        intArr[i] = int.Parse(EntryArray[i]);
    } 
}

Console.WriteLine("Enter array numbers divided with blank");
string Entry = Console.ReadLine();
string [] EntryArray = Entry.Split(" ",StringSplitOptions.RemoveEmptyEntries);
int [] blabla = new int [EntryArray.Length];
GetStringArrayInInt(blabla,EntryArray);

Console.WriteLine("Enter the number to check");
int N = int.Parse(Console.ReadLine());

IsNumberInArray(blabla, N);
