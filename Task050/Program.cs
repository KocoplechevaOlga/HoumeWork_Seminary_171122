// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

int[,] FillMatrixRnd(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd  = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.Next(min, max);
            }
    } 
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j], 5}");
        }
        Console.WriteLine("|");
    }
}
bool FindElemMatrixFromPos (int [,] matr, int i, int j)
{
    bool b = false;
    if (i <= matr.GetLength(0) && j <= matr.GetLength(1)) b = true;
    return b;
}

Console.WriteLine("Введите количество строк:");
int matrixRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int matrixColums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
int b = Convert.ToInt32(Console.ReadLine())+1;
int [,] myMatrix = FillMatrixRnd(matrixRows, matrixColums, a, b);
PrintMatrix(myMatrix);
Console.WriteLine(" ");

Console.WriteLine("Введите индекс по строке искомого числа:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс по столбцу искомого числа:");
int k = Convert.ToInt32(Console.ReadLine());

bool f = FindElemMatrixFromPos (myMatrix, l, k);
Console.WriteLine (FindElemMatrixFromPos (myMatrix, l, k) ? 
    ($"Искомое число {myMatrix[l,k]}") 
    : "Такого элемента нет в заданном массиве");
