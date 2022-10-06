/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/
void printResult(int rows, int columns)
{
    double[,] table = new double[rows, columns];
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Console.Write($"{table[i, j] = Math.Pow((double)(i + j), 2)}\t");
            }
            else Console.Write($"{table[i, j] = i + j}\t");
        }
        Console.WriteLine("");
    }
}
Console.WriteLine("Введите число строк");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int userColumns = Convert.ToInt32(Console.ReadLine());

printResult(userRows, userColumns);