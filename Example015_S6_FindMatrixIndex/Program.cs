// Задача с семинара. Найти элемент массива.

void FillMatrix(int[,] matrix, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
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

(int, int)? FindMatrixIndexes(int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == value)
                return (i,j);
    return null;
}


Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 1, 20);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.Write("Enter value to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int, int)? coordinates = FindMatrixIndexes(matrix, value);  // (int, int) - кортеж
if (coordinates !=null)
    Console.WriteLine($"Position of element: {coordinates.Value.Item1} {coordinates.Value.Item2}");
else
    Console.WriteLine("There is no element in matrix");