/*Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] arrey = new int[size];
    for(int i = 0;  i < size; i++)
        arrey[i] = new Random().Next(minValue, maxValue + 1);

    return arrey;
}
void ShowArrey(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
//разворот массива
void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    /* ввели переменную j и упростили написание кода
    for(int i = 0; j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    
}

Console.Write("input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine ());

int[] myArray = CreateRandomArray(n,min, max);
ShowArrey(myArray);
ReverseArray(myArray);
ShowArrey(myArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*bool Triangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
    {
        return true;
    }
    else
    {
       return false;
    }
}
Console.WriteLine("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
bool res = Triangle(a, b , c);
Console.WriteLine(res);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b
/*int[] Fibonacci(int a, int b, int size)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number a: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = Fibonacci(min, max, n);
ShowArray(myArray);
*/


//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int[] Copy(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ShowArray(Copy(myArray));