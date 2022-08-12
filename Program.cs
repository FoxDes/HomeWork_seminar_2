// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string list = Convert.ToString(a);

// Console.WriteLine(list[1]);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string list = Convert.ToString(a);
int b = 123;
string c = Convert.ToString(b);

if (a >= b)
{
    Console.WriteLine("Третья цифра заданного числа" + " " + list[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}