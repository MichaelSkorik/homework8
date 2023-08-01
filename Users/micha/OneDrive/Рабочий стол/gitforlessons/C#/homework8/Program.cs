int rows = 2;
int columns = 2;
int height = 2;
int[,,] Array = new int[rows, columns, height];

int[,,] CreateArray(int[,,] array, int rows, int columns, int height)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < height; k++)
            {
                array[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array, int rows, int columns, int height)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < height; k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }

    }

}

CreateArray(Array, rows, columns, height);
PrintArray(Array, rows, columns, height);