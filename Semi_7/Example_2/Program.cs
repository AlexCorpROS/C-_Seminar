/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
void printResult(int rows, int columns)
{
    double[,] table = new double[rows, columns];
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j] = (i + j)}\t");
        }
        Console.WriteLine("");
    }
}
Console.WriteLine("Введите число строк");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int userColumns = Convert.ToInt32(Console.ReadLine());

printResult(userRows, userColumns);