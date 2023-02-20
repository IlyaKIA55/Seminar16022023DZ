// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк в массиве:");
int numberOfRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве:");
int columnNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки:");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца:");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] GetArray()
{
    int[,] array = new int[numberOfRows, columnNumber];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void CheckArray(int[,] array)
{
    if (rows < 0 || columns < 0 || rows > array.GetLength(0) - 1 || columns > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine("Элемент массива: " + array[rows, columns]);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] array = GetArray();
Console.WriteLine("Массив: ");
PrintArray(array);
CheckArray(array);
