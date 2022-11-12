//string[] Str = new string[] {"hello", "2", "world", ":-)"};
//string[] Str = new string[] {"1234", "1567", "-2", "computer science"};
string[] Str = new string[] {"Russia", "Kazan", "Denmark"};
string[] Fin = new string[Str.Length];

void FillArray(string[] Str, string[] Fin)
{
    int count = 0;
    for (int i = 0; i < Str.Length; i++)
    {
        if(Str[i].Length <= 3)
        {
            Fin[count] = Str[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(Str, Fin);
PrintArray(Fin);
