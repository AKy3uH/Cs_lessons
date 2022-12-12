// выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру этого числа:

Random random = new Random();

int randomNumber = random.Next(10,100);

int secondDigit = randomNumber % 10;
int firstDigit = randomNumber / 10;

Console.WriteLine(randomNumber);

if(firstDigit>secondDigit)
{
    Console.WriteLine (firstDigit);
}
else
{
    Console.WriteLine (secondDigit);
}