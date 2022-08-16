// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// А потом выдаёт произведение чисел от 1 до А.
// 4  -> 24
// 5  -> 120

// Функция считает сумму чисел от 1 до А.
int sum (int a) 
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        result = result + i;
    }
    return result;
}

// Функция выдаёт произведение чисел от 1 до А.
int multiplication (int a) 
{
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
}


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(sum(a));
Console.WriteLine(multiplication(a));

