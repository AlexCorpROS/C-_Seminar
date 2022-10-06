// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите число A");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В");
int number_B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С");
int number_C = Convert.ToInt32(Console.ReadLine());

int IsTriangleIsReal(int length_a, int length_b, int length_c)
{
    int result = 0;
    if (length_a > length_b + length_c || length_b > length_a + length_c || length_c > length_b + length_a)
    {
        result = 0;
    }

    else 
    {
        result = 1;
    }
    return result;
}
void IsTriangleIsRealPrintResult(int result_int)
{
    if (result_int == 0)
    {
        Console.WriteLine("треугольник с сторонами такой длины НЕ может существовать");
    }
    else
    {
        Console.WriteLine("треугольник с сторонами такой длины  может существовать");
    }
}

int result_int = IsTriangleIsReal(number_A,number_B,number_C);
IsTriangleIsRealPrintResult(result_int);