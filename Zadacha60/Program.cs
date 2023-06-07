

void Print3DArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k}) ");
                Console.Write($"{arg[i, j, k]} ");
            }

        }
        Console.WriteLine();
    }
}

void Random3DArrayNoDuplicates(int[,,] arg)
{
    int[] array = new int[8];
    int rand;
    int pos = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 99 + 1);
        rand = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 99 + 1);
                    j = 0;
                    rand = array[i];
                }
                rand = array[i];
            }
        }
    }

    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                arg[i, j, k] = array[pos];
                pos++;
            }
        }
    }
}


int[,,] array = new int[2, 2, 2];
Random3DArrayNoDuplicates(array);
Print3DArray(array);