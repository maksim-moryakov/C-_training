int a = 4;
double sqrtA = Math.Sqrt(a); // корень квадратный из а, в нашем случае корень из 4 = 2
Console.WriteLine(sqrtA);

int b = 2;
double sqrtB = Math.Pow(b, 2); // возведение b в степень 2, в нашем случае 4. Можно вместо 2 передать переменную
// Можно также b * b
Console.WriteLine(sqrtB);

// Перевод в строку. В данном случае лишний перевод в число, а потом опять в строку.
string number = Convert.ToString(int.Parse(Console.ReadLine()));
// Строка 13 аналогичная 11
string number2 = Console.ReadLine();