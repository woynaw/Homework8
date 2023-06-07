void Random2DArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 9 + 1);
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
int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return result;
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
Random2DArray(matrix1);
Random2DArray(matrix2);
Console.WriteLine("1 матрица");
Print2DArray(matrix1);
Console.WriteLine("2 матрица");
Print2DArray(matrix2);
Console.WriteLine("Результат");
Print2DArray(Multiply(matrix1, matrix2));