// Задача 64

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Func(n);

void Func(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        Func(n - 1);
    }
}

//Задача 66

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());

Sum(n,m);

void Sum(int n, int m)
{
    int sum = 0;
    for (int i = n; i <= m; i++)
        sum += i;
        Console.WriteLine(sum);
}

//Задача 68

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(AkkermanFunc(m,n));

int AkkermanFunc(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
	if  (m > 0 && n == 0)
	{
		return AkkermanFunc(m - 1, 1);
	}
	return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
