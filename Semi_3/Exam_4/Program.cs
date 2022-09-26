/*Задача 30: Напишите программу, которая выводит массив из 8 
элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
printArray(array);

void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(","); 
        }
    }
    Console.WriteLine("]");
}



/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/



Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = 1;
if(userNumber != 0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"Количество знаков в числе {result}");
