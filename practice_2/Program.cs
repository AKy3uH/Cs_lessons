//выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46 782 -> 72 918 -> 98

// Random random = new Random();

// int randomNumber = random.Next(100,1000);

// int thirdDigit = randomNumber % 10;
// int firstDigit = randomNumber / 100;
// int newDigit = firstDigit * 10 + thirdDigit;

// Console.WriteLine (randomNumber);
// Console.Write(newDigit);


//будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
//Если второе число не кратно первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 16, 4 -> кратно

// Console.WriteLine ("Введите 2 числа:");
// int numA = int.Parse(Console.ReadLine());
// int numB = int.Parse(Console.ReadLine());
// if(numA % numB == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("некратно, остаток " + numA % numB);
// }


//принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число:");
// int numA = int.Parse(Console.ReadLine());
// if (numA % 7 == 0 && numA % 23 == 0)
// {
//     Console.WriteLine("кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("НЕкратно");
// }


//принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.WriteLine("Введите 2 числа:");
// int numA = int.Parse(Console.ReadLine());
// int numB = int.Parse(Console.ReadLine());
// if ( numB == numA * numA | numA == numB * numB)
// {
//     Console.WriteLine("квадрат");
// }
// else
// {
//     Console.WriteLine("НЕквадрат");
// }