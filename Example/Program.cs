// Напишите задачу которая выводит случайное число из отрезка [ 10, 99 ] и показывает макс его цифру
/*Random rand = new Random();
int number;
number = rand.Next(10, 100);
Console.WriteLine($"Выводится случайное число: " + number);
int tens = number / 10;
int ones = number % 10;

Console.WriteLine("Наибольшая цифра числа: ");

if(tens > ones) 
{
    Console.Write(tens);
}
else
{
    Console.Write(ones);
}
*/

// упоминание Метод void 49:00:00

//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
Random rand = new Random();
int number;
number = rand.Next(100, 1000);
Console.WriteLine($"Выводится случайное число: " + number);
int hundrets = number / 100;
int tens = number / 10;
int ones = number % 10;

Console.WriteLine($"Удаляя вторую цифру получим: {hundrets}{ones}");
*/

/*12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b % a;
if(c == 0)
{
    Console.WriteLine($"{b} is divided(кратно) {a}!");
}
else
{
    Console.WriteLine($"{b} doesn't divided {a} remainder(остаток) = {c}");
}
*/

/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да 
Console.WriteLine("Enter number: ");
int number = intRead();
// Можно решить через if(number % 7 == 0 & number % 23 == 0) & -и | -или 
if (number % 7 == 0)
{
    if(number % 23 == 0)
    {
        Console.WriteLine($"{number} кратно!");
    }
    else 
    {
        Console.WriteLine($"{number} не кратно!");
    }
}

else 
{
    Console.WriteLine($"{number} не кратно!");
}


*/

//функция void:
int intRead()
{
    return Convert.ToInt32(Console.ReadLine());
}

// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine("Enter number A: ");
int a = intRead();
Console.WriteLine("Enter number B: ");
int b = intRead();
if(a == b * b)
{
    Console.WriteLine($"Number {b} is square of {a} ");
}
else if(b == a * a)
{
    Console.WriteLine($"Number {a} is square of {b} ");

}
else if (b != a * a & a != b * b)
{
    Console.WriteLine("!Error!");
}
*/