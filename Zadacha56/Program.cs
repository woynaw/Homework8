

void Random2DArray(int[,] arg, int min, int max)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinRow(int[,] arg)
{
    int sum = 0;
    int predsum = 100000;
    int row = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sum += arg[i, j];
        }
        if (sum < predsum) row = i;
        predsum = sum;
        sum = 0;
    }
    return row;
}

int[,] array = new int[4, 4];
Random2DArray(array, 1, 10);
Print2DArray(array);
Console.WriteLine($"{MinRow(array)+1} строка");

