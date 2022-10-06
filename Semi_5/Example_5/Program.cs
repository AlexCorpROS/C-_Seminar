// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

int[] getCopyArray(int[] UserArray)
{
    int[] CopyArray = new int[UserArray.Length];
    for (int i = 0; i < UserArray.Length; i++)
    {
        CopyArray[i] = UserArray[i];
    }
    return CopyArray;
}

int[] InputArray = new int[5] {1,2,3,4,5};
int[] Copy = getCopyArray(InputArray);
printArray(InputArray);
printArray(Copy);