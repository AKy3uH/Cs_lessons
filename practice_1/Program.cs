//на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.WriteLine("Введите два числа ");
// int numA = int.Parse(Console.ReadLine());
// int numB = int.Parse(Console.ReadLine());
// if (numA == (numB * numB))
// {
//     Console.Write("Квадрат");
// }
// else
// {
//     Console.Write("НЕ Квадрат");
// }


//будет выдавать название дня недели по заданному номеру.

// Console.WriteLine("Введите индекс дня недели (1-7) ");
// int num = int.Parse(Console.ReadLine());
// if ((num > 0) & (num < 8))
// {
//     if (num == 1)
//     {
//         Console.WriteLine("1 это понедельник");
//     }
//     if (num == 2)
//     {
//         Console.WriteLine("2 это вторник");
//     }
//     if (num == 3)
//     {
//         Console.WriteLine("3 это среда");
//     }
//     if (num == 4)
//     {
//         Console.WriteLine("4 это четверг");
//     }
//     if (num == 5)
//     {
//         Console.WriteLine("5 это пятница");
//     }
//     if (num == 6)
//     {
//         Console.WriteLine("6 это суббота");
//     }
//     if (num == 7)
//     {
//         Console.WriteLine("7 это воскресенье");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели неверный индекс дня недели");
// }


//должна принимать на входе число N, а на выходе выдать все целые числа между -N и N.

// Console.WriteLine("Введите целое число ");
// int a = int.Parse(Console.ReadLine());
// if (a > 0)
// {
//     for (int i = -a; i <= a; i++)
//     {
//         Console.Write(" " + i);
//     }
// }
// else
// {
//     for (int i = a; i <= -a; i++)
//     {
//         Console.Write(" " + i);
//     }
// }


//принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.WriteLine("Введите 3-значное число ");
// int num = int.Parse(Console.ReadLine());
// if (num<1000 & num>99)
// {
//     num = num % 10;
//     Console.Write("крайняя цифра cправа " + num);
// }
// else
// {
//     Console.Write("Введённое число НЕ 3-значное");
// }