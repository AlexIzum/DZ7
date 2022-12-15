// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.WriteLine("Введите кол-во строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m,n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
    { for (int j = 0; j < n; j++)
    {Console.WriteLine($"{matr[i, j]} ");}
Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 {matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);