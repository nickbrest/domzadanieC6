// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[,] SquareIndex (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
    }
return matrix;
}

int[,] matrix = CreateMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SquareIndex(matrix);
PrintMatrix(matrix);