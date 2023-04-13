// #1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int cifra(int a)
// {
//     int result = ((a / 10) % 10);
//     return result;
// }

// Console.Write("Введите трёхзначное число: ");
// int numa = Convert.ToInt32(Console.ReadLine());
// int vvod = cifra(numa);
// Console.Write($"Вторая чифра числа {numa} это {vvod}");

// # 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int cifra3(int num)
// {
//     int result = -1;
//     if (num >= 100)
//     {
//         while (num > 999 )
//         {
//             num = num / 10;
//         }
//         result = num % 10;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int chislo = cifra3(a);
// Console.WriteLine($"Третья цифра числа {a} это {chislo}");

// #3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool DniNed(int den)
// {
//     if (den == 6 || den == 7)
//         return true;
//     else   
//         return false;
// }
// Console.Write("Введите день недели(от 1 до 7): ");
// int a = Convert.ToInt32(Console.ReadLine());
// bool den = DniNed(a);
// Console.WriteLine ($"День недели {a} является {den}");




