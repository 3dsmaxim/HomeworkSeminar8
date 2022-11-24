Console.Clear();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите Строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите Колонки: ");
int column = int.Parse(Console.ReadLine());
int[,] matrix = new int[row, column];
const int cellWidth = 3;

void FillMatrix()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }

}

void PrintMatrix()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth}");
        }
        Console.WriteLine($"|");
    }
    Console.WriteLine();
}

void SumRowMin()
{
    // int transpond = matrix[0, 0];
    int minSumRow = 0;
    int minSum = 0;
    int sum = 0;
   
    for (int j = 0; j < column; j++)
    {
        minSum += matrix[0, j];

    }
    for (int i = 0; i < row; i++)
    {  
        for (int j = 0; j < column; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
        sum = 0;
    }
    for (int j = 0; j < column; j++)
    {
        Console.Write($"|{matrix[minSumRow, j],cellWidth}");
    }
    Console.WriteLine($"| минемальная сумма в стоке {minSumRow + 1}");
}



Console.WriteLine();
FillMatrix();
PrintMatrix();
SumRowMin();
