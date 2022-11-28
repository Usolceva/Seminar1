/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNum(int num)
{
    if(num > 1) ShowNum(num - 1);
    Console.Write(num + " ");
}
ShowNum(5);
*/
/*Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SummNum(int n)
{
    if(n !=0) return SummNum(n / 10) + n % 10;
    return 0;
}
Console.WriteLine(SummNum(1234));
*/
/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNumbers(int m, int n)
{
    if(m > n)
    {
       ShowNumbers(m - 1, n);
       Console.Write(m + " ");
    } 
     else
   {
     if(n > m) ShowNumbers(n - 1, m);
     Console.Write(n + " ");
   }  
}
Console.Write("input a number: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine ());
ShowNumbers(m,n);
*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
double PowNum(double a, double b)
{
    if (b > 0)
       return PowNum(a, b - 1) * a;
    if(b < 0)
         return PowNum(a, b - 1) / a;
      return 1;
}
Console.Write("input a number: ");
double a = Convert.ToDouble(Console.ReadLine ());
Console.Write("input a number: ");
double b = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine(PowNum(a,b));