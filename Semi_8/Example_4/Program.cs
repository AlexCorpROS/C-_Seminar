/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] GenerateArray(int height, int weight, int value)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(0, value);
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
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] getMinElement2dArray(int[,] inputArray)
{
    int min = inputArray[0, 0];
    int positionI = 0;
    int positionJ = 0;
    int[] resultArray = new int[3];    
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i, j] < min)
            {                
                min = inputArray[i, j];
                positionI = i ;
                positionJ = j ;
            }
        }
    }
    resultArray[0] = min;
    resultArray[1] = positionI;
    resultArray[2] = positionJ;
    return resultArray;
}

int[,] getDeleteMinValueElementsStrCol(int[,] inputArray, int [] minElementPos)
{
    int[,] tempResult = new int[inputArray.GetLength(0)-1, inputArray.GetLength(1)];
    int[,] outResult = new int[inputArray.GetLength(0)-1, inputArray.GetLength(1)-1];
    int x = 0;
    int y = 0;
    int row = minElementPos[1];
    int column = minElementPos[2];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        } 
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            tempResult[x, j] = inputArray[i, j];
        }
        x++;
    }
    
    for (int j = 0; j < tempResult.GetLength(1); j++)
    {   
        if (j == column)
        {
            column-= 1;
            continue;
        }     
        for (int i = 0; i < tempResult.GetLength(0); i++)
        {            
            outResult[i, y] = tempResult[i, j];            
        }
        y++;
    }
    return outResult;            
}

int[,] generatedArray = GenerateArray(5, 5, 100);
Console.WriteLine("Сгенерированный двумерный массив имеет вид : ");
showArray(generatedArray);
int[] minElementPos = getMinElement2dArray(generatedArray);
Console.WriteLine("Значение и позиция минимального элемента в заданном массиве: ");
printArray(minElementPos);
int[,] outputArray = getDeleteMinValueElementsStrCol(generatedArray,minElementPos);
Console.WriteLine("Массив с удаленными строкой и столбцом минимального элемента исходного массива :");
showArray(outputArray);