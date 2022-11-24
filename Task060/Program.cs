Console.Clear();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


const int cellWidth = 3;

void FillMatrix(int[,,] matrix)
{
    int[] UniqueArray = new int[89];
    int num;

    for (int i = 0; i < UniqueArray.Length; i++)
    {
        num = new Random().Next(10, 100);
        for (int j = i; j >= 0; j--)
        {
            if (UniqueArray[j] == num)
            {
                num = new Random().Next(10, 100);
                j = i;
            }
        }
        UniqueArray[i] = num;
    }
    num = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = UniqueArray[num];
                num++;                     
            } 
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
            Console.Write($"{matrix[i, j, k],cellWidth}({i}, {j}, {k})");
           } 
           Console.WriteLine($"");
            
        }
        
    }
    Console.WriteLine();
}


Console.Write("Введите cтроки  матицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите колонки матицы: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите глубины  матицы: ");
int length = int.Parse(Console.ReadLine());
if (row * column * length >= 89)
{
    Console.WriteLine("Произведение 3-х параметров размера массива больше 89");
    Console.WriteLine("Повтарите ввод");
    Console.Write("Введите cтроки  матицы: ");
    row = int.Parse(Console.ReadLine());
    Console.Write("Введите колонки матицы: ");
    column = int.Parse(Console.ReadLine());
    Console.Write("Введите глубины  матицы: ");
    length = int.Parse(Console.ReadLine());   
}

int[,,] matrixFyrst = new int[row, column, length];
FillMatrix(matrixFyrst);
PrintMatrix(matrixFyrst);
Console.WriteLine();

// Введите cтроки  матицы: 2
// Введите колонки матицы: 2
// Введите глубины  матицы: 7
//  16(0, 0, 0) 28(0, 0, 1) 80(0, 0, 2) 25(0, 0, 3) 31(0, 0, 4) 39(0, 0, 5) 70(0, 0, 6)
//  68(0, 1, 0) 57(0, 1, 1) 23(0, 1, 2) 92(0, 1, 3) 17(0, 1, 4) 79(0, 1, 5) 11(0, 1, 6)
//  49(1, 0, 0) 42(1, 0, 1) 48(1, 0, 2) 51(1, 0, 3) 36(1, 0, 4) 60(1, 0, 5) 47(1, 0, 6)
//  10(1, 1, 0) 67(1, 1, 1) 64(1, 1, 2) 14(1, 1, 3) 74(1, 1, 4) 55(1, 1, 5) 30(1, 1, 6)







