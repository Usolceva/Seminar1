/*
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowRange(int quart)
{
   if (quart == 1)
    Console.WriteLine("x > 0 and y > 0");
     else if (quart == 2)
    Console.WriteLine("x < 0 and y > 0");
    else if (quart == 3)
    Console.WriteLine("x < 0 and y < 0");
     else if (quart == 4)
    Console.WriteLine("x > 0 and y < 0");
    else
    Console.WriteLine("Wront number");
}

Console.WriteLine("Input a number quart: ");
int quartnum = Convert.ToInt32(Console.ReadLine());
ShowRange(quartnum);
*/

/*
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int ShowQuart (int numX, int numY)
{
   int cuartnum = 0;
    if(numX > 0 && numY > 0)
      cuartnum = 1;
   else if(numX < 0 && numY > 0)
     cuartnum = 2;
   else if(numX < 0 && numY < 0)
     cuartnum = 3;
   else if(numX > 0 && numY < 0)
      cuartnum = 4;
return cuartnum;
}
Console.WriteLine("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
int res = ShowQuart(x, y);
if  (res == 0)
    Console.WriteLine("Wront number");
else
{
Console.WriteLine($"number of quart {res}");
}
*/
/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Teorema(double X1, double Y1, double X2, double Y2)
{
    double rolsFirst = X1 - X2;
  rolsFirst = Math.Pow(rolsFirst, 2);
  double rolsSecond = Y1 - Y2;
  rolsSecond = Math.Pow(rolsSecond, 2);
  double hypotinuza = rolsFirst + rolsSecond;
  double quartHypotinuza = Math.Sqrt(hypotinuza);
  return quartHypotinuza;
}
Console.Write("Input x1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y = Convert.ToInt32(Console.ReadLine());
double res = Teorema(x1, y1, x2, y2);
Console.WriteLine($"lens {res}");
*/

//Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
void Square (int num)

double k = 1;

    while (k <= num)
{
       k = Math.Pow(k,2);
        k++;
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Square(num);








