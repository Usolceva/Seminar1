
//Задайте двумерный массив. Напишите программу, которая поменяет местами любые строки массива.
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
//вывод 2-мерного массива на 

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 <array.GetLength(0) && 
    row2 >= 0 && row2 < array.GetLength(0) &&
     row1 != row2)
      {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
      }
      else Console.WriteLine("incorect rows for changing!");
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
/*
//запрос от пользователя номера строк для замены,
// -1 потому что номер индекса строки меньше чем номер строки т.е(строка 6 её индекс 5)
Console.Write("imput number of first row change: ");
int r1 = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("imput number of second row change: ");
int r2 = Convert.ToInt32(Console.ReadLine())-1;

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);
*/
/*
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
void Replace(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 1 + i; j < array.GetLength(1); j++)
            {
             int temp = array[i, j];
             array[i, j]= array[j, i];
             array[j, i] = temp;
            }
    }
    else Console.WriteLine("incorect rows for changing!");
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
Console.WriteLine();
Replace(myArray);
Show2dArray(myArray);
*/

//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] DeleteRowColumn(int[,] array)
{
    int posi = 0;
    int posj = 0;
    int min = array[posi, posj];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[posi, posj])
            {
            min = array[i, j];
            posi = i;
            posj = j;
            }
        }
    int[,] newarr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    { 
        if (i != posi)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
            {
                if (j != posj)
                {
                    newarr[x,y] = array[i,j];
                }
                else y--;
            }           
        }
        else x--;
    }
return newarr;
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
Console.WriteLine();
int[,] arr = DeleteRowColumn(myArray);
Show2dArray(arr);