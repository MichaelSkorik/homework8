int rows = new Random().Next(2, 9);
int columns = new Random().Next(2, 9);

int[,] Array = new int[rows, columns];

int[,] CreateArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] ReCreateArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("массив:");
CreateArray(Array, rows, columns);
PrintArray(Array, rows, columns);

Console.WriteLine("новый массив:");
ReCreateArray(Array, rows, columns);
PrintArray(Array, rows, columns);