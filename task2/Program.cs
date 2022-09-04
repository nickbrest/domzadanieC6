// Задать двумерный массив следующим правилом: Aₘₙ = m+n (? т.е. значение ячейки равно сумме ее индексов?)

int[,] CreateMatrixSumm(int length, int width)
{
    int[,] matrix = new int[length, width];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
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

int[,] matrix = CreateMatrixSumm(5, 5);
PrintMatrix(matrix);