//Подготовка к решению Д/З
int IntRead()
{
    return Convert.ToInt32(Console.ReadLine());
}

// ДЕНИС, СПАСИБО ВАМ БОЛЬШОЕ, Я РАЗОБРАЛСЯ С void

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5 
782 -> 8 
918 -> 1*/
void Case10()
{
    Console.Write("Enter number from 100 till 999: ");
    int number = IntRead();
    int div = 100;
    int hundrets = number / div;
    int tens = number % 100 / 10;
    
    if( hundrets % 10 > 0 & hundrets < 10)
    {
        Console.WriteLine(tens);
    }
    else 
    {
        Console.WriteLine("Error: entered incorrekt number!");
        Console.WriteLine("use <dotnet run> again and enter number from 100 till 999!");
    }
}
//Case10();

/* Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645->5
78 -> третьей цифры нет 
32679 -> 6 */
void Case13()
{
    Console.Write("Enter number: ");
    int number =IntRead();
    int count = 10;
    int i = -1;
    int thirdDigit;
    while(count < number )
    {
        count = count * 10;
        i ++;
    }
    //Console.WriteLine($"count= {count}, i= {i}");
    if(count > number && number > 100)
    {
        int step = Convert.ToInt32(Math.Pow(10, i));
        int ost = (number % step);
        //Console.WriteLine(ost);
        thirdDigit = ost / (step / 10); 
        Console.WriteLine($"Third digit of your number is {thirdDigit}");
    }
    else
    {
        Console.WriteLine("There is no THIRD digit.");
    }
}


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6->да 
7->да 
1->нет */
void Case15()
{
    Console.Write("Enter number of day of week: ");
    int day = IntRead();
    if(day == 1)
    {
        Console.WriteLine($"{day} day of week is Monday.");
    }
    else if(day == 2)
    {
        Console.WriteLine($"{day} day of week is Tuesday.");
    }
    else if(day == 3)
    {
        Console.WriteLine($"{day} day of week is Wednesday.");
    }
    else if(day == 4)
    {
        Console.WriteLine($"{day} day of week is Thursday.");
    }
    else if(day == 5)
    {
        Console.WriteLine($"{day} day of week is Friday.");
    }
    else if(day == 6)
    {
        Console.WriteLine($"{day} day of week is Saturday");
    }
    else if(day == 7)
    {
        Console.WriteLine($"{day} day of week is Sunday");
    }
    else
    {
        Console.WriteLine($"Error: {day} day of week can't be find");

    }
}
//Case15();