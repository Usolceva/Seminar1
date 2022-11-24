//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//метод генерации 2-мерного массива
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
//вывод 2-мерного массива на 

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
         for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

         Console.WriteLine();
    }
         
}
Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine ());

int[,] myArrey = CreateRandom2dArray(m, n,min, max);
Show2dArray(myArrey);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}
//вывод 2-мерного массива на 

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
         for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

         Console.WriteLine();
    }
         
}
Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine ());

int[,] myArrey = CreateRandom2dArray(m, n);
Show2dArray(myArrey);
*/
/*
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
//вывод 2-мерного массива на 
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
         for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

         Console.WriteLine();
    }
         
}

void QuartElement(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
       for(int j = 0; j < array.GetLength(1); j+=2)
       {
            array[i,j] *= array[i,j];
       }
    } 
}
Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine ());

int[,] myArray = CreateRandom2dArray(m, n,min, max);
Show2dArray(myArray);
QuartElement(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
//вывод 2-мерного массива на 
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
         for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

         Console.WriteLine();
    }
}

int SumElement(int[,] array)
{
    /*
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             if(i==j) sum +=array[i,j];
        } 
    }
    return sum;
    */
    //не нужно прверять все элементы, если индекс строки(i) и индекс стролбца(j) равны, поэтому бежим только по i, программа работает быстрее
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1);  i++)
    sum +=array[i,i];
    return sum;
}
Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine ());

int[,] myArray = CreateRandom2dArray(m, n,min, max);
Show2dArray(myArray);
int result = SumElement(myArray);
Console.WriteLine($"sum of elements: {result}");
