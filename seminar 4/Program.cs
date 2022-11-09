/*
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int Summ (int num)
{
  int sum = 0;

     for(int current = 1; current <= num; current++)
     sum += current;

 return sum;
}
Console.Write("Imput a number: ");
int a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine($"sum of number between 1 fnd {a} is {Summ(a)}");
*/
/*
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int Find(int num)
{
    int digit = 0;
    while (num != 0)
    {
        num /= 10;
        digit ++;
    }
    return digit;
}
Console.Write("number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Find (number)}");
*/

//Написать программу, которая определит произведение чисел от 1 до N

int Prod(int num)
{
    int product = 1;
    for(int current= 1; current <= num; current ++)
    {
         product *= current;
    }
    return product;
}
Console.Write("number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Prod(number)}");