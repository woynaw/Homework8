

void SelectionSort(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            int maxPosition = col;

            for (int j = col + 1; j < array.GetLength(1); j++)
            {
                if (array[row, j] > array[row, maxPosition]) maxPosition = j;
            }

            int temp = array[row, col];
            array[row, col] = array[row, maxPosition];
            array[row, maxPosition] = temp;
        }
    }

}

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

int[,] array = new int[3, 4];
Random2DArray(array, 1, 10);
Print2DArray(array);
Console.WriteLine();
SelectionSort(array);
Print2DArray(array);
