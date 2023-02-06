// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.
// //Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = Generate2DArray(4, 6); 

Print2DArray(arr);

if(m < arr.GetLength(0) && n < arr.GetLength(1))
{
    Console.WriteLine(arr[m, n]);
}
else 
{
    Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}