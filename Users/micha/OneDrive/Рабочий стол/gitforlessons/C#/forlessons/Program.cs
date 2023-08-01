int rows = new Random().Next(2, 9);
int columns = new Random().Next(2, 9);

int[,] Array = new int[rows, columns];

int[] counter = new int[10];

int[,] CreateArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            int element = array[i, j];
            counter[element]++;
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

CreateArray(Array, rows, columns);
PrintArray(Array, rows, columns);

Console.WriteLine("Частотный словарь элементов двумерного массива:");
for (int element = 0; element < counter.Length; element++)
{
    int frequency = counter[element];
    if (frequency > 0)
    {
        Console.WriteLine($"Элемент {element} встречается {frequency} раза");
    }
}