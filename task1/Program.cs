// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateMatrix(int length, int width)
{
    double[,] matrix = new double[length, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.NextDouble() * 100;
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(5, 3);
PrintMatrix(matrix);