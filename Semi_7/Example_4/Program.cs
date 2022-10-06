/*
Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(data);
    Console.ResetColor();
}



void printArray(int rows, int columns)
{
    double[,] table = new double[rows, columns];
    Console.WriteLine();
    double result = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
            printColorData($"{table[i, j] = (i + j)}\t");
            }
            Console.Write($"{table[i, j] = (i + j)}\t");
        }
        Console.WriteLine("");
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + table[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма значений по главной диагонали = {result}");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.Write(table[i,j] + "+");
            }
        }
    }
    
}

Console.WriteLine("Введите число строк");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int userColumns = Convert.ToInt32(Console.ReadLine());

printArray(userRows, userColumns);
