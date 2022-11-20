// адайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Например:    m = 3, n = 4.
//              0,5 7 -2 -0,2
//              1 -3,3 8 -9,9
//              8 7,8 -7,1 9

double[,] FillMatrixRnd(int rows, int colums, double min, double max)
{
    double[,] matrix = new double [rows, colums];
    Random rnd  = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = Math.Round((rnd.NextDouble()*(max-min)+min), 2);
            }
    } 
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1 ) Console.Write($"{matrix[i,j], 8} |");
            else Console.Write($"{matrix[i,j], 8}");
        }
        Console.WriteLine("|");
    }
}


Console.WriteLine("Введите количество строк:");
int matrixRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int matrixColums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
double b = Convert.ToDouble(Console.ReadLine())+1;
double [,] myMatrix = FillMatrixRnd(matrixRows, matrixColums, a, b);
PrintMatrix(myMatrix);
Console.WriteLine(" ");
