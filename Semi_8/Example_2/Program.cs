// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height,weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j] = new Random().Next(-deviation, deviation+1);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[,] SwopRows(int[,] inputArray)
{
        int[,] bufferArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                bufferArray[j,i] = inputArray[i,j];
            }
        }
    return bufferArray;
}

int[,] generatedArray = GenerateArray(5,5,10);
showArray(generatedArray);
if(generatedArray.GetLength(0) == generatedArray.GetLength(1))
{
    int[,] swoppedArray = SwopRows(generatedArray);
    showArray(swoppedArray);
}
else Console.WriteLine("Выполнить данную программу невозможно, так как количество строк отлично от количества столбцов");