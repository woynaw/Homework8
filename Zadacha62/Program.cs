void Spiral(int[,] arg)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= 16)
    {

        arg[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < 3) // условия движения вправо
            j++;
        else if (i < j && i + j >= 3) // условия движения вниз
            i++;
        else if (i >= j && i + j > 3) // условия движения влево
            j--;
        else  // условия движения вверх
            i--;
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
int[,] array = new int[4, 4];
Spiral(array);
Print2DArray(array);