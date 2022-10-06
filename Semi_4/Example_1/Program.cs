/* Доп задача 1

Console.Write("Введите значение радиуса : ");
int radius = Convert.ToInt32(Console.ReadLine());
double area = Math.PI * radius * radius;
Console.WriteLine($"Радиус круга радиусом {radius} равен {Convert.ToInt32(area)}");
int number = Convert.ToInt32(area);
string s = Convert.ToString(number);
int lenght = s.Length;
int max = 0;
for(int i = 0; i < lenght; i++ )
{
    int buff = number % 10;
    if(buff > max)
    {
        max = buff;
    }
    number /= 10;
}

Console.WriteLine($"Максимальная цифра в циcле радиуса {radius} равнна {max}");
*/

/* Доп задача 2 

string[] getSity(int Number)
{
    //Console.WriteLine("Введите поочередно названия пяти городов для проверки : ");
    string[] Сities = new string[5];
    for(int i = 0; i < Number ; i++)
    {
        Console.WriteLine($"Введите название {i+1} города для проверки : ");
        Сities[i] = Convert.ToString(Console.ReadLine());
        Console.WriteLine($"Город[{i+1}] = {Сities[i]} ", i ,Сities[i]);
    }
    return Сities;
}

void Input () 
{
    Console.WriteLine("Введите букву для проверки : ");
    char Test = Convert.ToChar(Console.ReadLine());
    string s = Convert.ToString(Test);
        
    if (s.Length > 1) 
    {
        Console.WriteLine ("Вы ввели больше одной буквы");
        Input();
        return;
    }
    Console.WriteLine (s);
}
 
int getTestCharToString(string[] UserСities, int Usernum )
{
    for(int i = 0; i < UserСities.Length ; i++)
    {
        char[] arr = UserСities[i].ToCharArray();
    }
    
    
}


Console.WriteLine("Введите число городов : ");
int num = Convert.ToInt32(Console.ReadLine());
string[] Arrey = getSity(num);

Input();
*/
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



