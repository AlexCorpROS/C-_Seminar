/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4


void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
 
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void ChangeToSquareInEvenPosition( int [,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < Matrix.GetLength(1); j+=2)
        {
             Matrix[i,j] *=Matrix[i,j];
        }
    }
}
//int[,] generateArray = generate2DArray(7,5,-100,100);
int[,] TwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(TwoDArray);
Console.WriteLine();
ChangeToSquareInEvenPosition(TwoDArray);
print2DArray(TwoDArray);
*/

/*Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
 
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] GetElementsOfDiagonals ( int [,] Matrix)
{
    int Bound = Math.Min(Matrix.GetLength(0),Matrix.GetLength(1));
    int[] diagonal = new int[Bound];
    for (int i = 0; i < Bound; i++)
    {
        diagonal[i] = Matrix[i,i];
    }
    return diagonal;
}
int GetSumOfDiagonals ( int [] Diagonal)
{
    int sum =0;
    for (int i = 0; i < Diagonal.Length; i++)
    {
        sum+= Diagonal[i];
    }
    return sum;
}
void printArrayWithSum (int[] Diagonal)
{
    Console.Write(Diagonal[0]);
    for (int i = 1; i < Diagonal.Length; i++)
    {
        Console.Write($" + {Diagonal[i]}");
    }
    int sum = GetSumOfDiagonals(Diagonal);
    Console.Write($" = {sum}");
}
//int[,] generateArray = generate2DArray(7,5,-100,100);
int[,] TwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(TwoDArray);
Console.WriteLine();
int[] diagonal = GetElementsOfDiagonals (TwoDArray);
printArrayWithSum(diagonal);
