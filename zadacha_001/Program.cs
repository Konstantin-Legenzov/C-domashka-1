// Задача показывающее большее и меньшее число

int a, b;


string userEnter, userEnter2;

Console.WriteLine("Введите ПЕРВОЕ число: ");
userEnter = Console.ReadLine()!;

a = int.Parse(userEnter);

Console.WriteLine("Введите второе число: ");
userEnter2 = Console.ReadLine()!;

b = int.Parse(userEnter2);

if(a<b)
{
   Console.WriteLine($"Минимальное число = {a}");
   Console.WriteLine($"Максимальное число = {b}");
}
else
{
    Console.WriteLine($"Минимальное число = {b}");
    Console.WriteLine($"Максимальное число = {a}"); 
}