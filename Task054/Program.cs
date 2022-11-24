Console.Clear();



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите Строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите Колонки: ");
int column = int.Parse(Console.ReadLine());
int[,] matrix = new int[row, column];
const int cellWidth = 3;

void FillTriagle()
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

void SortRow()
{
    int transpond = matrix[0, 0];
    int min = matrix[0, 0];
    for (int k = 0; k < column; k++)
    {
        for (int i = 0; i < row; i++)
        {
            min = matrix[i, k];

            for (int j = k; j < column; j++)
            {
                if (matrix[i, j] <min) 
                {
                    min = matrix[i, j];
                    transpond = matrix[i, j - j + k];
                    matrix[i, j - j + k] = matrix[i, j];
                    matrix[i, j] = transpond;
                }
            }
        }
    }
}



Console.WriteLine();
FillTriagle();
PrintMatrix();
SortRow();
PrintMatrix();