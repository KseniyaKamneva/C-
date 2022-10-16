// Задача 54

Console.WriteLine("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[str,cols];
FillArray(array);
Print(array);

Console.WriteLine($"\nИтоговый массив: ");
SortArray(array);
Print(array);

void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int indestr = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = indestr;
        }
      }
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Nestrt(-10, 10);
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

//Задача 56

Console.WriteLine("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[str,cols];
FillArray(array);
Print(array);

int minStr  = 0;
int sum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int minSum = Sum(array, i);
  if (sum > minSum)
  {
    sum = minSum;
    minStr  = i;
  }
}

Console.WriteLine($"\nCтрокa с наименьшей суммой элементов: {minStr + 1}");


int Sum(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Nestrt(-10, 10);
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


// Задача 58

Console.WriteLine("Введите количество строк матрицы А: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы А и строк матрицы В: ");
int colstr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы В: ");
int col= Convert.ToInt32(Console.ReadLine());

int[,] MartristrA = new int[str, colstr];
FillArray(MartristrA);
Console.WriteLine($"\nМатрица А:");
Print(MartristrA);

int[,] MartristrB = new int[colstr, col];
FillArray(MartristrB);
Console.WriteLine($"\nМатрица В:");
Print(MartristrB);

int[,] resMatristr = new int[str,col];

MultMatristr(MartristrA, MartristrB, resMatristr);
Console.WriteLine($"\nПроизведение матриц А и В:");
Print(resMatristr);

void MultMatristr(int[,] MartristrA, int[,] MartristrB, int[,] resMatristr)
{
  for (int i = 0; i < resMatristr.GetLength(0); i++)
  {
    for (int j = 0; j < resMatristr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < MartristrA.GetLength(1); k++)
      {
        sum += MartristrA[i,k] * MartristrB[k,j];
      }
      resMatristr[i,j] = sum;
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Nestrt(-10,10);
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задача 60

Console.WriteLine("Введите измерение str: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите измерение Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите измерение Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[str, y, z];
FillArray(array);
Print(array);

void Print (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i}{j}{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillArray(int[,,] array)
{
  int[] indestr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  num;
  for (int i = 0; i < indestr.GetLength(0); i++)
  {
    indestr[i] = new Random().Nestrt(10, 100);
    num = indestr[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (indestr[i] == indestr[j])
        {
          indestr[i] = new Random().Nestrt(10, 100);
          j = 0;
          num = indestr[i];
        }
          num = indestr[i];
      }
    }
  }
  int count = 0; 
  for (int str = 0; str < array.GetLength(0); str++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[str, y, z] = indestr[count];
        count++;
      }
    }
  }
}

//Задача 62

int n = 4;
int[,] spiralMatristr = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= spiralMatristr.GetLength(0) * spiralMatristr.GetLength(1))
{
  spiralMatristr[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < spiralMatristr.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatristr.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatristr.GetLength(1) - 1)
    j--;
  else
    i--;
}

Print(spiralMatristr);

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

// Задача 61

Console.WriteLine("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());

double[,] pascTr = new double[str + 1, 2 * str + 1];

FillPascTr(pascTr);
Console.WriteLine();
ChangePascTr(pascTr);

Console.WriteLine();
Print(pascTr);

void ChangePascTr(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillPascTr(double[,] pascTr)
{
  for (int k = 0; k < pascTr.GetLength(0); k++)
  {
    pascTr[k, 0] = 1;
  }
  for (int i = 1; i < pascTr.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascTr[i, j] = pascTr[i - 1, j] + pascTr[i - 1, j - 1];
    }
  }
}

void Print(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}
