Console.Clear();



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

const int cellWidth = 3;

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatricesMultiplication(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth}");
        }
        Console.WriteLine($"|");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matrix, int[,] matrixTwo)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth}");
        }
        if (i == 1) Console.Write($"| X ");

        else if (i< matrixTwo.GetLength(0))Console.Write($"|   ");
              else  Console.WriteLine($"|");  
                 
        if (i< matrixTwo.GetLength(0)) 
        {
             for (int j = 0; j < matrixTwo.GetLength(1); j++)
             {
                 Console.Write($"|{matrixTwo[i, j],cellWidth}");
             }
             Console.WriteLine($"|");            
        }        
    }
    Console.WriteLine();
}

void MultiplicationMatrices(int[,] matrix, int[,] matrixTwo, int[,] multiplication)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                multiplication[i, j] += matrix[i, k] * matrixTwo[k, j];
            }
        }        
    }   
}



Console.Write("Введите cтроки певой матицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колонки певой матицы: ");
int column = int.Parse(Console.ReadLine());
int[,] matrixFyrst = new int[row, column];

Console.Write("Введите cтроки втоой матрицы матицы: ");
row = column;
Console.WriteLine(row);
Console.Write("Введите колонки певой матицы: ");
column = int.Parse(Console.ReadLine());
int[,] matrixSecond = new int[row, column];
int[,] matricesMultiplication = new int[matrixFyrst.GetLength(0), matrixSecond.GetLength(1)];



FillMatrix(matrixFyrst);
FillMatrix(matrixSecond);

PrintMatrix(matrixFyrst, matrixSecond);
Console.WriteLine();

Console.WriteLine();
MultiplicationMatrices(matrixFyrst, matrixSecond, matricesMultiplication);
Console.WriteLine();

PrintMatricesMultiplication(matricesMultiplication);

// выводит
// Введите cтроки певой матицы: 3
// Введите колонки певой матицы: 2
// Введите cтроки втоой матрицы матицы: 2(автозаполнение)
// Введите колонки певой матицы: 4
// |  8|  7|   |  1|  5|  8|  5|
// |  3|  2| X |  8|  3|  2|  7|
// |  6|  8|




// | 64| 61| 78| 89|
// | 19| 21| 28| 29|
// | 70| 54| 64| 86|