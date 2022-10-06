/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Write("Введите число элементов ряда фибонначи : ");
int number_N = Convert.ToInt32(Console.ReadLine());

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

void FirstNFibonacciNumbers(int user_number)
{
    int[] ArrayFibinaciNum = new int[user_number];
    ArrayFibinaciNum[0] = 0;
    ArrayFibinaciNum[1] = 1;    
    for (int i = 2; i < user_number; i++)
    {
        ArrayFibinaciNum[i] = ArrayFibinaciNum[i-1] + ArrayFibinaciNum[i-2];        
    }
    printArray(ArrayFibinaciNum);
}

FirstNFibonacciNumbers(number_N);
