// Задача 1 
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// A < B + C стороны треугольника


int a = new Random().Next(10, 15);
int b = new Random().Next(10, 12);
int c = new Random().Next(2, 5);
Console.Write($"Может ли существовать треугольник со сторонами {a} см, {b} см, {c} см?");
Console.WriteLine();
if(a<b+c & b<a+c & c<a+b) Console.WriteLine("Да");
else Console.WriteLine("Нет");


// Задача 2
// Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.



void binar (int num)
{
    string bi = "";
    while (num > 0)
    {
        bi = Convert.ToString(num%2) + bi;
        num = num/2;
    }
    Console.WriteLine(bi);
}
Console.WriteLine("Введите целое натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
binar(n);


// Задача 3
// Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibonacci (int num)
{
    
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    Console.Write("0 1 ");
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
        
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int N = new Random().Next(4,20);
Console.WriteLine(N);
Fibonacci(N);

// Задача 4
// Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования. 

int[,] array = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i,j] = new Random().Next(10, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
