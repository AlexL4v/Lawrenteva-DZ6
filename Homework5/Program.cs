// Задача 1
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int val = new Random().Next(5, 10);
Console.WriteLine($"Введите {val} чисел через пробел");
string[] Line = Console.ReadLine().Split(' ');
int count = 0;
for (int i = 0; i < val; i++)
{
    int[] massiv = new int[val];
    massiv[i] = Convert.ToInt32(Line[i]);
    if(massiv[i] > 0) count++;
}
Console.WriteLine($"Положительных чисел {count} ");
*/
// Задача 1 Вариант 2
/*
int M = new Random().Next(5, 10);
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a> 0) count++;
}
Console.WriteLine($"Количество положительных чисел {count}");
*/


// Задача 2
// Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, 
// а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

Console.WriteLine("Введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numB = Convert.ToInt32(Console.ReadLine());

int[,] Ramka = new int[numA,numB];
{
    for (int i = 0; i < numA; i++)
    {
        for (int j = 0; j < numB; j++)
        {
            if(i==0 || j == 0 || i == numA-1 || j == numB -1) Ramka[i,j] = 1;
            else Ramka[i,j] = 0;
            Console.Write(Ramka[i, j] + " ");
        }
        Console.WriteLine();
    }
}