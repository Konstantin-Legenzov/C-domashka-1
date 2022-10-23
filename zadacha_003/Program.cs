// Задача написать программу которая принимает на вход число и выдаёт является ли оно чтным или нет

int a;
string UserEnter;

Console.Write("Введите число: ");
UserEnter = Console.ReadLine()!;
a = int.Parse(UserEnter);

if(a%2 != 0)
    {
    Console.Write("Нечётное число");
    }

else
    {
    Console.Write("Чётное число");
    }

