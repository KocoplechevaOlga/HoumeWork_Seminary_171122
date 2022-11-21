// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

double[,] FillMatrixRnd(int rows, int colums, double min, double max)
{
    double[,] matrix = new double [rows, colums];
    Random rnd  = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = Math.Round((rnd.NextDouble()*(max-min)+min), 0);
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
double [] AverFromColums (double [,] matrix)
{
    double [] array = new double [matrix.GetLength(1)];
    int k = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += Math.Abs(matrix[i,j]);
        }
        array[k] = Math.Round(sum / matrix.GetLength(1), 2);
        k+=1;
    }
    return array;
}
void PrintArray(double[] arr)
{
    int j = 0;
    Console.Write("|");
    for (j = 0; j < (arr.Length); j++)
    {
        Console.Write($"{arr[j], 8} | ");
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

double [] arrayWithAver = AverFromColums(myMatrix);
PrintArray(arrayWithAver);

